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
    public partial class ModifyProductForm : Form
    {

        private string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                        "Initial Catalog=MyDatabase;" +
                                        "Integrated Security=True;Encrypt=False";

        private string productCategory;
        private string productCode;
       

        
        public ModifyProductForm(string productCategory,string productCode)
        {
            InitializeComponent();
            this.productCategory = productCategory;
            this.productCode = productCode;

            catagorybox.Items.Add("Men's Fashion");
            catagorybox.Items.Add("Ledie's Fashion");
            catagorybox.Items.Add("Books");
            catagorybox.Items.Add("Groceries");
            catagorybox.Items.Add("Beauty Products");
            catagorybox.Items.Add("Electronics");

            this.FormClosing += new FormClosingEventHandler(ModifyProductForm_FormClosing);
        }
        private void ModifyProductForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ModifyProductForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                // Query to load product details from ProductTable based on category and code
                string query = "SELECT ProductCategory, ProductCode, BasePrice, ProductQuantity FROM ProductTable WHERE ProductCategory = @productCategory AND ProductCode = @productCode";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@productCategory", productCategory);  // Ensure parameters are added here
                cmd.Parameters.AddWithValue("@productCode", productCode);          // Ensure parameters are added here

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Load data from the database into form controls
                    catagorybox.Text = reader["ProductCategory"].ToString();
                    codebox.Text = reader["ProductCode"].ToString();
                    pricebox.Text = reader["BasePrice"].ToString();
                    quantitybox.Text = reader["ProductQuantity"].ToString();
                }
                else
                {
                    MessageBox.Show("Product not found in the ProductTable.");
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

        private void productid_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string updatedCategory = catagorybox.Text.Trim();
            string updatedCode = codebox.Text.Trim();
            decimal updatedPrice = 0;
            int updatedQuantity = 0;

            // Validate the inputs for price and quantity
            if (!decimal.TryParse(pricebox.Text.Trim(), out updatedPrice) || updatedPrice <= 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            if (!int.TryParse(quantitybox.Text.Trim(), out updatedQuantity) || updatedQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                // Update the ProductTable
                string updateQuery = "UPDATE ProductTable SET ProductCategory = @updatedCategory, ProductCode = @updatedCode, BasePrice = @updatedPrice, ProductQuantity = @updatedQuantity WHERE ProductCategory = @productCategory AND ProductCode = @productCode";

                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@updatedCategory", updatedCategory);
                cmd.Parameters.AddWithValue("@updatedCode", updatedCode);
                cmd.Parameters.AddWithValue("@updatedPrice", updatedPrice);
                cmd.Parameters.AddWithValue("@updatedQuantity", updatedQuantity);
                cmd.Parameters.AddWithValue("@productCategory", productCategory);
                cmd.Parameters.AddWithValue("@productCode", productCode);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product details updated successfully.");
                     // Close the form after successful update
                }
                else
                {
                    MessageBox.Show("Error updating product details.");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form without making changes
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
  
