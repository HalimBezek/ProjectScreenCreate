﻿using System;
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
            en.Close();   
            pl.Show();
            timer1.Enabled = false;
           


        }
    }
}
