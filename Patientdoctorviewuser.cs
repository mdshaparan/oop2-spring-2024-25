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

namespace HMS
{
    public partial class Patientdoctorviewuser : UserControl
    {
        public Patientdoctorviewuser()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void doctorviewlbl_Click(object sender, EventArgs e)
        {

        }

        private void Patientdoctorviewuser_Load(object sender, EventArgs e)
        {

        }

        private void ShowInfo()
        {
            string connectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;");
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT Doctor_ID, Doctor_FullName, Contact_no,Department, Room_no FROM Doctor_Reg WHERE Status = 'Active'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;";
            string departmentSearch = txt_Search.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Doctor_ID, Doctor_FullName, Room_no FROM Doctor_Reg WHERE Department LIKE @dept AND Status = 'Active'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@dept", "%" + departmentSearch + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
    }

