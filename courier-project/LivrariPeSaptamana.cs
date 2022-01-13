using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courier_project
{
    public partial class LivrariPeSaptamana : Form
    {
        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\College\1st Semester\Proiect BD\Proiect\courier-project\courierDb.mdf;Integrated Security=True";
        SqlConnection sqlConn = new SqlConnection(connString);
        SqlCommand cmd;
        DataTable dt = new DataTable();

        public LivrariPeSaptamana()
        {
            InitializeComponent();
            LoadData();
        }

        private void LivrariPeSaptamana_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courierDbDataSet.Sedii' table. You can move, or remove it, as needed.
            this.sediiTableAdapter.Fill(this.courierDbDataSet.Sedii);
        }

        private void LoadData()
        {
            sqlConn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT IdColet,OrasA,OrasB,DataLivrare FROM Colete", sqlConn);
            dt = new DataTable();
            sqlDa.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConn.Open();
            cmd = new SqlCommand("SELECT IdColet,OrasA,OrasB,DataLivrare FROM Colete WHERE OrasA=@Sediu", sqlConn);
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);

            cmd.Parameters.AddWithValue("@Sediu", comboBox2.SelectedValue.ToString());
            cmd.ExecuteNonQuery();

            dt = new DataTable();
            sqlDa.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
