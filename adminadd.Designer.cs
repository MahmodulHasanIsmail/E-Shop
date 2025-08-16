namespace E_ShopManagementSystem
{
    partial class adminadd
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
            this.adminemail = new System.Windows.Forms.Label();
            this.adminid = new System.Windows.Forms.Label();
            this.adminemailbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminidbox = new System.Windows.Forms.TextBox();
            this.adminpassbox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // adminemail
            // 
            this.adminemail.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminemail.ForeColor = System.Drawing.Color.Black;
            this.adminemail.Location = new System.Drawing.Point(81, 54);
            this.adminemail.Name = "adminemail";
            this.adminemail.Size = new System.Drawing.Size(239, 23);
            this.adminemail.TabIndex = 0;
            this.adminemail.Text = "Enter Admin Email";
            // 
            // adminid
            // 
            this.adminid.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminid.Location = new System.Drawing.Point(82, 126);
            this.adminid.Name = "adminid";
            this.adminid.Size = new System.Drawing.Size(238, 23);
            this.adminid.TabIndex = 1;
            this.adminid.Text = "Enter Admin ID:";
            // 
            // adminemailbox
            // 
            this.adminemailbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminemailbox.Location = new System.Drawing.Point(85, 80);
            this.adminemailbox.Name = "adminemailbox";
            this.adminemailbox.Size = new System.Drawing.Size(316, 27);
            this.adminemailbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(171, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add-Admin";
            // 
            // adminidbox
            // 
            this.adminidbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminidbox.Location = new System.Drawing.Point(85, 152);
            this.adminidbox.Name = "adminidbox";
            this.adminidbox.Size = new System.Drawing.Size(316, 27);
            this.adminidbox.TabIndex = 7;
            // 
            // adminpassbox
            // 
            this.adminpassbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpassbox.Location = new System.Drawing.Point(85, 228);
            this.adminpassbox.Name = "adminpassbox";
            this.adminpassbox.Size = new System.Drawing.Size(316, 27);
            this.adminpassbox.TabIndex = 8;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.linkLabel1.Location = new System.Drawing.Point(342, 371);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 23);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GoBack";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // adminadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 414);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.adminpassbox);
            this.Controls.Add(this.adminidbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adminemailbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminid);
            this.Controls.Add(this.adminemail);
            this.Name = "adminadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminadd";
            this.Load += new System.EventHandler(this.adminadd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminemail;
        private System.Windows.Forms.Label adminid;
        private System.Windows.Forms.TextBox adminemailbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminidbox;
        private System.Windows.Forms.TextBox adminpassbox;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}