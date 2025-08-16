using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace E_ShopManagementSystem
{
    public partial class LogInForm : Form
    {
       
        public LogInForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(LogInForm_FormClosing);
        }
        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linklbl2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            resetPassword form = new resetPassword();
            form.Show();

            
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                "Initial Catalog=MyDatabase;" +
                                "Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionString);

            string email = usernamebox.Text;
            string password = passwordbox.Text;
            try
            {
                // Query to fetch the AdminID for the matching credentials
                string queryAdmin = "SELECT AdminID FROM AdminInfo WHERE email = @email AND password = @password";
                SqlCommand cmdAdmin = new SqlCommand(queryAdmin, con);
                cmdAdmin.Parameters.AddWithValue("@email", email);
                cmdAdmin.Parameters.AddWithValue("@password", password);

                // Query to check for User credentials
                string queryUser = "SELECT COUNT(*) FROM UserInfo WHERE Email = @Email AND Password = @Password";
                SqlCommand cmdUser = new SqlCommand(queryUser, con);
                cmdUser.Parameters.AddWithValue("@Email", email);
                cmdUser.Parameters.AddWithValue("@Password", password);

                // Query to check for Seller credentials
                string querySeller = "SELECT COUNT(*) FROM SellerInfo WHERE email = @email AND password = @password";
                SqlCommand cmdSeller = new SqlCommand(querySeller, con);
                cmdSeller.Parameters.AddWithValue("@email", email);
                cmdSeller.Parameters.AddWithValue("@password", password);

                con.Open();

                // Execute and retrieve results
                object adminIDObj = cmdAdmin.ExecuteScalar(); // AdminID if found
                int sellerResult = (int)cmdSeller.ExecuteScalar(); // If seller credentials match
                int userResult = (int)cmdUser.ExecuteScalar(); // If user credentials match

                if (adminIDObj != null) // If admin is found
                {
                    int adminID = Convert.ToInt32(adminIDObj); // Get AdminID from query result
                    MessageBox.Show("Welcome Admin! You have Administrative Access!");

                    // Pass AdminID to AdminPage to access admin-specific data
                    new AdminPage(adminID).Show();
                    this.Hide();
                }
                else if (sellerResult > 0) // If seller is found
                {
                    MessageBox.Show("Seller login successful.");
                    new sellerAdm().Show();
                    this.Hide();
                }
                else if (userResult > 0) // If user is found
                {
                    MessageBox.Show("Login successful!");
                    new mainform2(email).Show(); // Pass email to main form for the user
                    this.Hide();
                }
                else
                {
                    // If none of the above conditions are met, show invalid login message
                    MessageBox.Show("Invalid username or password.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        
        




        private void linklbl1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgetEmailForm form3 = new ForgetEmailForm();
            form3.Show();

            


        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            if (passwordbox.PasswordChar == '\0')
            { 
                passwordbox.PasswordChar = '*';
                showbtn.Text = "Show";  
            }
            else 
            {
                
                passwordbox.PasswordChar = '\0';
                showbtn.Text = "Hide"; 
            }
        }

        private void linklbl3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             this.Hide();
            RegisterForm form = new RegisterForm();
            form.Show();
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            mainform mainform = new mainform();
            mainform.Show();
        }
    }
}
