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
    public partial class adminadd : Form
    {

        private string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                         "Initial Catalog=MyDatabase;" +
                                         "Integrated Security=True;Encrypt=False";

        int adminID;
        public adminadd()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(adminadd_FormClosing);
            
        }

        private void adminadd_FormClosing(object sender, FormClosingEventArgs e)
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

        private void adminadd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Get values from the TextBox controls
            string email = adminemailbox.Text.Trim();  // Admin ID textbox (trim spaces)
            string adminIDText = adminidbox.Text.Trim();         // Email textbox (trim spaces)
            string password = adminpassbox.Text.Trim();      // Password textbox (trim spaces)

            // Validate if any fields are empty
            if (string.IsNullOrEmpty(adminIDText) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Admin ID, Email, or Password cannot be empty.");
                return;
            }
            // Validate if AdminID is a valid integer
            int adminID;
            if (!int.TryParse(adminIDText, out adminID)) // If conversion fails
            {
                MessageBox.Show("Admin ID must be a valid integer.");
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            // Create a connection to the database
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                string query = "INSERT INTO AdminInfo (AdminID, Email, Password) VALUES (@AdminID, @Email, @Password)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AdminID", adminID);  // Ensure AdminID is passed as an integer
                cmd.Parameters.AddWithValue("@Email", email);      // Email as NVARCHAR
                cmd.Parameters.AddWithValue("@Password", password); // Password as NVARCHAR

                con.Open();

                // Execute the query and check if the row was inserted successfully
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("New Admin added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add new Admin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }
        private bool IsValidEmail(string email)
        {
            // Define a regular expression for a valid email address
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);  // Return true if the email matches the pattern
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            new AdminPage(adminID).Show();
            this.Hide();
        }
    }
    
}

