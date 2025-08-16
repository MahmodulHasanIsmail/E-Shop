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
    public partial class ModifyUserForm : Form
    {

        private string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                         "Initial Catalog=MyDatabase;" +
                                         "Integrated Security=True;Encrypt=False";

        string Uname;
        string Phone;
        int adminID;

        public ModifyUserForm( string username, string phone)
        {
            InitializeComponent();
            this.Uname = username;
            this.Phone = phone;
            this.FormClosing += new FormClosingEventHandler(ModifyUserForm_FormClosing);

        }

        private void ModifyUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void ModifyUserForm_Load(object sender, EventArgs e)
        {

            Console.WriteLine($"Username: {Uname}, Phone: {Phone}");
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                string query = "SELECT FullName, Username,Email, Phone, Password FROM UserInfo WHERE Username = @Username AND Phone = @Phone";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", Uname);
                cmd.Parameters.AddWithValue("@Phone", Phone);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    FullNameBox.Text = reader["FullName"].ToString();
                    usernamebox.Text = reader["Username"].ToString();
                    mailbox.Text = reader["Email"].ToString();
                    mobileBox.Text = reader["Phone"].ToString();
                    passwordBox.Text = reader["Password"].ToString();
                }
                else
                {
                    MessageBox.Show("User not found.");
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

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = FullNameBox.Text.Trim();
            string email = mailbox.Text.Trim();
            string phone = mobileBox.Text.Trim();
            string username = usernamebox.Text.ToString();
            string password = passwordBox.Text.Trim();

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return; // Stop further execution if email is invalid
            }

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                // Start building the UPDATE query
                string query = "UPDATE UserInfo SET ";
                bool isFirst = true;

                // Check if fields are not empty, and add to query accordingly
                if (!string.IsNullOrEmpty(fullName))
                {
                    query += "FullName = @FullName";
                    isFirst = false;
                }
                if (!string.IsNullOrEmpty(username))
                {
                    if (!isFirst) query += ", ";
                    query += "Username = @Username";
                    isFirst = false;
                }
                if (!string.IsNullOrEmpty(email))
                {
                    if (!isFirst) query += ", ";
                    query += "Email = @Email";
                    isFirst = false;
                }
                if (!string.IsNullOrEmpty(phone))
                {
                    if (!isFirst) query += ", ";
                    query += "Phone = @Phone";
                    isFirst = false;
                }
                if (!string.IsNullOrEmpty(password))
                {
                    if (!isFirst) query += ", ";
                    query += "Password = @Password";
                }

                // Specify WHERE clause to update the correct user
                query += " WHERE Username = @Username AND Phone = @Phone";

                // Debugging: Print the query for inspection
                Console.WriteLine("Executing query: " + query);

                // Prepare the command
                SqlCommand cmd = new SqlCommand(query, con);

                // Add parameters only for the modified fields
                if (!string.IsNullOrEmpty(fullName)) cmd.Parameters.AddWithValue("@FullName", fullName);
                if (!string.IsNullOrEmpty(username)) cmd.Parameters.AddWithValue("@Username", username);  // Ensure username is always passed
                if (!string.IsNullOrEmpty(email)) cmd.Parameters.AddWithValue("@Email", email);
                if (!string.IsNullOrEmpty(phone)) cmd.Parameters.AddWithValue("@Phone", phone);  // Ensure phone is always passed
                if (!string.IsNullOrEmpty(password)) cmd.Parameters.AddWithValue("@Password", password);

                // Open the connection and execute the query
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if rows were affected
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User details updated successfully.");
                }
                else
                {
                    MessageBox.Show("No changes were made.");
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
            // Regex for basic email validation
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           new LogInForm().Show();
           this.Hide();

            
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            new AdminPage(adminID).Show();
            this.Hide();
        }
    }     
}
