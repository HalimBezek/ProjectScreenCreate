namespace halimProject
{
    partial class AddScreen
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
            this.AddNewPerson = new System.Windows.Forms.Button();
            this.AddNewProduct = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewPerson
            // 
            this.AddNewPerson.Location = new System.Drawing.Point(27, 38);
            this.AddNewPerson.Name = "AddNewPerson";
            this.AddNewPerson.Size = new System.Drawing.Size(175, 50);
            this.AddNewPerson.TabIndex = 0;
            this.AddNewPerson.Text = "Kişi Ekle";
            this.AddNewPerson.UseVisualStyleBackColor = true;
            this.AddNewPerson.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewProduct
            // 
            this.AddNewProduct.Location = new System.Drawing.Point(260, 38);
            this.AddNewProduct.Name = "AddNewProduct";
            this.AddNewProduct.Size = new System.Drawing.Size(175, 50);
            this.AddNewProduct.TabIndex = 1;
            this.AddNewProduct.Text = "Ürün Ekle";
            this.AddNewProduct.UseVisualStyleBackColor = true;
            this.AddNewProduct.Click += new System.EventHandler(this.AddNewProduct_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(360, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "İptal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(454, 124);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AddNewProduct);
            this.Controls.Add(this.AddNewPerson);
            this.Name = "AddScreen";
            this.Text = "Yeni Kayıt Ekle";
            this.Load += new System.EventHandler(this.AddScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewPerson;
        private System.Windows.Forms.Button AddNewProduct;
        private System.Windows.Forms.Button button3;
    }
}