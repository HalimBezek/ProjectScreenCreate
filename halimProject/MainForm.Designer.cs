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
            this.label1 = new System.Windows.Forms.Label();
            this.Kapat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.AddPerson = new System.Windows.Forms.Button();
            this.btnAddNewRecord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnlList.Location = new System.Drawing.Point(0, 94);
            this.pnlList.Name = "pnlList";
            this.pnlList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlList.Size = new System.Drawing.Size(952, 395);
            this.pnlList.TabIndex = 3;
            // 
            // dgvPersonList
            // 
            this.dgvPersonList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvPersonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvPersonList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonList.GridColor = System.Drawing.SystemColors.Window;
            this.dgvPersonList.Location = new System.Drawing.Point(0, 0);
            this.dgvPersonList.Name = "dgvPersonList";
            this.dgvPersonList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvPersonList.Size = new System.Drawing.Size(952, 338);
            this.dgvPersonList.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Kapat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 57);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(389, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "El Rincon De Fehmi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kapat
            // 
            this.Kapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Kapat.Location = new System.Drawing.Point(813, 3);
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AddProduct);
            this.panel1.Controls.Add(this.AddPerson);
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(420, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 70);
            this.button1.TabIndex = 25;
            this.button1.Text = "Stok Listesi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddProduct.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.AddProduct.Location = new System.Drawing.Point(812, 12);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(113, 68);
            this.AddProduct.TabIndex = 24;
            this.AddProduct.Text = "Ürün Ekle ";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // AddPerson
            // 
            this.AddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddPerson.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.AddPerson.Location = new System.Drawing.Point(682, 12);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(113, 68);
            this.AddPerson.TabIndex = 23;
            this.AddPerson.Text = "Kişi Ekle";
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // btnAddNewRecord
            // 
            this.btnAddNewRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewRecord.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAddNewRecord.Location = new System.Drawing.Point(553, 11);
            this.btnAddNewRecord.Name = "btnAddNewRecord";
            this.btnAddNewRecord.Size = new System.Drawing.Size(113, 70);
            this.btnAddNewRecord.TabIndex = 13;
            this.btnAddNewRecord.Text = "Satış Ekle ";
            this.btnAddNewRecord.UseVisualStyleBackColor = true;
            this.btnAddNewRecord.Click += new System.EventHandler(this.btnAddNewRecord_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bitiş Tarihi          :";
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
            this.dateTimeEnd.Value = new System.DateTime(2003, 2, 24, 0, 0, 0, 0);
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Location = new System.Drawing.Point(110, 8);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(104, 20);
            this.dateTimeBegin.TabIndex = 9;
            this.dateTimeBegin.Value = new System.DateTime(2003, 2, 24, 0, 0, 0, 0);
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
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
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
        private System.Windows.Forms.Button btnAddNewRecord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Kapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPersonList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

