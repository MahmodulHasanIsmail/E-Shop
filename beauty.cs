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
    public partial class beauty : Form
    {

        string email;
        public beauty()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(AddProduct_FormClosing);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
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

        private void beauty_Load(object sender, EventArgs e)
        {

        }
        
        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;

            }
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (panel2.Visible)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;

            }
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (panel3.Visible)
            {
                panel3.Visible = false;
            }
            else
            {
                panel3.Visible = true;

            }
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (panel4.Visible)
            {
                panel4.Visible = false;
            }
            else
            {
                panel4.Visible = true;

            }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (panel5.Visible)
            {
                panel5.Visible = false;
            }
            else
            {
                panel5.Visible = true;

            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (panel6.Visible)
            {
                panel6.Visible = false;
            }
            else
            {
                panel6.Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Buy().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Buy().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Buy().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Buy().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new Buy().Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new Buy().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cart added successfully ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cart added successfully ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cart added successfully ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cart added successfully ");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cart added successfully ");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cart added successfully ");
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new mainform2(email).Show();
            this.Hide();
        }
    }
}
