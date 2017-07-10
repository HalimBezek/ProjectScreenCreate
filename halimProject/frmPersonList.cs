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
    public partial class frmPersonList : Form
    {
        String bag;
        MySqlConnection baglanti;

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        public frmPersonList()
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

        private void frmPersonList_Load(object sender, EventArgs e)
        {
            SqlClass sqlCon = new SqlClass();
            String bag;
            DataSet dSet = new DataSet();

            SqlClass connect = new SqlClass();
            connect.ConnectSql();
            String sql = "SELECT * FROM person_list ";

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
            dgvPrsnkList.DataSource = dtable;
            baglanti.Close();

            dgvPrsnkList.Columns[0].HeaderText = "ID";
            dgvPrsnkList.Columns[1].HeaderText = "Adı";
            dgvPrsnkList.Columns[2].HeaderText = "Soyadı";
            dgvPrsnkList.Columns[3].HeaderText = "Bölümü";
            dgvPrsnkList.Columns[4].HeaderText = "Ünvanı";
            dgvPrsnkList.Columns[5].HeaderText = "Kayıt Tarihi";

            dgvPrsnkList.Columns[0].Visible = false;
            dgvPrsnkList.AllowUserToAddRows = false;

           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String textt;
            
            DialogResult x = MessageBox.Show("Kaydı Silmek İstediğinizden Emin misiniz?", "Bilgi Mesajı", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                if (baglanti.State != ConnectionState.Closed)
                    baglanti.Open();

                textt = "DELETE FROM person_list WHERE ID = " + Convert.ToInt32(dgvPrsnkList.CurrentRow.Cells["ID"].Value.ToString());


                string sqlDelete = textt;

              //  baglanti = new MySqlConnection(bag);
                MySqlCommand command = new MySqlCommand();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                command.CommandText = sqlDelete;
                command.Connection = baglanti;
                adapter.SelectCommand = command;

                MySqlCommand komutUpdate = new MySqlCommand(sqlDelete, baglanti);

                baglanti.Open();



                command.ExecuteNonQuery();//

                baglanti.Close();

                SqlClass sqlCon = new SqlClass();
                String bag;
                DataSet dSet = new DataSet();

                SqlClass connect = new SqlClass();
                connect.ConnectSql();
                String sql = "SELECT * FROM person_list ";

                DataTable dtable = new DataTable();

                adapter = new MySqlDataAdapter();
                command = new MySqlCommand();




                bag = build.ToString();
                baglanti = new MySqlConnection(bag);

                command.CommandText = sql;
                command.Connection = baglanti;
                adapter.SelectCommand = command;

                baglanti.Open();
                adapter.Fill(dtable);
                adapter.Fill(dSet);
                dgvPrsnkList.DataSource = dtable;
                baglanti.Close();

                dgvPrsnkList.Columns[0].HeaderText = "ID";
                dgvPrsnkList.Columns[1].HeaderText = "Adı";
                dgvPrsnkList.Columns[2].HeaderText = "Soyadı";
                dgvPrsnkList.Columns[3].HeaderText = "Bölümü";
                dgvPrsnkList.Columns[4].HeaderText = "Ünvanı";
                dgvPrsnkList.Columns[5].HeaderText = "Kayıt Tarihi";

                dgvPrsnkList.Columns[0].Visible = false;
                dgvPrsnkList.AllowUserToAddRows = false;

                
              
            }

            
        }
    }
}
