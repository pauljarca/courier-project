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
    public partial class ListareRetur : Form
    {
        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Info An 3\PS BD\courier-project\courier-project\courierDb.mdf;Integrated Security=True";
        SqlConnection sqlConn = new SqlConnection(connString);
        SqlCommand cmd;
        DataTable dt = new DataTable();
        private void ListareRetur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courierDbDataSet.Sedii' table. You can move, or remove it, as needed.
            this.sediiTableAdapter.Fill(this.courierDbDataSet.Sedii);
            // TODO: This line of code loads data into the 'courierDbDataSet.Colete' table. You can move, or remove it, as needed.
            this.coleteTableAdapter.Fill(this.courierDbDataSet.Colete);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            if (dateTimePicker1.Value.CompareTo(DateTime.Today) > 0)
                MessageBox.Show("Data nu poate fi trecuta de azi.");
            else
            {
                cmd = new SqlCommand("SELECT  * FROM Colete WHERE Sediu=@Sediu", sqlConn);
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@Sediu", textBox1.Text);
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            sqlConn.Close();
        }
    }
}
