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
            build.Database = "carpet_shop";
            build.Server = "localhost";

            bag = build.ToString();
            baglanti = new MySqlConnection(bag);
        
        }

        public void ListData(DataGridView DataGridList)
        {
            ConnectSql();
            String sql = "SELECT * FROM person_list";
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

       public void AddSallers(String tbName,String tbSurname,String tbDepartment,String tbDegree,String dtStartDate)
        {
            ConnectSql();
            baglanti.Open();
            string sql = "INSERT INTO person_list (NAME, SURNAME, DEPARTMAN_NAME, TITLE, START_DATE) VALUES ('" + tbName + "','" + tbSurname +
                                               "','" + tbDepartment + "','" + tbDegree + "','" + dtStartDate + "')";

               
            MySqlCommand komut = new MySqlCommand(sql,baglanti);
 
            komut.CommandText = sql;
            komut.Connection = baglanti;
 
            
            komut.ExecuteNonQuery(); //ExecuteNonQuery();
            baglanti.Close();

           
        }


    }
}
