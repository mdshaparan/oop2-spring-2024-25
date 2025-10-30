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
    public partial class makeappointmentuser : UserControl
    {
        DataTable dt9;
        public makeappointmentuser()
        {
            InitializeComponent();
            ShowInfo();
        }
       
        public void SetPatientData(DataTable dt)
        {
            dt9 = dt;

            if (dt9 != null && dt9.Rows.Count > 0)
            {
                int patientId = Convert.ToInt32(dt9.Rows[0][2]); 
            }
        }


        private void symtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowInfo()
        {

            string connectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;");
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT Doctor_ID, Doctor_FullName, Room_no FROM Doctor_Reg WHERE Status = 'Active'";
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

        private void makeappointmentuser_Load(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {


            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    if (string.IsNullOrWhiteSpace(didtxt.Text) || string.IsNullOrWhiteSpace(symtxt.Text))
                    {
                        MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int patientId = Convert.ToInt32(dt9.Rows[0][0]);

                    if (dt9 != null && dt9.Rows.Count > 0)
                    {
                        patientId = Convert.ToInt32(dt9.Rows[0]["Patient_ID"]);
                    }
                    else
                    {
                        MessageBox.Show("Patient data not loaded. Please log in again.");
                        return;
                    }

                    int doctorId = Convert.ToInt32(didtxt.Text);
                    string symptoms = symtxt.Text;
                    DateTime appointmentDate = dateTimePicker1.Value.Date; 

                    string checkQuery = @"SELECT COUNT(*) FROM Appointment 
                              WHERE CAST(AppointmentDateTime AS DATE) = @selectedDate";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@selectedDate", appointmentDate);

                    int appointmentCount = (int)checkCmd.ExecuteScalar();

                    if (appointmentCount >= 10)
                    {
                        MessageBox.Show("Sorry, the maximum of 10 appointments for this day has been reached.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    
                    string insertAppointment = @"INSERT INTO Appointment (Doctor_ID, Patient_ID, Symptoms, AppointmentDateTime,Status)
                                     VALUES (@doctorId, @patientId, @symptoms, @appointmentDate,'Scheduled')";

                    SqlCommand cmd = new SqlCommand(insertAppointment, conn);
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    cmd.Parameters.AddWithValue("@symptoms", symptoms);
                    cmd.Parameters.AddWithValue("@appointmentDate", appointmentDate);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        didtxt.Clear();
                        symtxt.Clear();
                        dateTimePicker1.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Failed to book appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }

      


        private void searchbtn_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;";
            string departmentSearch = searchtxt.Text.Trim();

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

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    
