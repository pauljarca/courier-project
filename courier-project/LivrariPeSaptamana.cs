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
        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Info An 3\PS BD\courier-project\courier-project\courierDb.mdf;Integrated Security=True";
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
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT IdColet,Expeditor,Destinatar,OrasA,OrasB,DataLivrare FROM Colete", sqlConn);
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

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime luni = new DateTime(2022, 01, 03);
            DateTime marti = new DateTime(2022, 01, 04);
            DateTime miercuri = new DateTime(2022, 01, 05);
            DateTime joi = new DateTime(2022, 01, 06);
            DateTime vineri = new DateTime(2022, 01, 07);
            DateTime sambata = new DateTime(2022, 01, 08);
            DateTime duminica = new DateTime(2022, 01, 09);

            sqlConn.Open();
            cmd = new SqlCommand("SELECT IdColet,Expeditor,Destinatar,OrasA,OrasB,DataLivrare FROM Colete WHERE OrasA=@Sediu AND DataLivrare=@data", sqlConn);
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);

            cmd.Parameters.AddWithValue("@Sediu", comboBox2.SelectedValue.ToString());

            string zi = comboBox1.SelectedItem.ToString();

            switch (zi)
            {
                case "Luni":
                    cmd.Parameters.AddWithValue("@data", luni);
                    break;
                case "Marti":
                    cmd.Parameters.AddWithValue("@data", marti);
                    break;
                case "Miercuri":
                    cmd.Parameters.AddWithValue("@data", miercuri);
                    break;
                case "Joi":
                    cmd.Parameters.AddWithValue("@data", joi);
                    break;
                case "Vineri":
                    cmd.Parameters.AddWithValue("@data", vineri);
                    break;
                case "Sambata":
                    cmd.Parameters.AddWithValue("@data", sambata);
                    break;
                case "Duminica":
                    cmd.Parameters.AddWithValue("@data", duminica);
                    break;
            }

            cmd.ExecuteNonQuery();
            dt = new DataTable();
            sqlDa.Fill(dt);

            dataGridView1.DataSource = dt;
            sqlConn.Close();
        }
    }
}
