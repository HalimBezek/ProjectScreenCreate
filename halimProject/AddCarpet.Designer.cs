namespace halimProject
{
    partial class AddCarpet
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPieces = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDegree = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelKat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCtName = new System.Windows.Forms.TextBox();
            this.btnAddNewCat = new System.Windows.Forms.Button();
            this.beCategory = new DevExpress.XtraEditors.ButtonEdit();
            this.labelKayit = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beCategory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(468, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 43);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Kapat";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ürün Kodu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ürün Adı :";
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(430, 169);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(113, 20);
            this.txbCode.TabIndex = 15;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(159, 134);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(115, 20);
            this.txbName.TabIndex = 12;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(373, 258);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 43);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ürün Adedi:";
            // 
            // txbPieces
            // 
            this.txbPieces.Location = new System.Drawing.Point(159, 169);
            this.txbPieces.Name = "txbPieces";
            this.txbPieces.Size = new System.Drawing.Size(115, 20);
            this.txbPieces.TabIndex = 21;
            this.txbPieces.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPieces_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ölçü :";
            // 
            // txbDegree
            // 
            this.txbDegree.Location = new System.Drawing.Point(430, 130);
            this.txbDegree.Name = "txbDegree";
            this.txbDegree.Size = new System.Drawing.Size(113, 20);
            this.txbDegree.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ürün Kategorisi :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelKat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbCtName);
            this.groupBox1.Controls.Add(this.btnAddNewCat);
            this.groupBox1.Location = new System.Drawing.Point(48, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 76);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kategori Ekle";
            // 
            // labelKat
            // 
            this.labelKat.AutoSize = true;
            this.labelKat.Location = new System.Drawing.Point(156, 25);
            this.labelKat.Name = "labelKat";
            this.labelKat.Size = new System.Drawing.Size(64, 13);
            this.labelKat.TabIndex = 34;
            this.labelKat.Text = "Kayıt Yapıldı";
            this.labelKat.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Adı :";
            // 
            // txbCtName
            // 
            this.txbCtName.Location = new System.Drawing.Point(25, 41);
            this.txbCtName.Name = "txbCtName";
            this.txbCtName.Size = new System.Drawing.Size(113, 20);
            this.txbCtName.TabIndex = 32;
            this.txbCtName.TextChanged += new System.EventHandler(this.txbCtName_TextChanged);
            // 
            // btnAddNewCat
            // 
            this.btnAddNewCat.Location = new System.Drawing.Point(151, 41);
            this.btnAddNewCat.Name = "btnAddNewCat";
            this.btnAddNewCat.Size = new System.Drawing.Size(69, 29);
            this.btnAddNewCat.TabIndex = 31;
            this.btnAddNewCat.Text = "Ekle";
            this.btnAddNewCat.UseVisualStyleBackColor = true;
            this.btnAddNewCat.Click += new System.EventHandler(this.btnAddNewCat_Click);
            // 
            // beCategory
            // 
            this.beCategory.Location = new System.Drawing.Point(430, 94);
            this.beCategory.Name = "beCategory";
            this.beCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beCategory.Size = new System.Drawing.Size(113, 20);
            this.beCategory.TabIndex = 32;
            this.beCategory.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beCategory_ButtonClick);
            // 
            // labelKayit
            // 
            this.labelKayit.AutoSize = true;
            this.labelKayit.Location = new System.Drawing.Point(377, 242);
            this.labelKayit.Name = "labelKayit";
            this.labelKayit.Size = new System.Drawing.Size(64, 13);
            this.labelKayit.TabIndex = 33;
            this.labelKayit.Text = "Kayıt Yapıldı";
            this.labelKayit.Visible = false;
            // 
            // AddCarpet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(575, 313);
            this.Controls.Add(this.labelKayit);
            this.Controls.Add(this.beCategory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDegree);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbPieces);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddCarpet";
            this.Text = "Ürün Ekle";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddCarpet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beCategory.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPieces;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDegree;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCtName;
        private System.Windows.Forms.Button btnAddNewCat;
        private DevExpress.XtraEditors.ButtonEdit beCategory;
        private System.Windows.Forms.Label labelKayit;
        private System.Windows.Forms.Label labelKat;
    }
}