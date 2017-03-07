using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace halimProject
{

   public static  class SQL
    {

      // private MySqlConnection conn = new MySqlConnection("Data Source=denemeveritabanı;initial Catalog=sqlDeneme;user id = sa; password=1;Integrated Security =false");
            
     public static MySqlConnection baglanti;
     static   String bag;
     public static MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

       public static void connectSQL()
       {

           build.UserID = "root";
           build.Password = "12345678";
           build.Database = "denemeveritabanı";
           build.Server = "localhost";

           bag = build.ToString();
           baglanti = new MySqlConnection(bag);

           //String sql = "SELECT * FROM tablo1";
           //DataTable dt = new DataTable();

           //MySqlDataAdapter adapter = new MySqlDataAdapter();
           //MySqlCommand command = new MySqlCommand();

           //command.CommandText = sql;
           //command.Connection = baglanti;
           //adapter.SelectCommand = command;

           baglanti.Open();
           MessageBox.Show("database açık");   
           // adapter.Fill(dt);
           // dataGridView1.DataSource = dt;
       
       
       }

       //public static void InitializeComponent()
       // {
       //     this.SuspendLayout();
       //     // 
       //     // SQL
       //     // 
       //     this.ClientSize = new System.Drawing.Size(284, 261);
       //     this.Name = "SQL";
       //     this.Load += new System.EventHandler(this.SQL_Load);
       //     this.ResumeLayout(false);

       // }

    
    }
}
