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

    public partial class report : Form
    {

        string email;
        public report()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(report_FormClosing);
        }

        private void report_FormClosing(object sender, FormClosingEventArgs e)
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
            MessageBox.Show("Thank you for submitting your report." +
                " We value your privacy," +
                " and your information will only be used to address the issue you reported.");
        }
    }
}
