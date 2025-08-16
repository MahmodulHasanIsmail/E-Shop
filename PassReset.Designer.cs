namespace E_ShopManagementSystem
{
    partial class PassReset
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
            this.resetpass = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.ConfirmPasslbl = new System.Windows.Forms.Label();
            this.passtxtbox = new System.Windows.Forms.TextBox();
            this.confirmpassbox = new System.Windows.Forms.TextBox();
            this.confirmbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // resetpass
            // 
            this.resetpass.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetpass.Location = new System.Drawing.Point(13, 13);
            this.resetpass.Name = "resetpass";
            this.resetpass.Size = new System.Drawing.Size(219, 23);
            this.resetpass.TabIndex = 0;
            this.resetpass.Text = "Password Reset";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(35, 96);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(180, 18);
            this.passlbl.TabIndex = 2;
            this.passlbl.Text = "Enter a New Password";
            // 
            // ConfirmPasslbl
            // 
            this.ConfirmPasslbl.AutoSize = true;
            this.ConfirmPasslbl.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasslbl.Location = new System.Drawing.Point(35, 184);
            this.ConfirmPasslbl.Name = "ConfirmPasslbl";
            this.ConfirmPasslbl.Size = new System.Drawing.Size(180, 18);
            this.ConfirmPasslbl.TabIndex = 3;
            this.ConfirmPasslbl.Text = "Enter Password Again ";
            this.ConfirmPasslbl.Click += new System.EventHandler(this.ConfirmPasslbl_Click);
            // 
            // passtxtbox
            // 
            this.passtxtbox.Location = new System.Drawing.Point(38, 133);
            this.passtxtbox.Multiline = true;
            this.passtxtbox.Name = "passtxtbox";
            this.passtxtbox.Size = new System.Drawing.Size(300, 27);
            this.passtxtbox.TabIndex = 5;
            this.passtxtbox.TextChanged += new System.EventHandler(this.passtxtbox_TextChanged);
            // 
            // confirmpassbox
            // 
            this.confirmpassbox.Location = new System.Drawing.Point(38, 217);
            this.confirmpassbox.Multiline = true;
            this.confirmpassbox.Name = "confirmpassbox";
            this.confirmpassbox.Size = new System.Drawing.Size(300, 27);
            this.confirmpassbox.TabIndex = 6;
            // 
            // confirmbutton
            // 
            this.confirmbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.confirmbutton.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbutton.ForeColor = System.Drawing.Color.White;
            this.confirmbutton.Location = new System.Drawing.Point(110, 294);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(105, 51);
            this.confirmbutton.TabIndex = 7;
            this.confirmbutton.Text = "Confirm";
            this.confirmbutton.UseVisualStyleBackColor = false;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "want to go back ?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.linkLabel1.Location = new System.Drawing.Point(266, 381);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 16);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PassReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 441);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmbutton);
            this.Controls.Add(this.confirmpassbox);
            this.Controls.Add(this.passtxtbox);
            this.Controls.Add(this.ConfirmPasslbl);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.resetpass);
            this.Name = "PassReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resetpass;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Label ConfirmPasslbl;
        private System.Windows.Forms.TextBox passtxtbox;
        private System.Windows.Forms.TextBox confirmpassbox;
        private System.Windows.Forms.Button confirmbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}