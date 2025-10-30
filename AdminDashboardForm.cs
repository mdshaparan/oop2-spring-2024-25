using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class AdminDashboardForm : UserControl
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            LoadDoctorCount();
            LoadPatientCount();
           
        }





        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void LoadDoctorCount()
        {


            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Doctor_Reg";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    int totalDoctors = (int)cmd.ExecuteScalar();

                    lbl_Totaldoctors.Text = totalDoctors.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading doctor count: " + ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void LoadPatientCount()
        {


            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Patient_Reg";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    int totalDoctors = (int)cmd.ExecuteScalar();

                    lbl_TotalPatient.Text = totalDoctors.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Patient count: " + ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
