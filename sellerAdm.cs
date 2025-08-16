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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace E_ShopManagementSystem
{
    public partial class sellerAdm : Form
    {
        
        private string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                         "Initial Catalog=MyDatabase;" +
                                         "Integrated Security=True;Encrypt=False";
        string email;
        public sellerAdm()
        {
            InitializeComponent();
            
            this.FormClosing += new FormClosingEventHandler(sellerAdm_FormClosing);

            catagorybox.Items.Add("Men's Fashion");
            catagorybox.Items.Add("Ledie's Fashion");
            catagorybox.Items.Add("Books");
            catagorybox.Items.Add("Groceries");
            catagorybox.Items.Add("Beauty Products");
            catagorybox.Items.Add("Electronics");

        }
        private void sellerAdm_FormClosing(object sender, FormClosingEventArgs e)
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
        private void sellerAdm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productCategory = catagorybox.Text.Trim(); // Product Category TextBox
            string productCode = textBox2.Text.Trim();    // Product Code TextBox

            // Check if both productCategory and productCode are filled in
            if (string.IsNullOrEmpty(productCategory) || string.IsNullOrEmpty(productCode))
            {
                MessageBox.Show("Please enter both Product Category and Product Code.");
                return;
            }

            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                // Query to check if the productCategory and productCode exist in the ProductTable
                string query = "SELECT COUNT(*) FROM ProductTable WHERE ProductCategory = @productCategory AND ProductCode = @productCode";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@productCategory", productCategory);
                cmd.Parameters.AddWithValue("@productCode", productCode);

                con.Open();

                int productCount = (int)cmd.ExecuteScalar();

                if (productCount > 0) // Product found in ProductTable
                {
                    // Ask the admin if they want to delete the product
                    DialogResult result = MessageBox.Show("Product found! Do you want to delete it? Click Yes to delete, No to modify.",
                        "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes) // If Yes is clicked, delete the product
                    {
                        string deleteQuery = "DELETE FROM ProductTable WHERE ProductCategory = @productCategory AND ProductCode = @productCode";

                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                        deleteCmd.Parameters.AddWithValue("@productCategory", productCategory);
                        deleteCmd.Parameters.AddWithValue("@productCode", productCode);

                        int rowsDeleted = deleteCmd.ExecuteNonQuery();

                        if (rowsDeleted > 0)
                        {
                            MessageBox.Show("Product deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Error deleting product.");
                        }
                    }
                    else if (result == DialogResult.No) // If No is clicked, redirect to ModifyProductForm
                    {
                        ModifyProductForm modifyForm = new ModifyProductForm(productCategory, productCode);
                        modifyForm.Show();
                        this.Hide(); // Hide the current form
                    }
                }
                else
                {
                    MessageBox.Show("No matching product found in the system.");
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
            new AddProduct().Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new mainform2(email).Show();
            this.Hide();
        }
    }
}
