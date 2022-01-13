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
    public partial class ListareLivrariZi : Form
    {
        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Info An 3\PS BD\courier-project\courier-project\courierDb.mdf;Integrated Security=True";
        SqlConnection sqlConn = new SqlConnection(connString);
        SqlCommand cmd;
        DataTable dt = new DataTable();

        public ListareLivrariZi()
        {
            InitializeComponent();
        }

        private void ListareLivrariZi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courierDbDataSet.Subcontractori' table. You can move, or remove it, as needed.
            this.subcontractoriTableAdapter.Fill(this.courierDbDataSet.Subcontractori);
            // TODO: This line of code loads data into the 'courierDbDataSet.Colete' table. You can move, or remove it, as needed.
            this.coleteTableAdapter.Fill(this.courierDbDataSet.Colete);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            if (dateTimePicker1.Value.CompareTo(DateTime.Today) > 0)
                MessageBox.Show("Data nu poate fi trecuta de azi.");
            else if (numeComboBox.Text == "")
            {
                MessageBox.Show("Selectati un subcontractor.");
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    cmd = new SqlCommand(
                        "SELECT * FROM Colete WHERE DataLivrare=@data AND Subcontractor=@subcontractor",
                        sqlConn);
                }
                else if (radioButton2.Checked == true)
                {
                    cmd = new SqlCommand(
                        "SELECT * FROM Colete WHERE DataColectare=@data AND Subcontractor=@subcontractor",
                        sqlConn);
                }

                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@data", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@subcontractor", numeComboBox.Text);
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                sqlDa.Fill(dt);
                coleteDataGridView.DataSource = dt;
                sqlConn.Close();
            }
        }
    }
}
