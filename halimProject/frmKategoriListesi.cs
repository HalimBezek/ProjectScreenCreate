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
    public partial class frmKategoriListesi : Form
    {
        String bag;
        MySqlConnection baglanti;

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        public frmKategoriListesi()
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

        private void dtgrdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmKategoriListesi_Load(object sender, EventArgs e)
        {
            SqlClass sqlCon = new SqlClass();
            String bag;
            DataSet dSet = new DataSet();

            SqlClass connect = new SqlClass();
            connect.ConnectSql();
            String sql = "SELECT * FROM category_list ";

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
            dtgrdList.DataSource = dtable;
            baglanti.Close();

            dtgrdList.Columns[0].HeaderText = "ID";
            dtgrdList.Columns[1].HeaderText = "Adı";

          //  dtgrdList.Columns[0].Visible = false;
        }
    }
}
