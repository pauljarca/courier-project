using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace courier_project
{
    public partial class Rute : Form
    {

        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Info An 3\PS BD\courier-project\courier-project\courierDb.mdf;Integrated Security=True";
        SqlConnection sqlConn = new SqlConnection(connString);
        SqlCommand cmd;
        DataTable dt = new DataTable();

        public Rute()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT  * FROM Rute", sqlConn);
            dt = new DataTable();
            sqlDa.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                sqlConn.Open();
                cmd = new SqlCommand("SELECT  * FROM Rute WHERE Sediu=@Sediu", sqlConn);
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@Sediu",comboBox1.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlConn.Close();
            }
            else
            if(checkBox2.Checked == true)
            {
                sqlConn.Open();
                cmd = new SqlCommand("SELECT  * FROM Rute WHERE Subcontractor=@Subcontractor", sqlConn);
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
               cmd.Parameters.AddWithValue("@Subcontractor", comboBox2.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlConn.Close();
            }
           

        }

        private void Rute_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courierDbDataSet.Rute' table. You can move, or remove it, as needed.
            this.ruteTableAdapter.Fill(this.courierDbDataSet.Rute);
            // TODO: This line of code loads data into the 'courierDbDataSet.Subcontractori' table. You can move, or remove it, as needed.
            this.subcontractoriTableAdapter.Fill(this.courierDbDataSet.Subcontractori);
            // TODO: This line of code loads data into the 'courierDbDataSet1.Subcontractori' table. You can move, or remove it, as needed.
            this.subcontractoriTableAdapter.Fill(this.courierDbDataSet.Subcontractori);
            // TODO: This line of code loads data into the 'courierDbDataSet.Sedii' table. You can move, or remove it, as needed.
            this.sediiTableAdapter.Fill(this.courierDbDataSet.Sedii);

        }
    }
}
