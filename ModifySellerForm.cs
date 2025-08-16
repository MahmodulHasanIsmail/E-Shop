using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_ShopManagementSystem
{
    public partial class ModifySellerForm : Form
    {

        private string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                        "Initial Catalog=MyDatabase;" +
                                        "Integrated Security=True;Encrypt=False";

        string Username;
        string Mobile;
        int adminID;
        public ModifySellerForm(string username,string mobile)
        {
            InitializeComponent();

            catagorybox.Items.Add("Men's Fashion");
            catagorybox.Items.Add("Ledie's Fashion");
            catagorybox.Items.Add("Books");
            catagorybox.Items.Add("Groceries");
            catagorybox.Items.Add("Beauty Products");
            catagorybox.Items.Add("Electronics");

            this.Username= username;
            this.Mobile= mobile;
            this.FormClosing += new FormClosingEventHandler(ModifySellerForm_FormClosing);
        }

        private void ModifySellerForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ModifySellerForm_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                string query = "SELECT Name, Email, Password, ShopNo, ProductCategory, ShopName FROM SellerInfo WHERE username = @username AND mobileNo = @mobileNo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", Username);
                cmd.Parameters.AddWithValue("@mobileNo", Mobile);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    namebox.Text = reader["Name"].ToString();
                    emailbox.Text = reader["Email"].ToString();
                    passbox.Text = reader["Password"].ToString();
                    shopnumber.Text = reader["ShopNo"].ToString();
                    catagorybox.Text = reader["ProductCategory"].ToString();
                    shopnamebox.Text = reader["ShopName"].ToString();
                }
                else
                {
                    MessageBox.Show("Seller not found.");
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

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string name = namebox.Text.Trim();
            string email = emailbox.Text.Trim();
            string password = passbox.Text.Trim();
            string shopNo = shopnumber.Text.Trim();
            string productCategory = catagorybox.Text.Trim();
            string shopName = shopnamebox.Text.Trim();

            // Validate email format
            if (!string.IsNullOrEmpty(email) && !IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;  // Exit the method to prevent further execution
            }

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                // Build the UPDATE query
                string query = "UPDATE SellerInfo SET ";

                bool isFirst = true;

                // Add the fields to update in the query
                if (!string.IsNullOrEmpty(name))
                {
                    query += "Name = @Name";
                    isFirst = false;
                }
                if (!string.IsNullOrEmpty(email))
                {
                    if (!isFirst) query += ", ";
                    query += "Email = @Email";
                    isFirst = false;
                }
                if (!string.IsNullOrEmpty(password))
                {
                    if (!isFirst) query += ", ";
                    query += "Password = @Password";
                    isFirst = false;
                }
                if (!string.IsNullOrEmpty(shopNo))
                {
                    if (!isFirst) query += ", ";
                    query += "ShopNo = @ShopNo";
                    isFirst = false;
                }
                if (!string.IsNullOrEmpty(productCategory))
                {
                    if (!isFirst) query += ", ";
                    query += "ProductCategory = @ProductCategory";
                    isFirst = false;
                }
                if (!string.IsNullOrEmpty(shopName))
                {
                    if (!isFirst) query += ", ";
                    query += "ShopName = @ShopName";
                }

                // Add the WHERE condition to specify which seller to update
                query += " WHERE username = @username AND mobileNo = @mobileNo";

                // Prepare the SQL command
                SqlCommand cmd = new SqlCommand(query, con);

                // Add parameters to the SQL command
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@ShopNo", shopNo);
                cmd.Parameters.AddWithValue("@ProductCategory", productCategory);
                cmd.Parameters.AddWithValue("@ShopName", shopName);
                cmd.Parameters.AddWithValue("@username", Username);  // Ensure to pass the current username
                cmd.Parameters.AddWithValue("@mobileNo", Mobile);   // Ensure to pass the current mobile number

                // Open connection and execute the query
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if the update was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Seller details updated successfully.");
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
            // Regex pattern for validating email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void clickhere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            new AdminPage(adminID).Show();
            this.Hide();
        }
    }
}
