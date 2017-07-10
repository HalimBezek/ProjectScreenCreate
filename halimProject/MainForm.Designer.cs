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
            this.dgvPersonList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddProduct = new System.Windows.Forms.Button();
            this.AddPerson = new System.Windows.Forms.Button();
            this.btnAddNewRecord = new System.Windows.Forms.Button();
            this.Kapat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlList.Controls.Add(this.dgvPersonList);
            this.pnlList.Controls.Add(this.panel2);
            this.pnlList.Location = new System.Drawing.Point(0, 75);
            this.pnlList.Name = "pnlList";
            this.pnlList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlList.Size = new System.Drawing.Size(952, 414);
            this.pnlList.TabIndex = 3;
            // 
            // dgvPersonList
            // 
            this.dgvPersonList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPersonList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvPersonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonList.GridColor = System.Drawing.SystemColors.Window;
            this.dgvPersonList.Location = new System.Drawing.Point(0, 0);
            this.dgvPersonList.Name = "dgvPersonList";
            this.dgvPersonList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvPersonList.Size = new System.Drawing.Size(952, 357);
            this.dgvPersonList.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddProduct);
            this.panel2.Controls.Add(this.AddPerson);
            this.panel2.Controls.Add(this.btnAddNewRecord);
            this.panel2.Controls.Add(this.Kapat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 57);
            this.panel2.TabIndex = 14;
            // 
            // AddProduct
            // 
            this.AddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddProduct.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.AddProduct.Location = new System.Drawing.Point(236, 6);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(81, 46);
            this.AddProduct.TabIndex = 27;
            this.AddProduct.Text = "Ürün Ekle ";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // AddPerson
            // 
            this.AddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddPerson.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.AddPerson.Location = new System.Drawing.Point(128, 6);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(81, 46);
            this.AddPerson.TabIndex = 26;
            this.AddPerson.Text = "Kişi Ekle";
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // btnAddNewRecord
            // 
            this.btnAddNewRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewRecord.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAddNewRecord.Location = new System.Drawing.Point(22, 6);
            this.btnAddNewRecord.Name = "btnAddNewRecord";
            this.btnAddNewRecord.Size = new System.Drawing.Size(80, 47);
            this.btnAddNewRecord.TabIndex = 25;
            this.btnAddNewRecord.Text = "Satış Ekle ";
            this.btnAddNewRecord.UseVisualStyleBackColor = true;
            this.btnAddNewRecord.Click += new System.EventHandler(this.btnAddNewRecord_Click);
            // 
            // Kapat
            // 
            this.Kapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Kapat.Location = new System.Drawing.Point(850, 5);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(75, 49);
            this.Kapat.TabIndex = 9;
            this.Kapat.Text = "Kapat";
            this.Kapat.UseVisualStyleBackColor = true;
            this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimeEnd);
            this.panel1.Controls.Add(this.dateTimeBegin);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 77);
            this.panel1.TabIndex = 7;
            this.panel1.TabStop = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(384, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "El Rincon De Fehmi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(738, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 52);
            this.button2.TabIndex = 26;
            this.button2.Text = "Personel Listesi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(846, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 52);
            this.button1.TabIndex = 25;
            this.button1.Text = "Stok Listesi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bitiş Tarihi          :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Başlangıç Tarihi :";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(111, 51);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(104, 20);
            this.dateTimeEnd.TabIndex = 10;
            this.dateTimeEnd.Value = new System.DateTime(2017, 6, 24, 0, 0, 0, 0);
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Location = new System.Drawing.Point(110, 21);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(104, 20);
            this.dateTimeBegin.TabIndex = 9;
            this.dateTimeBegin.Value = new System.DateTime(2017, 6, 23, 0, 0, 0, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(236, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 36);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.Text = "Satış Takip Listesi";
            this.Load += new System.EventHandler(this.PersonalList_Load);
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Kapat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPersonList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.Button btnAddNewRecord;
        private System.Windows.Forms.Label label1;
    }
}

