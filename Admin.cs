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
    public partial class AdminPage : Form
    {

        private string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                         "Initial Catalog=MyDatabase;" +
                                         "Integrated Security=True;Encrypt=False";

        int loggedInAdminID;
        
        public AdminPage(int adminID)
        {
            InitializeComponent();
            this.loggedInAdminID = adminID;
            this.FormClosing += new FormClosingEventHandler(AdminPage_FormClosing);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
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


        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;  
                panel1.Focus();       
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
                panel2.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (panel3.Visible)
            {
                panel3.Visible = false;
            }
            else
            {
                panel3.Visible = true;
                panel3.Focus();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new SellerRegi().Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new AddProduct().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new usersearch().Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            new sellersearch().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new usersearch().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new sellersearch().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string newEmail = textBox1.Text;
            string newPassword = textBox2.Text;

            if (string.IsNullOrWhiteSpace(newEmail) && string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("You Didn't Changed Anything.");
                return;
            }

            // Call method to update the admin info
            string result = UpdateAdminInfo(newEmail, newPassword);

            // Display result of update operation
            MessageBox.Show(result);
        }

        private string UpdateAdminInfo(string newEmail, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Base SQL query to update admin info
                string query = "UPDATE AdminInfo SET ";
                bool emailUpdated = false;
                bool passwordUpdated = false;

                // Check if we need to update the email
                if (!string.IsNullOrEmpty(newEmail))
                {
                    query += "Email = @Email";
                    emailUpdated = true;
                }

                // Check if we need to update the password
                if (!string.IsNullOrEmpty(newPassword))
                {
                    if (emailUpdated) // If email is being updated, add a comma to separate
                    {
                        query += ", ";
                    }
                    query += "Password = @Password";
                    passwordUpdated = true;
                }

                // Add condition to update only the logged-in admin
                query += " WHERE AdminID = @AdminID";  // Use AdminID to uniquely identify the admin to update

                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters only if they need to be updated
                if (emailUpdated)
                {
                    command.Parameters.AddWithValue("@Email", newEmail);
                }

                if (passwordUpdated)
                {
                    command.Parameters.AddWithValue("@Password", newPassword);
                }

                // Add AdminID to target the specific admin record
                command.Parameters.AddWithValue("@AdminID", loggedInAdminID); // Use the logged-in admin's AdminID

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return "Admin info updated successfully!";
                    }
                    else
                    {
                        return "Admin not found or no changes were made.";
                    }
                }
                catch (Exception ex)
                {
                    return "Error updating admin info: " + ex.Message;
                }
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new adminadd().Show();
            this.Hide() ;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LogInForm().Show();
            this.Hide() ;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new mainform().Show();
            this.Hide() ;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new sellerAdm().Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new sellerAdm().Show();
            this.Hide() ;
        }
    }
}
