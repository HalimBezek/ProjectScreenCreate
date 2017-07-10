using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Net;
using System.Net.Mail;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Globalization;
namespace halimProject
{
    public partial class AddSale : Form
    {
        String kategoriId;
        String productID;

        String bag;
        MySqlConnection baglanti;

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        //  String sql = "SELECT * FROM customer_list "; // +DataListesi;
        //if (DataGridList.Name == "dtgridSalesList")
        //    sql = sql + " ORDER BY  SALE_CODE";
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand();
        MySqlCommandBuilder cmdb;
        public AddSale()
        {
            InitializeComponent();

            build.Server = "127.0.0.1";//	localhost
            build.UserID = "root";
            build.Password = "";
            build.Database = "carpet_shop";
            build.Port = 3306;
            build.ConvertZeroDateTime = true;


            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            baglanti.Open();

            kategoriId = "0";
            productID = "0";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            String textt;

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            String sqlNewCase = "SELECT pl.PIECES FROM product_list pl WHERE pl.ID = " + Convert.ToInt32(productID) + ";";
            MySqlCommand komutCase = new MySqlCommand(sqlNewCase, baglanti);
            String PiecesCount = komutCase.ExecuteScalar().ToString();

            if (Convert.ToInt32(PiecesCount) < Convert.ToInt32(txbSALES_PIECES.Text))
            {
                MessageBox.Show("Elinizde yeterli sayıda kayıtlı ürün yok.", "Bilgilendirme Mesajı");

            }
            else
            {
                try
                {
                    SqlClass sqlConn = new SqlClass();

                    sqlConn.AddSale(Convert.ToInt32(kategoriId), bePrd_Code.Text, beWhoSaller.Text, txbWHOSE_COSTUMER.Text, txbPAYED_TYPE.Text,
                          txbKK_KOMISYON.Text, txbSALES_PIECES.Text, txbSALE_PRICE.Text, txbKOMISYON_AMOUNT.Text, txbCUS_EXPENSE.Text, txbCARGO_PRICE.Text, txbPAYMENT.Text);

                    textt = "UPDATE product_list pl SET pl.PIECES= pl.PIECES - " + Convert.ToInt32(txbSALES_PIECES.Text) + " WHERE pl.ID = " + Convert.ToInt32(productID) + ";";

                    string sqlUpdate = textt;

                    MySqlCommand komutUpdate = new MySqlCommand(sqlUpdate, baglanti);

                    komutUpdate.ExecuteNonQuery();//

                    baglanti.Close();
                }
                finally
                {
                    beCategory.Text = "";
                    bePrd_Code.Text = "";
                    beWhoSaller.Text = "";
                    txbCARGO_PRICE.Text = "";
                    txbCUS_EXPENSE.Text = "";
                    txbKK_KOMISYON.Text = "";
                    txbKOMISYON_AMOUNT.Text = "";
                    txbPAYED_TYPE.Text = "";
                    txbPAYMENT.Text = "";
                    txbSALE_PRICE.Text = "";
                    txbSALES_PIECES.Text = "";
                    txbWHOSE_COSTUMER.Text = "";

                    labelKayit.Visible = true;
                }
            }
        }

        private void txbWHOSE_COSTUMER_TextChanged(object sender, EventArgs e)
        {
            labelKayit.Visible = false;
        }

        private void txbSALES_PIECES_TextChanged(object sender, EventArgs e)
        {
            labelKayit.Visible = false;
        }

        private void AddSale_Load(object sender, EventArgs e)
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

        private void bePrd_Code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //bu liste kategorıye göre açılacak
            productID = "0";
            frmStokListesi kl = new frmStokListesi();
            if (kl.ShowDialog() == DialogResult.OK)
            {
                bePrd_Code.Text = kl.dtgrdList.CurrentRow.Cells["NAME"].Value.ToString() + " ( " + kl.dtgrdList.CurrentRow.Cells["PRODUCT_CODE"].Value.ToString() + " )";    //tbName.Text;
                productID = kl.dtgrdList.CurrentRow.Cells["ID"].Value.ToString();
            }
        }

        private void beWhoSaller_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmKisiListesi kl = new frmKisiListesi();
            if (kl.ShowDialog() == DialogResult.OK)
            {
                beWhoSaller.Text = kl.dtgrdList.CurrentRow.Cells["NAME"].Value.ToString() + " " + kl.dtgrdList.CurrentRow.Cells["SURNAME"].Value.ToString();    //tbName.Text;
            }
        }

        private void txbKK_KOMISYON_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txbSALES_PIECES_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
