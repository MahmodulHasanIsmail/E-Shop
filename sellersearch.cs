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
    public partial class sellersearch : Form
    {
        private string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                         "Initial Catalog=MyDatabase;" +
                                         "Integrated Security=True;Encrypt=False";

        int adminID;
        public sellersearch()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(sellersearch_FormClosing);
        }

        private void sellersearch_FormClosing(object sender, FormClosingEventArgs e)
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

        private void sellersearch_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string mobile = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(mobile))
            {
                MessageBox.Show("Enter all the required information.");
                return;
            }

            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                // Query to check if the user exists
                string query = "SELECT COUNT(*) FROM SellerInfo WHERE username = @username AND mobileNo = @mobileNo";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@mobileNo", mobile);

                con.Open();

                int sellerCount = (int)cmd.ExecuteScalar();

                if (sellerCount > 0) // User found
                {
                    DialogResult result = MessageBox.Show("Seller found!Click yes to delete Seller.Click No to Modify Seller Details.Click cancel to go back", "User Found", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes) // Delete user
                    {
                        // Delete query
                        string deleteQuery = "DELETE FROM SellerInfo WHERE username = @username AND mobileNo = @mobileNo";
                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                        deleteCmd.Parameters.AddWithValue("@Username", username);
                        deleteCmd.Parameters.AddWithValue("@mobileNo", mobile);
                        deleteCmd.ExecuteNonQuery();

                        MessageBox.Show("Seller deleted successfully.");
                    }
                    else if (result == DialogResult.No) // Modify user
                    {
                        // Redirect to modify user form
                        ModifySellerForm modifyForm = new ModifySellerForm(username, mobile); // Pass email and phone
                        modifyForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Seller not found in the system.");
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
            new AdminPage(adminID).Show();
            this.Hide();
        }
    }
}
