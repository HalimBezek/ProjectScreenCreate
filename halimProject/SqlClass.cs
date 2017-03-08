using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace halimProject
{
    public class SqlClass
    {
         MySqlConnection baglanti;
       
        public void ConnectSql()
        {
            String bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

            build.UserID = "root";
            build.Password = "12345678";
            build.Database = "denemeveritabanı";
            build.Server = "localhost";

            bag = build.ToString();
            baglanti = new MySqlConnection(bag);
        
        }

        public void ListData(DataGridView DataGridList)
        {
            ConnectSql();
            String sql = "SELECT * FROM tablo1";
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;

            baglanti.Open();
            adapter.Fill(dt);
            DataGridList.DataSource = dt;
          
        }
    }
}
