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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS
{
    public partial class DoctorPrescriptionUser : UserControl
    {
        DataTable dt9;
        public DoctorPrescriptionUser()
        {
            InitializeComponent();
        }
        public void SetPatientData(DataTable dt1)
        {
            dt9 = dt1;

            if (dt9 != null && dt9.Rows.Count > 0)
            {
                int doctorId = Convert.ToInt32(dt9.Rows[0][0]); 
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (checkedListBox1.CheckedItems.Count == 0 ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please fill in all fields: diagnosis, medications, and patient ID.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dt9 == null || dt9.Rows.Count == 0)
            {
                MessageBox.Show("Doctor data not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            int doctorId = Convert.ToInt32(dt9.Rows[0]["Doctor_ID"]);

          
            if (!int.TryParse(textBox1.Text.Trim(), out int patientId))
            {
                MessageBox.Show("Invalid patient ID. It must be a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
            string selectedDiagnoses = string.Join(", ", checkedListBox1.CheckedItems.Cast<string>());

            string medications = textBox2.Text.Trim();
            string instruct= textBox3.Text.Trim();

            DateTime today = DateTime.Today;

            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO Prescription 
                (Doctor_ID, Patient_ID, Diagnosis, Medicine, Instruction,Date)
                VALUES (@doctorId, @patientId, @diagnosis, @medications,@instruction, @datePrescribed)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    cmd.Parameters.AddWithValue("@diagnosis", selectedDiagnoses);
                    cmd.Parameters.AddWithValue("@medications", medications);
                    cmd.Parameters.AddWithValue("@instruction", instruct);
                    cmd.Parameters.AddWithValue("@datePrescribed", today);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Prescription saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
                    }
                    else
                    {
                        MessageBox.Show("Failed to save prescription.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoctorPrescriptionUser_Load(object sender, EventArgs e)
        {

        }
    }
}
