namespace E_ShopManagementSystem
{
    partial class ModifyProductForm
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
            this.submitbtn = new System.Windows.Forms.Button();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.codebox = new System.Windows.Forms.TextBox();
            this.productid = new System.Windows.Forms.TextBox();
            this.Shopno = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.catagorybox = new System.Windows.Forms.ComboBox();
            this.quantitybox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.White;
            this.submitbtn.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.submitbtn.Location = new System.Drawing.Point(127, 384);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(143, 49);
            this.submitbtn.TabIndex = 51;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // pricebox
            // 
            this.pricebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricebox.Location = new System.Drawing.Point(94, 325);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(249, 27);
            this.pricebox.TabIndex = 50;
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.price.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.White;
            this.price.Location = new System.Drawing.Point(90, 290);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(244, 23);
            this.price.TabIndex = 49;
            this.price.Text = "Update Base Price";
            // 
            // codebox
            // 
            this.codebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codebox.Location = new System.Drawing.Point(93, 260);
            this.codebox.Name = "codebox";
            this.codebox.Size = new System.Drawing.Size(245, 27);
            this.codebox.TabIndex = 48;
            // 
            // productid
            // 
            this.productid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productid.Location = new System.Drawing.Point(94, 76);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(245, 27);
            this.productid.TabIndex = 47;
            this.productid.TextChanged += new System.EventHandler(this.productid_TextChanged);
            // 
            // Shopno
            // 
            this.Shopno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.Shopno.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shopno.ForeColor = System.Drawing.Color.White;
            this.Shopno.Location = new System.Drawing.Point(90, 50);
            this.Shopno.Name = "Shopno";
            this.Shopno.Size = new System.Drawing.Size(249, 23);
            this.Shopno.TabIndex = 46;
            this.Shopno.Text = "Enter Product Id";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.label5.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(90, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Update Quantity ";
            // 
            // catagorybox
            // 
            this.catagorybox.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagorybox.FormattingEnabled = true;
            this.catagorybox.Location = new System.Drawing.Point(93, 129);
            this.catagorybox.Name = "catagorybox";
            this.catagorybox.Size = new System.Drawing.Size(245, 28);
            this.catagorybox.TabIndex = 44;
            // 
            // quantitybox
            // 
            this.quantitybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitybox.Location = new System.Drawing.Point(93, 196);
            this.quantitybox.Name = "quantitybox";
            this.quantitybox.Size = new System.Drawing.Size(245, 27);
            this.quantitybox.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.label3.Location = new System.Drawing.Point(2, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 462);
            this.label3.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Update Product Catagory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Update Product Code";
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.price);
            this.Controls.Add(this.codebox);
            this.Controls.Add(this.productid);
            this.Controls.Add(this.Shopno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.catagorybox);
            this.Controls.Add(this.quantitybox);
            this.Controls.Add(this.label3);
            this.Name = "ModifyProductForm";
            this.Text = "ModifyProductForm";
            this.Load += new System.EventHandler(this.ModifyProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox codebox;
        private System.Windows.Forms.TextBox productid;
        private System.Windows.Forms.Label Shopno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox catagorybox;
        private System.Windows.Forms.TextBox quantitybox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}