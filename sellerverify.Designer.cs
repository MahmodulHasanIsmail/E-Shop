namespace E_ShopManagementSystem
{
    partial class sellerverify
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.noBox = new System.Windows.Forms.TextBox();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.mobilelbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.resetpasslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.linkLabel1.Location = new System.Drawing.Point(181, 358);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 16);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click Here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "To Go Back";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(123, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // noBox
            // 
            this.noBox.Location = new System.Drawing.Point(26, 147);
            this.noBox.Multiline = true;
            this.noBox.Name = "noBox";
            this.noBox.Size = new System.Drawing.Size(318, 27);
            this.noBox.TabIndex = 17;
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(29, 83);
            this.usernamebox.Multiline = true;
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(318, 27);
            this.usernamebox.TabIndex = 16;
            // 
            // mobilelbl
            // 
            this.mobilelbl.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilelbl.Location = new System.Drawing.Point(26, 120);
            this.mobilelbl.Name = "mobilelbl";
            this.mobilelbl.Size = new System.Drawing.Size(225, 23);
            this.mobilelbl.TabIndex = 14;
            this.mobilelbl.Text = "Enter Your Mobile Number:";
            // 
            // emaillbl
            // 
            this.emaillbl.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(23, 56);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(260, 23);
            this.emaillbl.TabIndex = 13;
            this.emaillbl.Text = "Enter Your Email/Username";
            // 
            // resetpasslbl
            // 
            this.resetpasslbl.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetpasslbl.Location = new System.Drawing.Point(21, 19);
            this.resetpasslbl.Name = "resetpasslbl";
            this.resetpasslbl.Size = new System.Drawing.Size(230, 23);
            this.resetpasslbl.TabIndex = 12;
            this.resetpasslbl.Text = "Password Reset";
            // 
            // sellerverify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 438);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.noBox);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.mobilelbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.resetpasslbl);
            this.Name = "sellerverify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sellerverify";
            this.Load += new System.EventHandler(this.sellerverify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox noBox;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.Label mobilelbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label resetpasslbl;
    }
}