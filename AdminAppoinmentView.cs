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
    public partial class AdminAppoinmentView : UserControl
    {
        public AdminAppoinmentView()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void ShowInfo()
        {
            string connectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;");
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM Appointment";
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

        private void AdminAppoinmentView_Load(object sender, EventArgs e)
        {

        }

        private void Appoinment_btnSearch_Click(object sender, EventArgs e)
        {


         
            
            if (!int.TryParse(txtAppointment_Search.Text.Trim(), out int patientId))
            {
                MessageBox.Show("Please enter a valid numeric Patient ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                 
                    string query = @"SELECT AppointmentID, Doctor_ID, Patient_ID, Symptoms, AppointmentDateTime 
                             FROM Appointment 
                             WHERE Patient_ID = @patientId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@patientId", patientId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                  
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    }
                    else
                    {
                        MessageBox.Show("No appointments found for this Patient ID.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

