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




    public partial class DoctorDashboard : UserControl
    {
        DataTable dt11;
        public DoctorDashboard()
        {
            InitializeComponent();
            LoadDoctorData2();


        }
        public void SetDoctorData1(DataTable dt1)
        {
            dt11 = dt1;

            if (dt11 != null && dt11.Rows.Count > 0)
            {
                int doctorId = Convert.ToInt32(dt11.Rows[0][0]);
                
            }
        }

        private void DoctorDashboard_Load(object sender, EventArgs e)
        {

        }
        private void LoadDoctorData2()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    
                    conn.Open();

                    string query = @"SELECT 
                            Message,Issue_Date 

                         FROM Notice";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                  
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.RowHeadersVisible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

    }
}



