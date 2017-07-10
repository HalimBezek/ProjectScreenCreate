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
    
    public partial class StockList : Form
    {
        String bag;
        MySqlConnection baglanti;

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        String kategoriId;

        public StockList()
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

           
        }

        
        private void StockList_Load(object sender, EventArgs e)
        {

            kategoriId = "0";
            SqlClass sqlCon = new SqlClass();
            String bag;
            DataSet dSet = new DataSet();

            SqlClass connect = new SqlClass();
            connect.ConnectSql();
            String sql = "SELECT PL.ID, PL.NAME, CL.NAME , PL.SIZE, PL.PRODUCT_CODE, PL.PIECES, PL.DATE "+ 
                        " FROM product_list pl JOIN category_list CL ON CL.ID = PL.CT_ID ";

            DataTable dtable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();


            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;

            baglanti.Open();
            adapter.Fill(dtable);
            adapter.Fill(dSet);
            dgvStockList.DataSource = dtable;
            baglanti.Close();

            dgvStockList.Columns[0].HeaderText = "ID";
            dgvStockList.Columns[1].HeaderText = "Ürün Adı";
            dgvStockList.Columns[2].HeaderText = "Kategori Adı";
            dgvStockList.Columns[3].HeaderText = "Ölçü";
            dgvStockList.Columns[4].HeaderText = "Ürün Kodu";
            dgvStockList.Columns[5].HeaderText = "Adet";
            dgvStockList.Columns[6].HeaderText = "Kayıt Tarihi";


            dgvStockList.Columns[0].Visible = false;
            dgvStockList.AllowUserToAddRows = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void beKategori_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            kategoriId = "0";
            frmKategoriListesi kl = new frmKategoriListesi();
            if (kl.ShowDialog() == DialogResult.OK)
            {
                beKategori.Text = kl.dtgrdList.CurrentRow.Cells["NAME"].Value.ToString();    //tbName.Text;
                kategoriId = kl.dtgrdList.CurrentRow.Cells["ID"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yr, m, d, yr2, m2, d2;
            String sql;

            yr = dateTimeBegin.Value.Year.ToString();
            m = dateTimeBegin.Value.Month.ToString();
            d = dateTimeBegin.Value.Day.ToString();
            yr2 = dateTimeEnd.Value.Year.ToString();
            m2 = dateTimeEnd.Value.Month.ToString();
            d2 = dateTimeEnd.Value.Day.ToString();


            SqlClass sqlCon = new SqlClass();
            String bag;
            DataSet dSet = new DataSet();

            SqlClass connect = new SqlClass();
            connect.ConnectSql();

            if (beKategori.Text.Trim() != "")
            {

                sql = "SELECT PL.ID, PL.NAME, CL.NAME , PL.SIZE, PL.PRODUCT_CODE, PL.PIECES, PL.DATE "+ 
                       " FROM product_list pl JOIN category_list CL ON CL.ID = PL.CT_ID Where pl.CT_ID = " + kategoriId + " AND (" + "pl.DATE BETWEEN '" +
                         yr + "-" + m + "-" + d + "' AND " + "'" + yr2 + "-" + m2 + "-" + d2 + "'"+")";

            }
            else
            {

                sql = "SELECT PL.ID, PL.NAME, CL.NAME , PL.SIZE, PL.PRODUCT_CODE, PL.PIECES, PL.DATE "+ 
                      " FROM product_list pl JOIN category_list CL ON CL.ID = PL.CT_ID Where pl.DATE BETWEEN '" +
                         yr + "-" + m + "-" + d + "' AND " + "'" + yr2 + "-" + m2 + "-" + d2 + "'";

            }

       

            DataTable dtable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();


            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;

            baglanti.Open();
            adapter.Fill(dtable);
            adapter.Fill(dSet);
            dgvStockList.DataSource = dtable;
            baglanti.Close();

            dgvStockList.Columns[0].HeaderText = "ID";
            dgvStockList.Columns[1].HeaderText = "Ürün Adı";
            dgvStockList.Columns[2].HeaderText = "Kategori Adı";
            dgvStockList.Columns[3].HeaderText = "Ölçü";
            dgvStockList.Columns[4].HeaderText = "Ürün Kodu";
            dgvStockList.Columns[5].HeaderText = "Adet";
            dgvStockList.Columns[6].HeaderText = "Kayıt Tarihi";


            dgvStockList.Columns[0].Visible = false;
        }


    }
}
