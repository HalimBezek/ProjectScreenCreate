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
    public partial class AddSallers : Form
    {
        public AddSallers()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlClass sqlConn = new SqlClass();
            sqlConn.AddSallers(tbName.Text, tbSurname.Text, tbDepartment.Text, tbDegree.Text, dtStartDate.Text.ToString());
        }
    }
}
