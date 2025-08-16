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
    public partial class SellerRegi : Form
    {
        public SellerRegi()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(SellRegi_FormClosing);
            


            //For Gender ComboBox
            catagorybox.Items.Add("Men's Fashion");
            catagorybox.Items.Add("Ledie's Fashion");
            catagorybox.Items.Add("Books");
            catagorybox.Items.Add("Groceries");
            catagorybox.Items.Add("Beauty Products");
            catagorybox.Items.Add("Electronics");
        }
        private void SellRegi_FormClosing(object sender, FormClosingEventArgs e)
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
        private void SellerRegi_Load(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(namebox.Text) ||
                 string.IsNullOrWhiteSpace(mobilebox.Text) ||
                 string.IsNullOrWhiteSpace(usernamebox.Text) ||
                 string.IsNullOrWhiteSpace(emailbox.Text) ||   // Email field
                 string.IsNullOrWhiteSpace(passbox.Text) ||
                 string.IsNullOrWhiteSpace(confirmpassbox.Text) ||
                 string.IsNullOrWhiteSpace(shopname.Text) ||
                 string.IsNullOrWhiteSpace(shopnumber.Text) ||
                 string.IsNullOrWhiteSpace(catagorybox.Text) ||
                 string.IsNullOrWhiteSpace(quantitybox.Text) ||
                 string.IsNullOrWhiteSpace(pricebox.Text) ||
                 string.IsNullOrWhiteSpace(codebox.Text))
            {
                MessageBox.Show("Please enter all the required information", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate the email format
            if (!IsValidEmail(emailbox.Text))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate the phone number format (example for 10-digit numbers)
            if (!IsValidPhoneNumber(mobilebox.Text))
            {
                MessageBox.Show("Invalid phone number format. Please enter a valid 10-digit phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the passwords match
            if (passbox.Text != confirmpassbox.Text)
            {
                MessageBox.Show("Passwords didn't match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if quantity is less than 10
            int quantity;
            bool isQuantityValid = int.TryParse(quantitybox.Text, out quantity);
            if (!isQuantityValid || quantity <= 50)
            {
                MessageBox.Show("Quantity must be 50 or above.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                       "Initial Catalog=MyDatabase;" +
                                       "Integrated Security=True;Encrypt=False";

            // Using the connection
            SqlConnection con = new SqlConnection(connectionString);

            string email = emailbox.Text;  // Assuming email textbox
            string username = usernamebox.Text;  // Assuming username textbox
            string phone = mobilebox.Text;  // Assuming phone textbox
            string shopName = shopname.Text;  // Assuming shop name textbox
            string shopNo = shopnumber.Text;  // Assuming shop number textbox
            string productCategory = catagorybox.Text;  // Assuming product category textbox
            string productCode = codebox.Text;  // Assuming product code textbox
            decimal basePrice;
            bool isPriceValid = decimal.TryParse(pricebox.Text, out basePrice);  // Assuming base price textbox

            // Validation for price and required fields
            if (!isPriceValid || string.IsNullOrEmpty(shopName) || string.IsNullOrEmpty(shopNo) ||
                string.IsNullOrEmpty(productCategory) || string.IsNullOrEmpty(productCode))
            {
                MessageBox.Show("Please fill all the required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if email or username already exists
            string queryCheck = "SELECT COUNT(*) FROM SellerInfo WHERE Email = @Email OR Username = @Username";
            SqlCommand cmdCheck = new SqlCommand(queryCheck, con);
            cmdCheck.Parameters.AddWithValue("@Email", email);
            cmdCheck.Parameters.AddWithValue("@Username", username);

            try
            {
                // Open connection
                con.Open();

                // Execute query and get the result
                int result = (int)cmdCheck.ExecuteScalar();

                if (result > 0)  // If result > 0, it means the email or username already exists
                {
                    MessageBox.Show("Email or Username already exists. Please choose another.");
                    return;
                }

                // Check if mobile number already exists
                string queryCheckMobile = "SELECT COUNT(*) FROM SellerInfo WHERE MobileNo = @MobileNo";
                SqlCommand cmdCheckMobile = new SqlCommand(queryCheckMobile, con);
                cmdCheckMobile.Parameters.AddWithValue("@MobileNo", phone);

                int resultMobile = (int)cmdCheckMobile.ExecuteScalar();
                if (resultMobile > 0) // If result > 0, it means the mobile number already exists
                {
                    MessageBox.Show("This mobile number is already registered. Please use a different mobile number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Stop further execution if the mobile number already exists
                }

                // Proceed with seller registration (inserting new seller)
                string queryInsert = "INSERT INTO SellerInfo (Name, Username, MobileNo, Email, Password, ShopName, ShopNo, ProductCategory, ProductCode, BasePrice, Quantity) " +
                                     "VALUES (@Name, @Username, @MobileNo, @Email, @Password, @ShopName, @ShopNo, @ProductCategory, @ProductCode, @BasePrice, @Quantity)";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, con);
                cmdInsert.Parameters.AddWithValue("@Name", namebox.Text);  // Assuming name textbox
                cmdInsert.Parameters.AddWithValue("@Username", username);
                cmdInsert.Parameters.AddWithValue("@MobileNo", phone);
                cmdInsert.Parameters.AddWithValue("@Email", email);
                cmdInsert.Parameters.AddWithValue("@Password", passbox.Text);  // Assuming password textbox
                cmdInsert.Parameters.AddWithValue("@ShopName", shopName);
                cmdInsert.Parameters.AddWithValue("@ShopNo", shopNo);
                cmdInsert.Parameters.AddWithValue("@ProductCategory", productCategory);
                cmdInsert.Parameters.AddWithValue("@ProductCode", productCode);
                cmdInsert.Parameters.AddWithValue("@BasePrice", basePrice);
                cmdInsert.Parameters.AddWithValue("@Quantity", quantity);  // Added the quantity parameter

                // Execute insert query
                int rowsAffected = cmdInsert.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Seller registration successful!");

                    // Optionally, navigate to a different form, such as a dashboard or login
                    LogInForm frm = new LogInForm();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.");
                }

            }
            catch (Exception ex)
            {
                // Handle error
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }


        }
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        // Phone number validation method (example for 10 digit numbers)
        private bool IsValidPhoneNumber(string phone)
        {
            string phonePattern = @"^\d{10}$";
            return Regex.IsMatch(phone, phonePattern);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clickhere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new mainform().Show();
            this.Hide();
        }
    }
}
