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
    public partial class AddProduct : Form
    {
        private string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                      "Initial Catalog=MyDatabase;" +
                                      "Integrated Security=True;Encrypt=False";
        public AddProduct()
        {
            
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(AddProduct_FormClosing);
            catagorybox.Items.Add("Men's Fashion");
            catagorybox.Items.Add("Ledie's Fashion");
            catagorybox.Items.Add("Books");
            catagorybox.Items.Add("Groceries");
            catagorybox.Items.Add("Beauty Products");
            catagorybox.Items.Add("Electronics");

        }

        private void AddProduct_FormClosing(object sender, FormClosingEventArgs e)
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

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string email = emailbox.Text.Trim();
            string productID = productid.Text.Trim();
            string productCategory = catagorybox.Text.Trim();
            string productCode = codebox.Text.Trim();
            int productQuantity = 0;
            decimal basePrice = 0;

            // Validate product quantity and base price inputs
            if (!int.TryParse(quantitybox.Text.Trim(), out productQuantity) || productQuantity <= 50)
            {
                MessageBox.Show("Please enter a valid product quantity (greater than 50).");
                return;
            }

            if (!decimal.TryParse(pricebox.Text.Trim(), out basePrice) || basePrice <= 50)
            {
                MessageBox.Show("Please enter a valid base price.");
                return;
            }

            // Ensure all fields are filled
            if (string.IsNullOrEmpty(productCategory) || string.IsNullOrEmpty(productCode) || string.IsNullOrEmpty(productID) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields with valid information.");
                return;
            }

            // Check if the user exists in the SellerInfo table
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                // Query to check if the email exists in the SellerInfo table
                string checkUserQuery = "SELECT COUNT(*) FROM SellerInfo WHERE email = @Email";
                SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, con);
                checkUserCmd.Parameters.AddWithValue("@Email", email);

                con.Open();
                int userExists = (int)checkUserCmd.ExecuteScalar();

                if (userExists > 0)
                {
                    // User exists, check if product category already exists for the seller
                    string checkCategoryQuery = "SELECT COUNT(*) FROM ProductTable WHERE Selleremail = @Selleremail AND ProductCategory = @ProductCategory";
                    SqlCommand checkCategoryCmd = new SqlCommand(checkCategoryQuery, con);
                    checkCategoryCmd.Parameters.AddWithValue("@Selleremail", email);
                    checkCategoryCmd.Parameters.AddWithValue("@ProductCategory", productCategory);

                    int categoryExists = (int)checkCategoryCmd.ExecuteScalar();

                    if (categoryExists > 0)
                    {
                        // If the category exists, update the product base price and quantity
                        string updateProductQuery = @"
                    UPDATE ProductTable
                    SET ProductQuantity = ProductQuantity + @ProductQuantity,
                        BasePrice = @BasePrice
                    WHERE Selleremail = @Selleremail AND ProductCategory = @ProductCategory";

                        SqlCommand updateCmd = new SqlCommand(updateProductQuery, con);
                        updateCmd.Parameters.AddWithValue("@ProductQuantity", productQuantity);  // Add the new product quantity
                        updateCmd.Parameters.AddWithValue("@BasePrice", basePrice);  // Update the base price
                        updateCmd.Parameters.AddWithValue("@Selleremail", email);  // Seller Email
                        updateCmd.Parameters.AddWithValue("@ProductCategory", productCategory);  // Product Category

                        int rowsUpdated = updateCmd.ExecuteNonQuery();

                        if (rowsUpdated > 0)
                        {
                            MessageBox.Show("Product quantity and base price updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Error updating product.");
                        }
                    }
                    else
                    {
                        // If category does not exist, insert a new product into ProductTable
                        string insertQuery = @"
                    INSERT INTO ProductTable (ProductID, ProductCategory, ProductCode, ProductQuantity, BasePrice, Selleremail)
                    VALUES (@ProductID, @ProductCategory, @ProductCode, @ProductQuantity, @BasePrice, @Selleremail)";

                        SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                        insertCmd.Parameters.AddWithValue("@ProductID", productID);  // Product ID
                        insertCmd.Parameters.AddWithValue("@ProductCategory", productCategory);  // Product Category
                        insertCmd.Parameters.AddWithValue("@ProductCode", productCode);  // Product Code
                        insertCmd.Parameters.AddWithValue("@ProductQuantity", productQuantity);  // Product Quantity
                        insertCmd.Parameters.AddWithValue("@BasePrice", basePrice);  // Base Price
                        insertCmd.Parameters.AddWithValue("@Selleremail", email);  // Seller Email

                        int rowsInserted = insertCmd.ExecuteNonQuery();

                        if (rowsInserted > 0)
                        {
                            MessageBox.Show("Product added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Error adding product.");
                        }
                    }
                }
                else
                {
                    // User does not exist, inform the user to become a seller
                    MessageBox.Show("Username did not match.");
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
    }
}
