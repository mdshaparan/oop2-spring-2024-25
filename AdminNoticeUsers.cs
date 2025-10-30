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
    public partial class AdminNoticeUsers : UserControl
    {
        public AdminNoticeUsers()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtAdmin_DoctorId.Text) || string.IsNullOrWhiteSpace(txtAdmin_Message.Text))
            {
                MessageBox.Show("Please enter both Doctor ID and Message.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAdmin_DoctorId.Text.Trim(), out int doctorId))
            {
                MessageBox.Show("Doctor ID must be a valid number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Notice (Doctor_ID, Message, Issue_Date) VALUES (@DoctorID, @Message, @Date)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                        cmd.Parameters.AddWithValue("@Message", txtAdmin_Message.Text.Trim());
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Notice sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtAdmin_DoctorId.Clear();
                        txtAdmin_Message.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending notice: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

