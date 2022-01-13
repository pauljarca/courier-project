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
    public partial class LivrariPeSaptamana : Form
    {
        public LivrariPeSaptamana()
        {
            InitializeComponent();
        }

        private void LivrariPeSaptamana_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courierDbDataSet.Sedii' table. You can move, or remove it, as needed.
            this.sediiTableAdapter.Fill(this.courierDbDataSet.Sedii);

        }

        private void LoadData()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
