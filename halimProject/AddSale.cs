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
    public partial class AddSale : Form
    {
        public AddSale()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            SqlClass sqlConn = new SqlClass();
           
            sqlConn.AddSale(cmbCategory.TabIndex, cmbPrd_Code.Text, cmbWhoSaller.Text, txbWHOSE_COSTUMER.Text, txbPAYED_TYPE.Text,
                  txbKK_KOMISYON.Text, txbSALES_PIECES.Text, txbSALE_PRICE.Text, txbKOMISYON_AMOUNT.Text, txbCUS_EXPENSE.Text, txbCARGO_PRICE.Text, txbPAYMENT.Text);
        }

    }
}
