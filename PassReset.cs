using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_ShopManagementSystem
{
    public partial class PassReset : Form
    {

        private readonly string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                                  "Initial Catalog=MyDatabase;" +
                                                  "Integrated Security=True;Encrypt=False"; // Update with your actual connection string

        private string userPhoneNo;
        private string username;

        public PassReset(String phone, string username)
        {
            InitializeComponent();

            this.userPhoneNo = phone;
            this.username = username;


            this.FormClosing += new FormClosingEventHandler(passReset_FormClosing);
        }

        private void passReset_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Prevent closing if "No" is clicked
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        private void ConfirmPasslbl_Click(object sender, EventArgs e)
        {
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LogInForm login = new LogInForm();
            login.Show();
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
          
            string newPass = passtxtbox.Text;
            string confirmpass = confirmpassbox.Text;

            // Check if the password fields are empty
            if (string.IsNullOrWhiteSpace(newPass))
            {
                MessageBox.Show("Please Enter Your New Password.");
                return; // Stop further processing
            }

            if (string.IsNullOrWhiteSpace(confirmpass))
            {
                MessageBox.Show("Confirm password box cannot be empty. Please re-enter your new password.");
                return; // Stop further processing
            }

            // Check if the passwords match
            if (newPass != confirmpass)
            {
                MessageBox.Show("Passwords do not match! Please try again.");
                return; // Stop further processing
            }

            // Proceed with updating the password if all checks pass
            string result = UpdatePasswordInDatabase(newPass);

            // Show the result message
            MessageBox.Show(result);

            // If password update is successful, you can navigate back to the login form or handle accordingly
            if (result == "Password updated successfully!")
            {
                this.Hide(); // Hide the password reset form
                LogInForm login = new LogInForm(); // You can navigate to the login form or perform another action
                login.Show();
            }
        }
        // Method to update password in the database
        private string UpdatePasswordInDatabase(string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to update the password where either (email and phone) or (username and phone) match
                string query = "UPDATE UserInfo SET Password = @Password WHERE (Username = @Username OR Email = @Email) AND Phone = @Phone";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Password", newPassword);  // The new password entered by the user
                command.Parameters.AddWithValue("@Username", username);     // The username of the logged-in user
                command.Parameters.AddWithValue("@Email", username);        // The email (could be the same value as username)
                command.Parameters.AddWithValue("@Phone", userPhoneNo);     // The phone number of the logged-in user

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    // Log the number of affected rows
                    Console.WriteLine("Rows Affected: " + rowsAffected);

                    // Check if the password was successfully updated
                    if (rowsAffected > 0)
                    {
                        return "Password updated successfully!";
                    }
                    else
                    {
                        return "Password update failed. No matching user found.";
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception if something goes wrong
                    Console.WriteLine("Error: " + ex.Message);
                    return "Error updating password: " + ex.Message;
                }
            }
        }

        private void passtxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
