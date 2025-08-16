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
    public partial class mainform2 : Form
    {
        private string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                          "Initial Catalog=MyDatabase;" +
                                          "Integrated Security=True;Encrypt=False";
        private string loggedInUsername;

        public mainform2(string email)
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(mainform2_FormClosing);
            userinfo.Visible = false;
            this.loggedInUsername = email;
        }
        private void mainform2_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Electronics().Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new beauty().Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new accessories().Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Books().Show();
                this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Ladies().Show();
            this.Hide();
        }

        private void lbl1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Gent_s_Fashion().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text.Trim();  // Get text from search TextBox

            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Please enter a product name to search.");
                return;
            }

            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                // Query to check if the product exists based on the product name
                string query = "SELECT COUNT(*) FROM Product WHERE ProductName = @ProductName";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ProductName", searchQuery); // Use parameterized query to avoid SQL injection

                con.Open();

                int productCount = (int)cmd.ExecuteScalar();

                // If product is found
                if (productCount > 0)
                {
                    MessageBox.Show("Product found!");
                }
                else
                {
                    MessageBox.Show("Product not found.");
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

        private void formlabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signuplabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void loginlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void sellerlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SellerRegi().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           new LogInForm().Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (userinfo.Visible)
            {
                userinfo.Visible = false;  // Hide profile details
            }
            else
            {
                userinfo.Visible = true;   // Show profile details
                LoadUserProfile();  // Load user profile information from the database
            }
        }
        private void LoadUserProfile()
        {
            String connectionStrin = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                     "Initial Catalog=MyDatabase;" +
                                     "Integrated Security=True;Encrypt=False";
           // SqlConnection con = new SqlConnection(connectionStrin);
            using (SqlConnection connection = new SqlConnection(connectionStrin))
            {
                connection.Open();

                // Query to fetch user details based on username
                string query = "SELECT Username, Email, Phone FROM UserInfo WHERE Email = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email",loggedInUsername);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Display user data inside the panel
                    username.Text = "Username: " + reader["Username"].ToString();
                    email.Text = "Email: " + reader["Email"].ToString();
                    phone.Text = "Phone: " + reader["Phone"].ToString();
                    changepass.Text = "Change Password";
                    report.Text = "Report a Problem";
                   // lblAddress.Text = "Address: " + reader["Address"].ToString();
                }
                else
                {
                    MessageBox.Show("Error: User details not found.");
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changepass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new resetPassword().Show();
            this.Hide();
        }

        private void report_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new report().Show();
          
        }
    }
}
