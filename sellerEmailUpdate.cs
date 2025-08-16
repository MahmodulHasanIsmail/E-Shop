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
    public partial class selleremailupdate : Form
    {
        private readonly string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                                  "Initial Catalog=MyDatabase;" +
                                                  "Integrated Security=True;Encrypt=False";
        public selleremailupdate()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(sellerEmailUpdate_FormClosing);
        }

        private void sellerEmailUpdate_FormClosing(object sender, FormClosingEventArgs e)
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

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mbltxtbox.Text) ||
      string.IsNullOrWhiteSpace(passtxtbox.Text) ||
      string.IsNullOrWhiteSpace(usernametxtbox.Text))
            {
                MessageBox.Show("Please Enter all the required information", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mobileNo = mbltxtbox.Text; // Get the mobile number input
            string password = passtxtbox.Text; // Get the password input
            string username = usernametxtbox.Text;

            string result = VerifyIdentity(mobileNo, password, username);

            // Show the result (either success or error)
            MessageBox.Show(result);

            // If identity is verified, open the email reset form (Form 2)
            if (result == "Identity verified successfully. Proceed with email reset.")
            {
                selleremailreset resetForm = new selleremailreset( mobileNo, username); // Create instance of Form2
                resetForm.Show(); // Show Form2 (emailReset)
                this.Hide(); // Hide Form1 (forgetEmail)
            }
        }
        private string VerifyIdentity(string mobileNo, string password, string username)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to find the user by mobile number and username
                string query = "SELECT * FROM SellerInfo WHERE mobileNo = @mobileNo AND username = @username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@mobileNo", mobileNo);
                command.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) // User found
                {
                    string storedPassword = reader["Password"].ToString(); // Get the stored password
                    string storedUsername = reader["username"].ToString(); // Get the stored DOB

                    // Compare the entered password with the stored password
                    if (password == storedPassword && storedUsername == username)
                    {
                        return "Identity verified successfully. Proceed with email reset.";
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

        private void gobacklinklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ForgetEmailForm().Show();
            this.Hide();
        }
    }
    
}
