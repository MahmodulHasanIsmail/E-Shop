namespace E_ShopManagementSystem
{
    partial class selleremailreset
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.submitbtn = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.newMailBox = new System.Windows.Forms.TextBox();
            this.passlbl = new System.Windows.Forms.Label();
            this.newEmaillbl = new System.Windows.Forms.Label();
            this.EmailReset = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "to go back";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.linkLabel1.Location = new System.Drawing.Point(163, 364);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 16);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "click here ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.submitbtn.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.Color.White;
            this.submitbtn.Location = new System.Drawing.Point(134, 253);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(107, 53);
            this.submitbtn.TabIndex = 13;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(42, 190);
            this.passBox.Multiline = true;
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(300, 28);
            this.passBox.TabIndex = 12;
            // 
            // newMailBox
            // 
            this.newMailBox.Location = new System.Drawing.Point(42, 111);
            this.newMailBox.Multiline = true;
            this.newMailBox.Name = "newMailBox";
            this.newMailBox.Size = new System.Drawing.Size(300, 28);
            this.newMailBox.TabIndex = 11;
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(39, 153);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(264, 18);
            this.passlbl.TabIndex = 10;
            this.passlbl.Text = "Enter Your Password To Confirm";
            // 
            // newEmaillbl
            // 
            this.newEmaillbl.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmaillbl.Location = new System.Drawing.Point(39, 74);
            this.newEmaillbl.Name = "newEmaillbl";
            this.newEmaillbl.Size = new System.Drawing.Size(191, 23);
            this.newEmaillbl.TabIndex = 9;
            this.newEmaillbl.Text = "Enter a New E-mail Here";
            // 
            // EmailReset
            // 
            this.EmailReset.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailReset.Location = new System.Drawing.Point(26, 28);
            this.EmailReset.Name = "EmailReset";
            this.EmailReset.Size = new System.Drawing.Size(177, 23);
            this.EmailReset.TabIndex = 8;
            this.EmailReset.Text = "Email Reset";
            // 
            // selleremailreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.newMailBox);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.newEmaillbl);
            this.Controls.Add(this.EmailReset);
            this.Name = "selleremailreset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "selleremailreset";
            this.Load += new System.EventHandler(this.selleremailreset_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox newMailBox;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Label newEmaillbl;
        private System.Windows.Forms.Label EmailReset;
    }
}