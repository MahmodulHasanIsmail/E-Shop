namespace E_ShopManagementSystem
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.namebox = new System.Windows.Forms.TextBox();
            this.mailbox = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.mobileBox = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.ConfirmPasswordBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl9 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.namebox.Location = new System.Drawing.Point(45, 71);
            this.namebox.Multiline = true;
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(301, 27);
            this.namebox.TabIndex = 0;
            this.namebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mailbox
            // 
            this.mailbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.mailbox.Location = new System.Drawing.Point(48, 121);
            this.mailbox.Multiline = true;
            this.mailbox.Name = "mailbox";
            this.mailbox.Size = new System.Drawing.Size(301, 27);
            this.mailbox.TabIndex = 2;
            this.mailbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(13, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(130, 55);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Register";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(42, 50);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(215, 18);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Enter Your Full Name";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(42, 100);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(183, 18);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Enter Your Email ";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(42, 149);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(212, 23);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "Enter your Username\r\n";
            // 
            // usernamebox
            // 
            this.usernamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamebox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.usernamebox.Location = new System.Drawing.Point(45, 175);
            this.usernamebox.Multiline = true;
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(301, 27);
            this.usernamebox.TabIndex = 1;
            this.usernamebox.TextChanged += new System.EventHandler(this.usernamebox_TextChanged);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(48, 331);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(301, 26);
            this.comboBoxGender.TabIndex = 9;
            this.comboBoxGender.Text = "Select Your Gender ";
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl5
            // 
            this.lbl5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(45, 261);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(298, 23);
            this.lbl5.TabIndex = 10;
            this.lbl5.Text = "Date Of Birth ";
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click);
            // 
            // lbl6
            // 
            this.lbl6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(45, 205);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(295, 23);
            this.lbl6.TabIndex = 11;
            this.lbl6.Text = "Enter Your Mobile no.";
            // 
            // mobileBox
            // 
            this.mobileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.mobileBox.Location = new System.Drawing.Point(45, 231);
            this.mobileBox.Multiline = true;
            this.mobileBox.Name = "mobileBox";
            this.mobileBox.Size = new System.Drawing.Size(301, 27);
            this.mobileBox.TabIndex = 12;
            // 
            // lbl7
            // 
            this.lbl7.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(42, 360);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(301, 23);
            this.lbl7.TabIndex = 15;
            this.lbl7.Text = "Enter a Password";
            // 
            // lbl8
            // 
            this.lbl8.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.Location = new System.Drawing.Point(45, 416);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(304, 23);
            this.lbl8.TabIndex = 16;
            this.lbl8.Text = "Confirm Password";
            // 
            // ConfirmPasswordBox
            // 
            this.ConfirmPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ConfirmPasswordBox.Location = new System.Drawing.Point(48, 442);
            this.ConfirmPasswordBox.Multiline = true;
            this.ConfirmPasswordBox.Name = "ConfirmPasswordBox";
            this.ConfirmPasswordBox.Size = new System.Drawing.Size(301, 27);
            this.ConfirmPasswordBox.TabIndex = 17;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.passwordBox.Location = new System.Drawing.Point(45, 386);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(301, 27);
            this.passwordBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(158, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl9
            // 
            this.lbl9.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.ForeColor = System.Drawing.Color.Black;
            this.lbl9.Location = new System.Drawing.Point(158, 13);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(210, 23);
            this.lbl9.TabIndex = 20;
            this.lbl9.Text = "Already Have an Account ?";
            this.lbl9.Click += new System.EventHandler(this.lbl9_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.linkLabel1.Location = new System.Drawing.Point(365, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 16);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log in here.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dayBox
            // 
            this.dayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Location = new System.Drawing.Point(48, 287);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(61, 26);
            this.dayBox.TabIndex = 22;
            this.dayBox.Text = "Day";
            this.dayBox.SelectedIndexChanged += new System.EventHandler(this.dayBox_SelectedIndexChanged);
            // 
            // monthBox
            // 
            this.monthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Location = new System.Drawing.Point(115, 287);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(126, 26);
            this.monthBox.TabIndex = 23;
            this.monthBox.Text = "Month";
            this.monthBox.SelectedIndexChanged += new System.EventHandler(this.monthBox_SelectedIndexChanged);
            // 
            // yearBox
            // 
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(247, 287);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(99, 26);
            this.yearBox.TabIndex = 24;
            this.yearBox.Text = "Year";
            this.yearBox.SelectedIndexChanged += new System.EventHandler(this.yearBox_SelectedIndexChanged);
            // 
            // lbl10
            // 
            this.lbl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl10.Location = new System.Drawing.Point(283, 509);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(187, 23);
            this.lbl10.TabIndex = 25;
            this.lbl10.Text = "*all fields are required ";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 541);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.ConfirmPasswordBox);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.mobileBox);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.mailbox);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.namebox);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox mailbox;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox mobileBox;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.TextBox ConfirmPasswordBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox dayBox;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.Label lbl10;
    }
}