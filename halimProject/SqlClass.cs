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

       public void AddSallers(String Name,String Surname,String Department,String Degree,String StartDate)
        {
            ConnectSql();
            baglanti.Open();
            string sql = "INSERT INTO person_list (NAME, SURNAME, DEPARTMAN_NAME, TITLE, START_DATE) VALUES ('" + Name + "','" + Surname +
                                               "','" + Department + "','" + Degree + "','" + StartDate + "')";

               
            MySqlCommand komut = new MySqlCommand(sql,baglanti);
 
            //komut.CommandText = sql;
            //komut.Connection = baglanti;
 
            
            komut.ExecuteNonQuery(); //ExecuteNonQuery();
            baglanti.Close();

           
        }


       public void AddCarpet(int Category_ıd,String Name,String Pieces,String Degree,String Code)
       {
           ConnectSql();
           baglanti.Open();  //`ID`, `NAME`, `CT_ID`, `SIZE`, `PRODUCT_CODE`, `PIECES`
           string sql = "INSERT INTO product_list ( NAME, CT_ID, SIZE, PRODUCT_CODE, PIECES) VALUES ('" + Name + "','" + Category_ıd +
                                                      "','" + Degree + "','" + Code + "','" + Pieces + "')";


           MySqlCommand komut = new MySqlCommand();

           komut.CommandText = sql;
           komut.Connection = baglanti;


           komut.ExecuteNonQuery(); //ExecuteNonQuery();
           baglanti.Close();


       }
       public void AddCategory(String CategoryName)
       {
           ConnectSql();

           baglanti.Open();
           String Sql = "INSERT INTO  category_list (NAME) VALUES ('" + CategoryName + "')";

           MySqlCommand komut = new MySqlCommand(Sql, baglanti);

           komut.CommandText = Sql;
           komut.Connection = baglanti;

           komut.ExecuteNonQuery();
           baglanti.Close();
        
       }

       public void AddSale(int Category_ıd, String Prd_Code, String WhoSaller, String WHOSE_COSTUMER, String PAYED_TYPE,
                  String KK_KOMISYON, String SALES_PIECES, String SALE_PRICE, String KOMISYON_AMOUNT, String CUS_EXPENSE, String CARGO_PRICE, String PAYMENT)
       {
           ConnectSql();

           baglanti.Open();
           //sales_list`(`ID`, `CT_ID`, `PRD_CODE`, `WHO_SELL`, `WHOSE_COSTUMER`, `PAYED_TYPE`, `KK_KOMISYON`,
           //`SALES_PIECES`, `SALE_PRICE`, `KOMISYON_AMOUNT`, `CUS_EXPENSE`, `CARGO_PRICE`, `PAYMENT`)
           String Sql = "INSERT INTO  sales_list (CT_ID,PRD_CODE,WHO_SELL,WHOSE_COSTUMER,PAYED_TYPE,KK_KOMISYON,SALES_PIECES,SALE_PRICE,KOMISYON_AMOUNT,"
                           + "CUS_EXPENSE,CARGO_PRICE,PAYMENT, COUNTRY_ID,PR_ID,CTIME)" + "VALUES ('" + Category_ıd + "','" + Prd_Code +
                            "','" + WhoSaller + "','" + WHOSE_COSTUMER + "','" + PAYED_TYPE + "','" + KK_KOMISYON + "','" + SALES_PIECES +
                            "','" + SALE_PRICE + "','" + KOMISYON_AMOUNT + "','" + CUS_EXPENSE + "','" + CARGO_PRICE + "','" + PAYMENT + "','" + 1 + "','" + 1 + "','" + DateTime.Now.Date+ "')";

           MySqlCommand komut = new MySqlCommand(Sql, baglanti);

           komut.CommandText = Sql;
           komut.Connection = baglanti;

           komut.ExecuteNonQuery();
           baglanti.Close();

       }



    }
}
