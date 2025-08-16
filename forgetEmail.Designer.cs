namespace E_ShopManagementSystem
{
    partial class ForgetEmailForm
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
            this.frgtemail = new System.Windows.Forms.Label();
            this.mobilenolbl = new System.Windows.Forms.Label();
            this.mbltxtbox = new System.Windows.Forms.TextBox();
            this.passlbl = new System.Windows.Forms.Label();
            this.passtxtbox = new System.Windows.Forms.TextBox();
            this.DOBlbl = new System.Windows.Forms.Label();
            this.DOBday = new System.Windows.Forms.ComboBox();
            this.DOBmonth = new System.Windows.Forms.ComboBox();
            this.DOByear = new System.Windows.Forms.ComboBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.gobacklinklbl = new System.Windows.Forms.LinkLabel();
            this.gobacklbl = new System.Windows.Forms.Label();
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frgtemail
            // 
            this.frgtemail.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frgtemail.Location = new System.Drawing.Point(13, 13);
            this.frgtemail.Name = "frgtemail";
            this.frgtemail.Size = new System.Drawing.Size(160, 35);
            this.frgtemail.TabIndex = 0;
            this.frgtemail.Text = "Email Reset ";
            // 
            // mobilenolbl
            // 
            this.mobilenolbl.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilenolbl.Location = new System.Drawing.Point(43, 130);
            this.mobilenolbl.Name = "mobilenolbl";
            this.mobilenolbl.Size = new System.Drawing.Size(250, 23);
            this.mobilenolbl.TabIndex = 1;
            this.mobilenolbl.Text = "Enter Your Mobile No:";
            // 
            // mbltxtbox
            // 
            this.mbltxtbox.Location = new System.Drawing.Point(46, 156);
            this.mbltxtbox.Multiline = true;
            this.mbltxtbox.Name = "mbltxtbox";
            this.mbltxtbox.Size = new System.Drawing.Size(300, 28);
            this.mbltxtbox.TabIndex = 2;
            // 
            // passlbl
            // 
            this.passlbl.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(43, 187);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(247, 23);
            this.passlbl.TabIndex = 3;
            this.passlbl.Text = "Enter Your Pasword :";
            // 
            // passtxtbox
            // 
            this.passtxtbox.Location = new System.Drawing.Point(46, 213);
            this.passtxtbox.Multiline = true;
            this.passtxtbox.Name = "passtxtbox";
            this.passtxtbox.Size = new System.Drawing.Size(300, 28);
            this.passtxtbox.TabIndex = 4;
            // 
            // DOBlbl
            // 
            this.DOBlbl.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBlbl.Location = new System.Drawing.Point(43, 244);
            this.DOBlbl.Name = "DOBlbl";
            this.DOBlbl.Size = new System.Drawing.Size(244, 23);
            this.DOBlbl.TabIndex = 5;
            this.DOBlbl.Text = "Enter Date Of Birth ";
            // 
            // DOBday
            // 
            this.DOBday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBday.FormattingEnabled = true;
            this.DOBday.Location = new System.Drawing.Point(46, 270);
            this.DOBday.Name = "DOBday";
            this.DOBday.Size = new System.Drawing.Size(77, 26);
            this.DOBday.TabIndex = 6;
            this.DOBday.Text = "Day";
            // 
            // DOBmonth
            // 
            this.DOBmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBmonth.FormattingEnabled = true;
            this.DOBmonth.Location = new System.Drawing.Point(129, 270);
            this.DOBmonth.Name = "DOBmonth";
            this.DOBmonth.Size = new System.Drawing.Size(116, 26);
            this.DOBmonth.TabIndex = 7;
            this.DOBmonth.Text = "Month";
            this.DOBmonth.SelectedIndexChanged += new System.EventHandler(this.DOBmonth_SelectedIndexChanged);
            // 
            // DOByear
            // 
            this.DOByear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOByear.FormattingEnabled = true;
            this.DOByear.Location = new System.Drawing.Point(251, 270);
            this.DOByear.Name = "DOByear";
            this.DOByear.Size = new System.Drawing.Size(95, 26);
            this.DOByear.TabIndex = 8;
            this.DOByear.Text = "Year";
            this.DOByear.SelectedIndexChanged += new System.EventHandler(this.DOByear_SelectedIndexChanged);
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.submitbtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.Color.White;
            this.submitbtn.Location = new System.Drawing.Point(138, 325);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(119, 48);
            this.submitbtn.TabIndex = 9;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // gobacklinklbl
            // 
            this.gobacklinklbl.AutoSize = true;
            this.gobacklinklbl.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobacklinklbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.gobacklinklbl.Location = new System.Drawing.Point(295, 418);
            this.gobacklinklbl.Name = "gobacklinklbl";
            this.gobacklinklbl.Size = new System.Drawing.Size(70, 16);
            this.gobacklinklbl.TabIndex = 10;
            this.gobacklinklbl.TabStop = true;
            this.gobacklinklbl.Text = "Click Here";
            this.gobacklinklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gobacklinklbl_LinkClicked);
            // 
            // gobacklbl
            // 
            this.gobacklbl.AutoSize = true;
            this.gobacklbl.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobacklbl.Location = new System.Drawing.Point(145, 418);
            this.gobacklbl.Name = "gobacklbl";
            this.gobacklbl.Size = new System.Drawing.Size(112, 16);
            this.gobacklbl.TabIndex = 11;
            this.gobacklbl.Text = "want to go back ?";
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.Location = new System.Drawing.Point(46, 99);
            this.usernametxtbox.Multiline = true;
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(300, 28);
            this.usernametxtbox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter Username";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.linkLabel1.Location = new System.Drawing.Point(323, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 23);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "If You Are a Seller";
            // 
            // ForgetEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernametxtbox);
            this.Controls.Add(this.gobacklbl);
            this.Controls.Add(this.gobacklinklbl);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.DOByear);
            this.Controls.Add(this.DOBmonth);
            this.Controls.Add(this.DOBday);
            this.Controls.Add(this.DOBlbl);
            this.Controls.Add(this.passtxtbox);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.mbltxtbox);
            this.Controls.Add(this.mobilenolbl);
            this.Controls.Add(this.frgtemail);
            this.Name = "ForgetEmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frgtemail;
        private System.Windows.Forms.Label mobilenolbl;
        private System.Windows.Forms.TextBox mbltxtbox;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.TextBox passtxtbox;
        private System.Windows.Forms.Label DOBlbl;
        private System.Windows.Forms.ComboBox DOBday;
        private System.Windows.Forms.ComboBox DOBmonth;
        private System.Windows.Forms.ComboBox DOByear;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.LinkLabel gobacklinklbl;
        private System.Windows.Forms.Label gobacklbl;
        private System.Windows.Forms.TextBox usernametxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
    }
}