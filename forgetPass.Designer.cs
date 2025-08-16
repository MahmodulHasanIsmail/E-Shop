namespace E_ShopManagementSystem
{
    partial class resetPassword
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
            this.resetpasslbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.mobilelbl = new System.Windows.Forms.Label();
            this.DOBlbl = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.noBox = new System.Windows.Forms.TextBox();
            this.DOBday = new System.Windows.Forms.ComboBox();
            this.DOBmonth = new System.Windows.Forms.ComboBox();
            this.DOByear = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // resetpasslbl
            // 
            this.resetpasslbl.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetpasslbl.Location = new System.Drawing.Point(13, 13);
            this.resetpasslbl.Name = "resetpasslbl";
            this.resetpasslbl.Size = new System.Drawing.Size(230, 23);
            this.resetpasslbl.TabIndex = 0;
            this.resetpasslbl.Text = "Password Reset";
            // 
            // emaillbl
            // 
            this.emaillbl.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(15, 50);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(260, 23);
            this.emaillbl.TabIndex = 1;
            this.emaillbl.Text = "Enter Your Email/Username";
            // 
            // mobilelbl
            // 
            this.mobilelbl.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilelbl.Location = new System.Drawing.Point(18, 114);
            this.mobilelbl.Name = "mobilelbl";
            this.mobilelbl.Size = new System.Drawing.Size(225, 23);
            this.mobilelbl.TabIndex = 2;
            this.mobilelbl.Text = "Enter Your Mobile Number:";
            // 
            // DOBlbl
            // 
            this.DOBlbl.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBlbl.Location = new System.Drawing.Point(18, 185);
            this.DOBlbl.Name = "DOBlbl";
            this.DOBlbl.Size = new System.Drawing.Size(225, 23);
            this.DOBlbl.TabIndex = 3;
            this.DOBlbl.Text = "Enter Date Of Birth";
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(21, 77);
            this.usernamebox.Multiline = true;
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(318, 27);
            this.usernamebox.TabIndex = 4;
            this.usernamebox.TextChanged += new System.EventHandler(this.usernamebox_TextChanged);
            // 
            // noBox
            // 
            this.noBox.Location = new System.Drawing.Point(18, 141);
            this.noBox.Multiline = true;
            this.noBox.Name = "noBox";
            this.noBox.Size = new System.Drawing.Size(318, 27);
            this.noBox.TabIndex = 5;
            this.noBox.TextChanged += new System.EventHandler(this.noBox_TextChanged);
            // 
            // DOBday
            // 
            this.DOBday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBday.FormattingEnabled = true;
            this.DOBday.Location = new System.Drawing.Point(21, 212);
            this.DOBday.Name = "DOBday";
            this.DOBday.Size = new System.Drawing.Size(78, 24);
            this.DOBday.TabIndex = 6;
            this.DOBday.Text = "Day";
            this.DOBday.SelectedIndexChanged += new System.EventHandler(this.DOBday_SelectedIndexChanged);
            // 
            // DOBmonth
            // 
            this.DOBmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBmonth.FormattingEnabled = true;
            this.DOBmonth.Location = new System.Drawing.Point(105, 211);
            this.DOBmonth.Name = "DOBmonth";
            this.DOBmonth.Size = new System.Drawing.Size(103, 24);
            this.DOBmonth.TabIndex = 7;
            this.DOBmonth.Text = "Month";
            this.DOBmonth.SelectedIndexChanged += new System.EventHandler(this.DOBmonth_SelectedIndexChanged);
            // 
            // DOByear
            // 
            this.DOByear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOByear.FormattingEnabled = true;
            this.DOByear.Location = new System.Drawing.Point(214, 211);
            this.DOByear.Name = "DOByear";
            this.DOByear.Size = new System.Drawing.Size(94, 24);
            this.DOByear.TabIndex = 8;
            this.DOByear.Text = "Year";
            this.DOByear.SelectedIndexChanged += new System.EventHandler(this.DOByear_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(120, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "To Go Back";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.linkLabel1.Location = new System.Drawing.Point(196, 413);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 16);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click Here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "if you are a seller ";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.linkLabel2.Location = new System.Drawing.Point(270, 356);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(69, 16);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Click Here";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // resetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 438);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DOByear);
            this.Controls.Add(this.DOBmonth);
            this.Controls.Add(this.DOBday);
            this.Controls.Add(this.noBox);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.DOBlbl);
            this.Controls.Add(this.mobilelbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.resetpasslbl);
            this.Location = new System.Drawing.Point(13, 13);
            this.Name = "resetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resetpasslbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label mobilelbl;
        private System.Windows.Forms.Label DOBlbl;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.TextBox noBox;
        private System.Windows.Forms.ComboBox DOBday;
        private System.Windows.Forms.ComboBox DOBmonth;
        private System.Windows.Forms.ComboBox DOByear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}