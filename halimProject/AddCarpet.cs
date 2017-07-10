using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halimProject
{
    public partial class AddCarpet : Form
    {
        String kategoriId;
        public AddCarpet()
        {
            InitializeComponent();

            kategoriId = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlClass sqlConn = new SqlClass();
            sqlConn.AddCarpet(Convert.ToInt32(kategoriId), txbName.Text, txbPieces.Text, txbDegree.Text, txbCode.Text);

            labelKayit.Visible = true;
            txbName.Text = "";
            txbPieces.Text = "";
            beCategory.Text = "";
            txbDegree.Text = "";
            txbCode.Text = "";
        }

        private void btnAddNewCat_Click(object sender, EventArgs e)
        {
            SqlClass sqlConn = new SqlClass();
            sqlConn.AddCategory(txbCtName.Text);

            txbCtName.Text = "";
            labelKat.Visible = true;

        }

        private void AddCarpet_Load(object sender, EventArgs e)
        {

        }

        private void beCategory_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            kategoriId = "0";
            frmKategoriListesi kl = new frmKategoriListesi();
            if (kl.ShowDialog() == DialogResult.OK)
            {
                beCategory.Text = kl.dtgrdList.CurrentRow.Cells["NAME"].Value.ToString();    //tbName.Text;
                kategoriId = kl.dtgrdList.CurrentRow.Cells["ID"].Value.ToString();
            }
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            labelKayit.Visible = false;
        }

        private void txbCtName_TextChanged(object sender, EventArgs e)
        {
            labelKat.Visible = false;
        }

        private void txbPieces_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
