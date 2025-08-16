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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace E_ShopManagementSystem
{
    public partial class selleremailreset : Form
    {

        private readonly string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                                  "Initial Catalog=MyDatabase;" +
                                                  "Integrated Security=True;Encrypt=False";

        private string mobileno;
        private string Username;
        public selleremailreset(string mobileNo,string username)
        {
            InitializeComponent();

            this.mobileno = mobileNo;
            this.Username = username;


            this.FormClosing += new FormClosingEventHandler(selleremailreset_FormClosing);
        }
        private void selleremailreset_FormClosing(object sender, FormClosingEventArgs e)
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
        private void selleremailreset_Load(object sender, EventArgs e)
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
                string query = "SELECT * FROM SellerInfo WHERE Username = @username AND mobileNo = @mobileNo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", Username);
                command.Parameters.AddWithValue("@mobileNo",mobileno);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) // User found
                {
                    string storedPassword = reader["password"].ToString(); // Get the stored password

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
                string query = "UPDATE SellerInfo SET email = @email WHERE username = @username AND mobileNo = @mobileNo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", newEmail);
                command.Parameters.AddWithValue("@username", Username);
                command.Parameters.AddWithValue("@mobileNo", mobileno);

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
            new selleremailupdate().Show();
            this.Hide();
        }
    }
}
