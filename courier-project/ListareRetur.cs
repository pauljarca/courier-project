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

        public ListareRetur()
        {
            InitializeComponent();
        }
        private void ListareRetur_Load(object sender, EventArgs e)
        {

            this.sediiTableAdapter.Fill(this.courierDbDataSet.Sedii);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            if (dateTimePicker1.Value.CompareTo(DateTime.Today) > 0)
                MessageBox.Show("Data nu poate fi trecuta de azi.");
            else
            {
                cmd = new SqlCommand("SELECT  * FROM Colete WHERE DAY(DataRetur)=@data", sqlConn);
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@data", dateTimePicker1.Value.Day);
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                sqlDa.Fill(dt);
                coleteDataGridView.DataSource = dt;
            }

            sqlConn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            if (dateTimePicker2.Value.CompareTo(DateTime.Today) > 0)
                MessageBox.Show("Data nu poate fi trecuta de azi.");
            else
            {
                cmd = new SqlCommand("SELECT SUM(ValoareRamburs) AS ValRam FROM Colete WHERE MONTH(DataLivrare)=@luna AND YEAR(DataLivrare)=@an", sqlConn);
                cmd.Parameters.AddWithValue("@luna", dateTimePicker2.Value.Month);
                cmd.Parameters.AddWithValue("@an", dateTimePicker2.Value.Year);
                cmd.ExecuteNonQuery();
                SqlDataReader rdr= cmd.ExecuteReader();
                rdr.Read();
                if (rdr["ValRam"].ToString().Equals(""))
                {
                    MessageBox.Show("Nu exista valori de afisat");
                }
                else
                {
                    float valRam = float.Parse(rdr["ValRam"].ToString());
                    textBox1.Text = valRam.ToString();
                }
            }
            sqlConn.Close();
        }
    }
}
