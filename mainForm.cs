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
    public partial class mainform : Form
    {
        private string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                           "Initial Catalog=MyDatabase;" +
                                           "Integrated Security=True;Encrypt=False";

        public mainform()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(mainform_FormClosing);
            
        }

        // Handle the form closing event (optional confirmation)
        private void mainform_FormClosing(object sender, FormClosingEventArgs e)
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
       
        private void mainform_Load(object sender, EventArgs e)
        {
          
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInForm frm = new LogInForm();
            frm.Show();
            this.Hide();

            
        }

        private void signuplabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm rgfrm = new RegisterForm();
            rgfrm.Show();
            this.Hide();

            
        }

        


        

        private void sellerlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SellerRegi sellerRegi = new SellerRegi();
            sellerRegi.Show();
            this.Hide();
        }

        private bool IsUserRegistered(string username)
        {
            bool isRegistered = false;

            string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                     "Initial Catalog=MyDatabase;" +
                                     "Integrated Security=True;Encrypt=False"; // Replace with actual connection string
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM UserTable WHERE Username = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                int userCount = (int)cmd.ExecuteScalar();

                if (userCount > 0)
                {
                    isRegistered = true;
                }
            }

            return isRegistered;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void formlabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1Gent_s_Fashion2().Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ladies2().Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Books2().Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new accessories2().Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new beauty2().Show();
            this.Hide();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Electronics2().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}