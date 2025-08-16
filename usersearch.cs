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
    public partial class usersearch : Form
    {

        private string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                         "Initial Catalog=MyDatabase;" +
                                         "Integrated Security=True;Encrypt=False";
        int adminID;
        public usersearch()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(usersearch_FormClosing);
            
        }

        private void usersearch_FormClosing(object sender, FormClosingEventArgs e)
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

        private void usersearch_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();  
            string phone = textBox2.Text.Trim();        

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Enter all the required information.");
                return;
            }

            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                // Query to check if the user exists
                string query = "SELECT COUNT(*) FROM UserInfo WHERE username = @username AND Phone = @Phone";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@Phone", phone);

                con.Open();

                int userCount = (int)cmd.ExecuteScalar();

                if (userCount > 0) // User found
                {
                    DialogResult result = MessageBox.Show("User found!Click yes to delete user.Click No to Modify User Details.Click cancel to go back", "User Found", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes) // Delete user
                    {
                        // Delete query
                        string deleteQuery = "DELETE FROM UserInfo WHERE Username = @Username AND Phone = @Phone";
                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                        deleteCmd.Parameters.AddWithValue("@Username", username);
                        deleteCmd.Parameters.AddWithValue("@Phone", phone);
                        deleteCmd.ExecuteNonQuery();

                        MessageBox.Show("User deleted successfully.");
                    }
                    else if (result == DialogResult.No) // Modify user
                    {
                        // Redirect to modify user form
                        ModifyUserForm modifyForm = new ModifyUserForm(username, phone); // Pass email and phone
                        modifyForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("User not found in the system.");
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AdminPage( adminID).Show();
            this.Hide();
        }
    }
    }

