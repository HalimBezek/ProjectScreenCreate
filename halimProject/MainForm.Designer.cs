namespace halimProject
{
    partial class PersonalList
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
            this.pnlList = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Kapat = new System.Windows.Forms.Button();
            this.gvList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNewRecord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gbAddNewRecods = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddPerson = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GivePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALE_QUANTITIY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlList.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbAddNewRecods.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlList.Controls.Add(this.panel2);
            this.pnlList.Controls.Add(this.gvList);
            this.pnlList.Location = new System.Drawing.Point(0, 94);
            this.pnlList.Name = "pnlList";
            this.pnlList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlList.Size = new System.Drawing.Size(952, 395);
            this.pnlList.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Kapat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 31);
            this.panel2.TabIndex = 14;
            // 
            // Kapat
            // 
            this.Kapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Kapat.Location = new System.Drawing.Point(813, 3);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(75, 23);
            this.Kapat.TabIndex = 9;
            this.Kapat.Text = "Kapat";
            this.Kapat.UseVisualStyleBackColor = true;
            this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // gvList
            // 
            this.gvList.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.gvList.BackgroundColor = System.Drawing.Color.White;
            this.gvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.ProductName,
            this.Piece,
            this.Price,
            this.Commision,
            this.GivePrice,
            this.SALE_QUANTITIY,
            this.Date});
            this.gvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvList.Location = new System.Drawing.Point(0, 0);
            this.gvList.Name = "gvList";
            this.gvList.Size = new System.Drawing.Size(952, 395);
            this.gvList.TabIndex = 3;
            this.gvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.AddProduct);
            this.panel1.Controls.Add(this.AddPerson);
            this.panel1.Controls.Add(this.gbAddNewRecods);
            this.panel1.Controls.Add(this.btnAddNewRecord);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimeEnd);
            this.panel1.Controls.Add(this.dateTimeBegin);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 90);
            this.panel1.TabIndex = 7;
            this.panel1.TabStop = true;
            // 
            // btnAddNewRecord
            // 
            this.btnAddNewRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewRecord.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAddNewRecord.Location = new System.Drawing.Point(813, 2);
            this.btnAddNewRecord.Name = "btnAddNewRecord";
            this.btnAddNewRecord.Size = new System.Drawing.Size(113, 27);
            this.btnAddNewRecord.TabIndex = 13;
            this.btnAddNewRecord.Text = "Satış Ekle ";
            this.btnAddNewRecord.UseVisualStyleBackColor = true;
            this.btnAddNewRecord.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bitiş Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Başlangıç Tarihi :";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(110, 33);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(104, 20);
            this.dateTimeEnd.TabIndex = 10;
            this.dateTimeEnd.Value = new System.DateTime(2017, 2, 24, 0, 0, 0, 0);
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Location = new System.Drawing.Point(110, 8);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(104, 20);
            this.dateTimeBegin.TabIndex = 9;
            this.dateTimeBegin.Value = new System.DateTime(2017, 2, 24, 0, 0, 0, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(139, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "hjklş",
            "jklş",
            "bnkl"});
            this.comboBox1.Location = new System.Drawing.Point(19, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "El Rincon De Fehmi";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "hjklş",
            "jklş",
            "bnkl"});
            this.comboBox2.Location = new System.Drawing.Point(19, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(126, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "Ürün Kodu";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Satış Fiyatı";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "Adet";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(291, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "Komisyon Tutarı";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // gbAddNewRecods
            // 
            this.gbAddNewRecods.Controls.Add(this.button1);
            this.gbAddNewRecods.Controls.Add(this.textBox4);
            this.gbAddNewRecods.Controls.Add(this.textBox1);
            this.gbAddNewRecods.Controls.Add(this.comboBox2);
            this.gbAddNewRecods.Controls.Add(this.textBox3);
            this.gbAddNewRecods.Controls.Add(this.comboBox1);
            this.gbAddNewRecods.Controls.Add(this.textBox2);
            this.gbAddNewRecods.Location = new System.Drawing.Point(259, 0);
            this.gbAddNewRecods.Name = "gbAddNewRecods";
            this.gbAddNewRecods.Size = new System.Drawing.Size(502, 77);
            this.gbAddNewRecods.TabIndex = 22;
            this.gbAddNewRecods.TabStop = false;
            this.gbAddNewRecods.Text = "Yeni Satış Ekle";
            this.gbAddNewRecods.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(291, 48);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 22;
            this.textBox4.Text = "Yapılan Ödeme";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddPerson
            // 
            this.AddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddPerson.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.AddPerson.Location = new System.Drawing.Point(813, 31);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(113, 27);
            this.AddPerson.TabIndex = 23;
            this.AddPerson.Text = "AddPerson";
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddProduct.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.AddProduct.Location = new System.Drawing.Point(813, 61);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(113, 27);
            this.AddProduct.TabIndex = 24;
            this.AddProduct.Text = "Ürün Ekle ";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "Ad Soyad";
            this.NAME.Name = "NAME";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Ürün Kodu";
            this.ProductName.Name = "ProductName";
            // 
            // Piece
            // 
            this.Piece.HeaderText = "Kaç Adet";
            this.Piece.Name = "Piece";
            // 
            // Price
            // 
            this.Price.HeaderText = "Satış Fiyatı";
            this.Price.Name = "Price";
            // 
            // Commision
            // 
            this.Commision.HeaderText = "Komisyon Miktarı";
            this.Commision.Name = "Commision";
            // 
            // GivePrice
            // 
            this.GivePrice.HeaderText = "Yapılan Ödeme";
            this.GivePrice.Name = "GivePrice";
            // 
            // SALE_QUANTITIY
            // 
            this.SALE_QUANTITIY.HeaderText = "Satış Fiyatı";
            this.SALE_QUANTITIY.Name = "SALE_QUANTITIY";
            // 
            // Date
            // 
            this.Date.HeaderText = "Satış Zamanı";
            this.Date.Name = "Date";
            // 
            // PersonalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(952, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlList);
            this.MinimumSize = new System.Drawing.Size(968, 528);
            this.Name = "PersonalList";
            this.ShowInTaskbar = false;
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.PersonalList_Load);
            this.pnlList.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbAddNewRecods.ResumeLayout(false);
            this.gbAddNewRecods.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.DataGridView gvList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Button btnAddNewRecord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Kapat;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAddNewRecods;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piece;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commision;
        private System.Windows.Forms.DataGridViewTextBoxColumn GivePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALE_QUANTITIY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}

