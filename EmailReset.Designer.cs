namespace E_ShopManagementSystem
{
    partial class mailChangeForm
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
            this.EmailReset = new System.Windows.Forms.Label();
            this.newEmaillbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.newMailBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailReset
            // 
            this.EmailReset.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailReset.Location = new System.Drawing.Point(13, 13);
            this.EmailReset.Name = "EmailReset";
            this.EmailReset.Size = new System.Drawing.Size(177, 23);
            this.EmailReset.TabIndex = 0;
            this.EmailReset.Text = "Email Reset";
            // 
            // newEmaillbl
            // 
            this.newEmaillbl.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmaillbl.Location = new System.Drawing.Point(26, 59);
            this.newEmaillbl.Name = "newEmaillbl";
            this.newEmaillbl.Size = new System.Drawing.Size(191, 23);
            this.newEmaillbl.TabIndex = 1;
            this.newEmaillbl.Text = "Enter a New E-mail Here";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(26, 138);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(264, 18);
            this.passlbl.TabIndex = 2;
            this.passlbl.Text = "Enter Your Password To Confirm";
            // 
            // newMailBox
            // 
            this.newMailBox.Location = new System.Drawing.Point(29, 96);
            this.newMailBox.Multiline = true;
            this.newMailBox.Name = "newMailBox";
            this.newMailBox.Size = new System.Drawing.Size(300, 28);
            this.newMailBox.TabIndex = 3;
            this.newMailBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(29, 175);
            this.passBox.Multiline = true;
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(300, 28);
            this.passBox.TabIndex = 4;
            this.passBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.submitbtn.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.Color.White;
            this.submitbtn.Location = new System.Drawing.Point(121, 238);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(107, 53);
            this.submitbtn.TabIndex = 5;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.linkLabel1.Location = new System.Drawing.Point(150, 349);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 16);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "click here ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "to go back";
            // 
            // mailChangeForm
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
            this.Name = "mailChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailReset;
        private System.Windows.Forms.Label newEmaillbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.TextBox newMailBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}