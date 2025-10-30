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
    public partial class DoctorMyProfile : Form
    {
        DataTable dt9;
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;";
        int selectedDoctorId = -1;

        public DoctorMyProfile()
        {
            InitializeComponent();
           

        }
        public DoctorMyProfile(DataTable dt1)
        {
            InitializeComponent();
            this.dt9 = dt1;

            if (dt9 != null && dt9.Rows.Count > 0)
            {
                int doctorId = Convert.ToInt32(dt9.Rows[0]["Doctor_ID"]);
                LoadMyProfileData(doctorId);
            }
        }

        private void LoadMyProfileData(int doctorId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Doctor_Reg WHERE Doctor_ID = @doctorId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedDoctorId = Convert.ToInt32(row.Cells["Doctor_ID"].Value);
                txt_Fullname.Text = row.Cells["Doctor_FullName"].Value.ToString();
                txt_Pass.Text = row.Cells["Doctor_Password"].Value.ToString();
                txt_Contact.Text = row.Cells["Contact_no"].Value.ToString();
                txt_Department.Text = row.Cells["Department"].Value.ToString();
               
            }

        }

      

        private void label5_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
