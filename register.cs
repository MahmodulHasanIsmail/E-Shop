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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace E_ShopManagementSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(RegisterForm_FormClosing);

            //For Gender ComboBox
            comboBoxGender.Items.Add("Male");
            comboBoxGender.Items.Add("Female");
            comboBoxGender.Items.Add("Others");

            /* //For day Combo Box
             for(int i = 0; i <31;i++)
             {
                dayBox.Items.Add(i.ToString());   
             }*/
            //For Month Combobox
            monthBox.Items.Add("January");
            monthBox.Items.Add("February");
            monthBox.Items.Add("March");
            monthBox.Items.Add("April");
            monthBox.Items.Add("May");
            monthBox.Items.Add("June");
            monthBox.Items.Add("July");
            monthBox.Items.Add("August");
            monthBox.Items.Add("September");
            monthBox.Items.Add("October");
            monthBox.Items.Add("November");
            monthBox.Items.Add("December");
            //For year box
            for (int i = 1990; i <= DateTime.Now.Year; i++)
            {
                yearBox.Items.Add(i.ToString());
            }
            PopulateDays();

        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lbl5_Click(object sender, EventArgs e)
        {

        }


        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dayBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDays();
        }

        private void yearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDays();
        }

        private void PopulateDays()
        {
           dayBox.Items.Clear();

            if (monthBox.SelectedIndex == -1 || yearBox.SelectedItem == null)
            {
                return; 
            }

            int daysInMonth = 31; 

           
            int month = monthBox.SelectedIndex + 1; 
            int year = int.Parse(yearBox.SelectedItem.ToString());

            if (month == 2) 
            {
                
                if (DateTime.IsLeapYear(year))
                {
                    daysInMonth = 29; 
                }
                else
                {
                    daysInMonth = 28;
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11) 
            {
                daysInMonth = 30; 
            }

            
            for (int i = 1; i <= daysInMonth; i++)
            {
                dayBox.Items.Add(i.ToString()); 
            }
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void lbl9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernamebox.Text) ||
                 string.IsNullOrWhiteSpace(mailbox.Text) ||   // Email field
                 string.IsNullOrWhiteSpace(passwordBox.Text) ||
                 string.IsNullOrWhiteSpace(ConfirmPasswordBox.Text) ||// Password field
                 comboBoxGender.SelectedIndex == -1 ||  // Gender not selected
                 dayBox.SelectedIndex == -1 ||
                 monthBox.SelectedIndex == -1 ||
                 yearBox.SelectedIndex == -1)  // Date of birth not fully selected
            {
                MessageBox.Show("Please Enter all the required information", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate the email format
            if (!IsValidEmail(mailbox.Text))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate the phone number format (example for 10 digit numbers)
            if (!IsValidPhoneNumber(mobileBox.Text))
            {
                MessageBox.Show("Invalid phone number format. Please enter a valid 10-digit phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (passwordBox.Text != ConfirmPasswordBox.Text)
            {
                MessageBox.Show("Passwords didn't match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }






            // Connection string
            string connectionString = "Data Source=MHISMAIL91\\SQLEXPRESS;" +
                                      "Initial Catalog=MyDatabase;" +
                                      "Integrated Security=True;Encrypt=False";

            // Using the connection
            SqlConnection con = new SqlConnection(connectionString);

            string email = mailbox.Text;  // Assuming email textbox
            string username = usernamebox.Text;  // Assuming username textbox
            string phone = mobileBox.Text;  // Assuming phone textbox

            int day, month, year;
            bool isDayValid = int.TryParse(dayBox.SelectedItem.ToString(), out day);
            string selectedMonth = monthBox.SelectedItem.ToString();
            month = GetMonthNumber(selectedMonth);
            bool isYearValid = int.TryParse(yearBox.SelectedItem.ToString(), out year);

            if (!isDayValid  || !isYearValid || month == -1)
            {
                MessageBox.Show("Invalid date of birth selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Combine the values into a DateTime object
            DateTime dateOfBirth = new DateTime(year,month,day);
            string gender = Convert.ToString(comboBoxGender.SelectedItem);
            string password = passwordBox.Text;  

            // Check if email or username already exists
            string queryCheck = "SELECT COUNT(*) FROM UserInfo WHERE Email = @Email OR Username = @Username";
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
                string queryCheckMobile = "SELECT COUNT(*) FROM UserInfo WHERE Phone = @Phone";
                SqlCommand cmdCheckMobile = new SqlCommand(queryCheckMobile, con);
                cmdCheckMobile.Parameters.AddWithValue("@Phone", phone);

                int resultMobile = (int)cmdCheckMobile.ExecuteScalar();
                if (resultMobile > 0) // If result > 0, it means the mobile number already exists
                {
                    MessageBox.Show("This mobile number is already registered. Please use a different mobile number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Stop further execution if the mobile number already exists
                }

                // Proceed with registration (inserting new user)
                string queryInsert = "INSERT INTO UserInfo (FullName, Email, Username, Phone, DateOfBirth, Gender, Password) " +
                                         "VALUES (@FullName, @Email, @Username, @Phone, @DateOfBirth, @Gender, @Password)";
                    SqlCommand cmdInsert = new SqlCommand(queryInsert, con);
                    cmdInsert.Parameters.AddWithValue("@FullName", namebox.Text);
                    cmdInsert.Parameters.AddWithValue("@Email", email);
                    cmdInsert.Parameters.AddWithValue("@Username", username);
                    cmdInsert.Parameters.AddWithValue("@Phone", phone);
                    cmdInsert.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    cmdInsert.Parameters.AddWithValue("@Gender", gender);
                    cmdInsert.Parameters.AddWithValue("@Password", password);

                    // Execute insert query
                    int rowsAffected = cmdInsert.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful!");

                        // Navigate to the login form
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
        // Email validation method
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
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LogInForm frm = new LogInForm();
            frm.Show();
            
        }
    }
}
