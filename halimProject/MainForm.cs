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
    public partial class PersonalList : Form
    {
        public PersonalList()
        {
            InitializeComponent();
        }
        
        private void Kapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gbAddNewRecods.Visible = true;

        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            AddSallers frmAddSallers = new AddSallers();

            frmAddSallers.Show();
            gbAddNewRecods.Visible = false;
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddCarpet frmAddCarpet = new AddCarpet();

            frmAddCarpet.Show();
            gbAddNewRecods.Visible = false;
        }
    }
}
