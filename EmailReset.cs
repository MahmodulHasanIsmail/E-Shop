using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_ShopManagementSystem
{
    public partial class mailChangeForm : Form
    {
        private readonly string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                                  "Initial Catalog=MyDatabase;" +
                                                  "Integrated Security=True;Encrypt=False"; // Update with your actual connection string

        private string userPhoneNo;
        private string username;



        public mailChangeForm(String phone,string username)
        {
            InitializeComponent();


            this.userPhoneNo = phone;
            this.username = username;


            this.FormClosing += new FormClosingEventHandler(MailChangeForm_FormClosing);
        }
        private void MailChangeForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string newEmail = newMailBox.Text; // Get the new email input
            string password = passBox.Text;    // Get the password input

            // Validate email format
            if (string.IsNullOrWhiteSpace(newEmail) || !IsValidEmail(newEmail))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your current password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Call the method to verify the password and update email in the database
            string result = VerifyPasswordAndUpdateEmail(password, newEmail);

            // Show result message
            MessageBox.Show(result);

            if (result == "Email updated successfully!")
            {
                // Redirect to the login page after a successful email change
                LogInForm login = new LogInForm();  // Create the login form instance
                login.Show();  // Show the login form
                this.Hide();
            }



        }
        // Method to validate email format
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        private string VerifyPasswordAndUpdateEmail(string currentPassword, string newEmail)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to find the user by username and phone
                string query = "SELECT * FROM UserInfo WHERE Username = @Username AND Phone = @Phone";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Phone", userPhoneNo);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) // User found
                {
                    string storedPassword = reader["Password"].ToString(); // Get the stored password
                    DateTime storedDob = Convert.ToDateTime(reader["DateOfBirth"]);

                    // Compare the entered password with the stored password
                    if (currentPassword == storedPassword)
                    {
                        // If password is correct, update the email
                        return UpdateEmailInDatabase(newEmail);
                    }
                    else
                    {
                        return "Incorrect password.";
                    }
                }
                else
                {
                    return "No user found.";
                }
            }
        }

        // Method to update email in the database
        private string UpdateEmailInDatabase(string newEmail)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to update the email where the username and phone match
                string query = "UPDATE UserInfo SET Email = @Email WHERE Username = @Username AND Phone = @Phone";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", newEmail);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Phone", userPhoneNo);

                int rowsAffected = command.ExecuteNonQuery();

                // Check if the email was successfully updated
                if (rowsAffected > 0)
                {
                    return "Email updated successfully!";
                }
                else
                {
                    return "Email update failed. Please try again.";
                }
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LogInForm form = new LogInForm();
            form.Show();
        }
    }
}
