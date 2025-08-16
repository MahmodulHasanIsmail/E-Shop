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
    public partial class sellerverify : Form
    {

        private readonly string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                                 "Initial Catalog=MyDatabase;" +
                                                 "Integrated Security=True;Encrypt=False"; // Update with your actual connection string

      //  private string userPhoneNo;
       // private string username;

        public sellerverify()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(sellerverify_FormClosing);
        }
        private void sellerverify_FormClosing(object sender, FormClosingEventArgs e)
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
        

        private void sellerverify_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(noBox.Text) ||
       string.IsNullOrWhiteSpace(usernamebox.Text))
            {
                MessageBox.Show("Please Enter all the required information", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phone = noBox.Text; // Get the mobile number input
            string username = usernamebox.Text;

            string result = VerifyIdentity(phone, username);

            // Show the result (either success or error)
            MessageBox.Show(result);

            // If identity is verified, open the email reset form (Form 2)
            if (result == "Verification successfull.")
            {
               sellerPassReset resetForm = new sellerPassReset(phone, username); // Create instance of Form2
                resetForm.Show(); // Show Form2 (emailReset)
                this.Hide(); // Hide Form1 (forgetEmail)
            }
        }
        private string VerifyIdentity(string mobileNo, string username)
        {
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to find the user by mobile number and username
                string query = "SELECT * FROM SellerInfo WHERE (username = @username OR email = @email) AND mobileNo = @mobileNo ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@mobileNo", mobileNo);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@Email", username);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) // User found
                {
                    string storedUsername = reader["Username"].ToString();
                    string storedEmail = reader["Email"].ToString();
                    string storedPhone = reader["mobileNo"].ToString() ;

                    // Compare the entered password with the stored password
                    if ((username == storedUsername && storedPhone == mobileNo))
                    {
                        return "Verification successfull.";
                    }
                    else if (username == storedEmail && storedPhone == mobileNo)
                    {
                        return "Verification successfull.";
                    }
                    else
                    {
                        return "Incorrect username or date of birth.";
                    }
                }
                else
                {
                    return "No user found .";
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new resetPassword().Show();
            this.Hide();
        }
    }
    
}
