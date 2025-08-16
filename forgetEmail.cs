using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace E_ShopManagementSystem
{
    public partial class ForgetEmailForm : Form
    {
        private readonly string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                                  "Initial Catalog=MyDatabase;" +
                                                  "Integrated Security=True;Encrypt=False"; // Update with your actual connection string

        public ForgetEmailForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(ForgetEmailForm_FormClosing);
            // For DOB Day Combo Box
            for (int i = 1; i <= 31; i++)  // Days start from 1
            {
                DOBday.Items.Add(i.ToString());
            }

            // For DOB Month Combo Box
            DOBmonth.Items.Add("January");
            DOBmonth.Items.Add("February");
            DOBmonth.Items.Add("March");
            DOBmonth.Items.Add("April");
            DOBmonth.Items.Add("May");
            DOBmonth.Items.Add("June");
            DOBmonth.Items.Add("July");
            DOBmonth.Items.Add("August");
            DOBmonth.Items.Add("September");
            DOBmonth.Items.Add("October");
            DOBmonth.Items.Add("November");
            DOBmonth.Items.Add("December");

            // For DOB Year Combo Box
            for (int i = 1990; i <= DateTime.Now.Year; i++)
            {
                DOByear.Items.Add(i.ToString());
            }

            // Call method to populate days based on selected month and year
            PopulateDays();

        }

        private void ForgetEmailForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void DOBmonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDays();

        }

        private void DOByear_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDays();
        }
        private void PopulateDays()
        {
            DOBday.Items.Clear();

            if (DOBmonth.SelectedIndex == -1 || DOByear.SelectedItem == null)
            {
                return;
            }

            int daysInMonth = 31;


            int month = DOBmonth.SelectedIndex + 1; // Months are 1-indexed
            int year = int.Parse(DOByear.SelectedItem.ToString());

            if (month == 2) // February
            {
                // Check if it's a leap year
                if (DateTime.IsLeapYear(year))
                {
                    daysInMonth = 29; // Leap year, February has 29 days
                }
                else
                {
                    daysInMonth = 28; // Regular year, February has 28 days
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11) // April, June, September, November
            {
                daysInMonth = 30; // These months have 30 days
            }

            // Add the days to the Day ComboBox
            for (int i = 1; i <= daysInMonth; i++)
            {
                DOBday.Items.Add(i.ToString()); // Add days 1 to the number of days in the selected month
            }
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mbltxtbox.Text) ||
       string.IsNullOrWhiteSpace(passtxtbox.Text) ||
       string.IsNullOrWhiteSpace(usernametxtbox.Text) ||// pass field field
       DOBday.SelectedIndex == -1 ||
       DOBmonth.SelectedIndex == -1 ||
       DOByear.SelectedIndex == -1)  // Date of birth not fully selected
            {
                MessageBox.Show("Please Enter all the required information", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phone = mbltxtbox.Text; // Get the mobile number input
            string password = passtxtbox.Text; // Get the password input
            string username = usernametxtbox.Text;

            int day, month, year;
            bool isDayValid = int.TryParse(DOBday.SelectedItem.ToString(), out day);
            string selectedMonth = DOBmonth.SelectedItem.ToString();
            month = GetMonthNumber(selectedMonth);
            bool isYearValid = int.TryParse(DOByear.SelectedItem.ToString(), out year);

            if (!isDayValid || !isYearValid || month == -1)
            {
                MessageBox.Show("Invalid date of birth selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Combine the values into a DateTime object
            DateTime dateOfBirth = new DateTime(year, month, day);

            string result = VerifyIdentity( phone,  password,  username,  day,  month,  year);

            // Show the result (either success or error)
            MessageBox.Show(result);

            // If identity is verified, open the email reset form (Form 2)
            if (result == "Identity verified successfully. Proceed with email reset.")
            {
                mailChangeForm resetForm = new mailChangeForm(phone,username); // Create instance of Form2
                resetForm.Show(); // Show Form2 (emailReset)
                this.Hide(); // Hide Form1 (forgetEmail)
            }
        }

        private int GetMonthNumber(string monthName)
        {
            switch (monthName)
            {
                case "January": return 1;
                case "February": return 2;
                case "March": return 3;
                case "April": return 4;
                case "May": return 5;
                case "June": return 6;
                case "July": return 7;
                case "August": return 8;
                case "September": return 9;
                case "October": return 10;
                case "November": return 11;
                case "December": return 12;
                default: return -1;  // Invalid month
            }
        }

        private string VerifyIdentity(string phone, string password, string username, int day, int month, int year)
        {
            DateTime userDob = new DateTime(year, month, day); // Create DateTime object from entered DOB

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to find the user by mobile number and username
                string query = "SELECT * FROM UserInfo WHERE Phone = @Phone AND Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Username", username);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) // User found
                {
                    string storedPassword = reader["Password"].ToString(); // Get the stored password
                    DateTime storedDob = Convert.ToDateTime(reader["DateOfBirth"]); // Get the stored DOB

                    // Compare the entered password with the stored password
                    if (password == storedPassword && storedDob == userDob)
                    {
                        return "Identity verified successfully. Proceed with email reset.";
                    }
                    else
                    {
                        return "Incorrect password or date of birth.";
                    }
                }
                else
                {
                    return "No user found with the provided mobile number and username.";
                }
            }
        }


        private void gobacklinklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           new selleremailupdate().Show();
            this.Hide();
        }
    }
}
