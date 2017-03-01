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


        private void AddPerson_Click(object sender, EventArgs e)
        {
            AddSallers frmAddSallers = new AddSallers();

            frmAddSallers.Show();

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddCarpet frmAddCarpet = new AddCarpet();

            frmAddCarpet.Show();

        }

        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            AddSale frmAddSale = new AddSale();
            frmAddSale.Show();
        }
    }
}
