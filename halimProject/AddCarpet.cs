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
        public AddCarpet()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlClass sqlConn = new SqlClass();
            sqlConn.AddCarpet(cbCategory.TabIndex, txbName.Text, txbPieces.Text, txbDegree.Text,txbCode.Text);
        }

        private void btnAddNewCat_Click(object sender, EventArgs e)
        {
            SqlClass sqlConn = new SqlClass();
            sqlConn.AddCategory(txbCtName.Text);

        }
    }
}
