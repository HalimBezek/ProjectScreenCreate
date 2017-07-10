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
    public partial class PersonalList : Form
    {
       
        String bag;
        MySqlConnection baglanti;

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
       
        public PersonalList()
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
        
        private void Kapat_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void AddPerson_Click(object sender, EventArgs e)
        {



            AddSallers frmAddSallers = new AddSallers();

            frmAddSallers.Show();

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddCarpet frmAddCarpet = new AddCarpet();

            frmAddCarpet.Show();

        }

        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            AddSale frmAddSale = new AddSale();
            frmAddSale.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockList frmStockList = new StockList();
            frmStockList.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string yr, m, d, yr2, m2, d2;

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

            String SQLTEXT = "SELECT sl.* FROM sales_list sl Where sl.DATE BETWEEN '" +
                              yr + "-" + m + "-" + d + "' AND " + "'" + yr2 + "-" + m2 + "-" + d2 + "'";
            String sql = SQLTEXT;

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
            dgvPersonList.DataSource = dtable;
            baglanti.Close();

            dgvPersonList.Columns[0].HeaderText = "ID";
            dgvPersonList.Columns[1].HeaderText = "CT_ID";
            dgvPersonList.Columns[2].HeaderText = "Ürün Kodu";
            dgvPersonList.Columns[3].HeaderText = "Kim Satmmış";

            dgvPersonList.Columns[4].HeaderText = "Kime Satmış";
            dgvPersonList.Columns[5].HeaderText = "Satış Tipi";

            dgvPersonList.Columns[6].HeaderText = "Satış Adedi";
            dgvPersonList.Columns[7].HeaderText = "Satış Fiyatı";
            dgvPersonList.Columns[8].HeaderText = "Komisyon Tutarı";
            dgvPersonList.Columns[9].HeaderText = "Kredi K. Komisyonu";

            dgvPersonList.Columns[10].HeaderText = "Müşteri Gideri";
            dgvPersonList.Columns[11].HeaderText = "Kargo Fiyatı ";

            dgvPersonList.Columns[12].HeaderText = "Yapılan Ödeme";
            dgvPersonList.Columns[13].HeaderText = "c_id";

            dgvPersonList.Columns[14].HeaderText = "pr_id";
            dgvPersonList.Columns[15].HeaderText = "Stış Tarihi";

            dgvPersonList.Columns[0].Visible = false;
            dgvPersonList.Columns[1].Visible = false;
            dgvPersonList.Columns[13].Visible = false;
            dgvPersonList.Columns[14].Visible = false;
            dgvPersonList.AllowUserToAddRows = false;
            
            
        }

        private void PersonalList_Load(object sender, EventArgs e)
        {

            SqlClass sqlCon = new SqlClass();
            String bag;
            DataSet dSet = new DataSet();

            SqlClass connect = new SqlClass();
            connect.ConnectSql();
            String sql = "SELECT * FROM sales_list ";

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
            dgvPersonList.DataSource = dtable;
            baglanti.Close();

            dgvPersonList.Columns[0].HeaderText = "ID";
            dgvPersonList.Columns[1].HeaderText = "CT_ID";
            dgvPersonList.Columns[2].HeaderText = "Ürün Kodu";
            dgvPersonList.Columns[3].HeaderText = "Kim Satmmış";

            dgvPersonList.Columns[4].HeaderText = "Kime Satmış";
            dgvPersonList.Columns[5].HeaderText = "Satış Tipi";

            dgvPersonList.Columns[6].HeaderText = "Satış Adedi";
            dgvPersonList.Columns[7].HeaderText = "Satış Fiyatı";
            dgvPersonList.Columns[8].HeaderText = "Komisyon Tutarı";
            dgvPersonList.Columns[9].HeaderText = "Kredi K. Komisyonu";
            
            dgvPersonList.Columns[10].HeaderText = "Müşteri Gideri";
            dgvPersonList.Columns[11].HeaderText = "Kargo Fiyatı ";

            dgvPersonList.Columns[12].HeaderText = "Yapılan Ödeme";
            dgvPersonList.Columns[13].HeaderText = "c_id";

            dgvPersonList.Columns[14].HeaderText = "pr_id";
            dgvPersonList.Columns[15].HeaderText = "Stış Tarihi";

            dgvPersonList.Columns[0].Visible = false;
            dgvPersonList.Columns[1].Visible = false;
            dgvPersonList.Columns[13].Visible = false;
            dgvPersonList.Columns[14].Visible = false;
            dgvPersonList.AllowUserToAddRows = false;
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPersonList frmPL = new frmPersonList();
            frmPL.Show();
        }

    }
}
