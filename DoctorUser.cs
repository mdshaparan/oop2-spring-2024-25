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
    public partial class DoctorUser : UserControl
    {
        public DoctorUser()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        private void ShowInfo()
        {
    
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    
                    string query = @"SELECT * 
                         FROM Appointment 
                         WHERE CAST(AppointmentDateTime AS DATE) = @today";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    
                    cmd.Parameters.AddWithValue("@today", DateTime.Today);

                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);

                    if (ds.Tables.Count > 0)
                    {
                        DataTable dt = ds.Tables[0];
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = dt;
                       // dataGridView1.ColumnHeadersVisible = false;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;



                    }
                    else
                    {
                        MessageBox.Show("No Appointment found for today.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  ShowInfo();
        }

        private void DoctorUser_Load(object sender, EventArgs e)
        {

        }
    }

}
