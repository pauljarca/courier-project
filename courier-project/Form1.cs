using System;
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
            LivrariPeSaptamana lps = new LivrariPeSaptamana();
            lps.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExpeditiiPeData epd = new ExpeditiiPeData();
            epd.ShowDialog();
            this.Close();
        }
    }
}
