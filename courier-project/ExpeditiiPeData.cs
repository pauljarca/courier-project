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
    public partial class ExpeditiiPeData : Form
    {
        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Info An 3\PS BD\courier-project\courier-project\courierDb.mdf;Integrated Security=True";
        SqlConnection sqlConn = new SqlConnection(connString);
        SqlCommand cmd;
        DataTable dt = new DataTable();

        public ExpeditiiPeData()
        {
            InitializeComponent();
            LoadData();
        }

        private void ExpeditiiPeData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courierDbDataSet.Sedii' table. You can move, or remove it, as needed.
            this.sediiTableAdapter.Fill(this.courierDbDataSet.Sedii);

        }

        private void LoadData()
        {
            sqlConn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT IdColet,Expeditor,Destinatar,OrasA,OrasB,DataExpeditie FROM Colete", sqlConn);
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

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            cmd = new SqlCommand("SELECT IdColet,Expeditor,Destinatar,OrasA,OrasB,DataLivrare FROM Colete WHERE Sediu=@Sediu AND DataExpeditie=@data", sqlConn);
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);

            cmd.Parameters.AddWithValue("@Sediu", comboBox2.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@data", dateTimePicker1.Value.Date);

            cmd.ExecuteNonQuery();
            dt = new DataTable();
            sqlDa.Fill(dt);

            dataGridView1.DataSource = dt;
            sqlConn.Close();
        }
    }
}
