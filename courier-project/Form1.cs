﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courier_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rute f = new Rute(); 
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Colete f = new Colete(); 
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlanTarifar f = new PlanTarifar(); 
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListareRetur f = new ListareRetur(); 
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListareLivrariZi f = new ListareLivrariZi();
            f.Show();
        }
    }
}
