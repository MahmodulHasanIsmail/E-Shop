namespace E_ShopManagementSystem
{
    partial class LogInForm
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.MaskedTextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.forgetemail = new System.Windows.Forms.LinkLabel();
            this.forgetpassword = new System.Windows.Forms.LinkLabel();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lginbtn = new System.Windows.Forms.Button();
            this.createaccount = new System.Windows.Forms.LinkLabel();
            this.showbtn = new System.Windows.Forms.Button();
            this.guestuserlabel = new System.Windows.Forms.LinkLabel();
            this.guestuser2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl1.Location = new System.Drawing.Point(13, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(130, 55);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Log in";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(45, 86);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(147, 18);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Enter Your Email ";
            this.lbl2.Click += new System.EventHandler(this.label1_Click);
            // 
            // usernamebox
            // 
            this.usernamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamebox.Location = new System.Drawing.Point(47, 107);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(302, 27);
            this.usernamebox.TabIndex = 2;
            // 
            // passwordbox
            // 
            this.passwordbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordbox.Location = new System.Drawing.Point(48, 190);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PasswordChar = '*';
            this.passwordbox.Size = new System.Drawing.Size(302, 27);
            this.passwordbox.TabIndex = 3;
            this.passwordbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(45, 169);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(133, 18);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Enter Password ";
            this.lbl3.Click += new System.EventHandler(this.label2_Click);
            // 
            // forgetemail
            // 
            this.forgetemail.AutoSize = true;
            this.forgetemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetemail.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.forgetemail.Location = new System.Drawing.Point(44, 291);
            this.forgetemail.Name = "forgetemail";
            this.forgetemail.Size = new System.Drawing.Size(87, 16);
            this.forgetemail.TabIndex = 5;
            this.forgetemail.TabStop = true;
            this.forgetemail.Text = "forget email ?";
            this.forgetemail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl1_LinkClicked);
            // 
            // forgetpassword
            // 
            this.forgetpassword.AutoSize = true;
            this.forgetpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetpassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.forgetpassword.Location = new System.Drawing.Point(121, 291);
            this.forgetpassword.Name = "forgetpassword";
            this.forgetpassword.Size = new System.Drawing.Size(118, 16);
            this.forgetpassword.TabIndex = 6;
            this.forgetpassword.TabStop = true;
            this.forgetpassword.Text = "Forget password ?";
            this.forgetpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl2_LinkClicked);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(42, 333);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(119, 16);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Need an account ?";
            this.lbl4.Click += new System.EventHandler(this.label3_Click);
            // 
            // lginbtn
            // 
            this.lginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.lginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lginbtn.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lginbtn.ForeColor = System.Drawing.Color.White;
            this.lginbtn.Location = new System.Drawing.Point(48, 235);
            this.lginbtn.Name = "lginbtn";
            this.lginbtn.Size = new System.Drawing.Size(83, 33);
            this.lginbtn.TabIndex = 8;
            this.lginbtn.Text = "Log in";
            this.lginbtn.UseVisualStyleBackColor = false;
            this.lginbtn.Click += new System.EventHandler(this.btn1_Click);
            // 
            // createaccount
            // 
            this.createaccount.AutoSize = true;
            this.createaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createaccount.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.createaccount.Location = new System.Drawing.Point(167, 333);
            this.createaccount.Name = "createaccount";
            this.createaccount.Size = new System.Drawing.Size(118, 16);
            this.createaccount.TabIndex = 9;
            this.createaccount.TabStop = true;
            this.createaccount.Text = "Create an account ";
            this.createaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl3_LinkClicked);
            // 
            // showbtn
            // 
            this.showbtn.BackColor = System.Drawing.Color.White;
            this.showbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.showbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.showbtn.Location = new System.Drawing.Point(275, 169);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(75, 23);
            this.showbtn.TabIndex = 10;
            this.showbtn.Text = "show ";
            this.showbtn.UseVisualStyleBackColor = false;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // guestuserlabel
            // 
            this.guestuserlabel.BackColor = System.Drawing.Color.White;
            this.guestuserlabel.Font = new System.Drawing.Font("Georgia", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestuserlabel.ForeColor = System.Drawing.Color.Black;
            this.guestuserlabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.guestuserlabel.Location = new System.Drawing.Point(231, 361);
            this.guestuserlabel.Name = "guestuserlabel";
            this.guestuserlabel.Size = new System.Drawing.Size(78, 16);
            this.guestuserlabel.TabIndex = 12;
            this.guestuserlabel.TabStop = true;
            this.guestuserlabel.Text = "Click Here";
            this.guestuserlabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // guestuser2
            // 
            this.guestuser2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestuser2.Location = new System.Drawing.Point(42, 360);
            this.guestuser2.Name = "guestuser2";
            this.guestuser2.Size = new System.Drawing.Size(183, 16);
            this.guestuser2.TabIndex = 13;
            this.guestuser2.Text = "You can continue as a guest.";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 403);
            this.Controls.Add(this.guestuser2);
            this.Controls.Add(this.guestuserlabel);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.createaccount);
            this.Controls.Add(this.lginbtn);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.forgetpassword);
            this.Controls.Add(this.forgetemail);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.MaskedTextBox usernamebox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.LinkLabel forgetemail;
        private System.Windows.Forms.LinkLabel forgetpassword;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button lginbtn;
        private System.Windows.Forms.LinkLabel createaccount;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.LinkLabel guestuserlabel;
        private System.Windows.Forms.Label guestuser2;
    }
}

