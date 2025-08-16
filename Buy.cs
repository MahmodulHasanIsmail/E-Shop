using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_ShopManagementSystem
{
    public partial class Buy : Form
    {

        string email;
        public Buy()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(AddProduct_FormClosing);
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(namebox.Text.Trim()) ||
       string.IsNullOrEmpty(mailbox.Text.Trim()) ||
       string.IsNullOrEmpty(addressbox.Text.Trim()) ||
       string.IsNullOrEmpty(mobileBox.Text.Trim()) ||
       string.IsNullOrEmpty(passwordBox.Text.Trim()) ||
       string.IsNullOrEmpty(ConfirmPasswordBox.Text.Trim()))
            {
                // If any of the fields are empty, show a message
                MessageBox.Show("Please fill in all the fields.");
            }
            else
            {
                // If all fields are filled, show a success message
                MessageBox.Show("Your Order Is Confirmed.You Will Get Your Product Within 3-5 Days.Thank You");
                new mainform2(email).Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new mainform2(email).Show();
            this.Hide();
        }
    }
}
