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
    public partial class Colete : Form
    {
        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Info An 3\PS BD\courier-project\courier-project\courierDb.mdf;Integrated Security=True";
        SqlConnection sqlConn = new SqlConnection(connString);
        SqlCommand cmd;
        DataTable dt = new DataTable();
        

        public Colete()
        {

            InitializeComponent();

         
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                sqlConn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT  * FROM Colete", sqlConn);
                dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlConn.Close();
            }
            else
            if (checkBox1.Checked == true)
            {

                sqlConn.Open();
                cmd = new SqlCommand("SELECT  * FROM Colete WHERE DAY(DataExpeditie)=@day AND MONTH(DataExpeditie)=@month AND YEAR(DataExpeditie)=@year", sqlConn);
                SqlDataAdapter sqlDa1 = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@year", dateTimePicker1.Value.Year);
                cmd.Parameters.AddWithValue("@month", dateTimePicker1.Value.Month);
                cmd.Parameters.AddWithValue("@day",dateTimePicker1.Value.Day);
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                sqlDa1.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlConn.Close();
            }
            else
                if(checkBox2.Checked == true)
            {

                sqlConn.Open();
                cmd = new SqlCommand("SELECT  * FROM Colete WHERE MONTH(DataExpeditie)=@month AND YEAR(DataExpeditie)=@year", sqlConn);
                SqlDataAdapter sqlDa1 = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@year", dateTimePicker1.Value.Year);
                cmd.Parameters.AddWithValue("@month", dateTimePicker1.Value.Month);
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                sqlDa1.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlConn.Close();

            }
			else
                if(checkBox3.Checked == true)
            {

                sqlConn.Open();
                cmd = new SqlCommand("SELECT  * FROM Colete WHERE YEAR(DataExpeditie)=@data", sqlConn);
                SqlDataAdapter sqlDa1 = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@data", dateTimePicker1.Value.Year);
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                sqlDa1.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlConn.Close();
            }

        }

    }
}
