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
    public partial class Entries : Form
    {
        public Entries()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            Entries en = new Entries();
            PersonalList pl = new PersonalList();
             
            pl.Show();
           
            timer1.Enabled = false;
            en.Close();
            //button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

           Close();
        }

        private void Entries_Load(object sender, EventArgs e)
        {

        }
    }
}
