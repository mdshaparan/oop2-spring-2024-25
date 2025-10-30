using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace HMS
{
    public partial class AdminAddUsers : UserControl
    {
        SqlConnection Conn1 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;");
        private int Id = 0;
        private int PatientId = 0;
      
        public AdminAddUsers()
        {
            InitializeComponent();

            DisplayDoctorData();
            DisplayPatientData();

        }
        private void DisplayDoctorData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Doctor_Reg", Conn1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void DisplayPatientData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Patient_Reg", Conn1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public bool emptyFields()
        {
            if (AdminAddUsers_Fullname.Text == "" || AdminAddUsers_Username.Text == ""
                || comAdminAddUsers_status.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AdminAddUsers_updatebtn_Click(object sender, EventArgs e)
        {
            if ((Id == 0 && PatientId == 0) || emptyFields())
            {
                MessageBox.Show("Please select a doctor or patient to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Conn1.Open();
                SqlCommand cmd;

                if (Id != 0)
                {
                    cmd = new SqlCommand("UPDATE Doctor_Reg SET Doctor_FullName = @fullname, Doctor_Username = @username, Contact_no = @contact, Room_no = @room, Status = @status WHERE Doctor_ID = @id", Conn1);
                    cmd.Parameters.AddWithValue("@fullname", AdminAddUsers_Fullname.Text);
                    cmd.Parameters.AddWithValue("@username", AdminAddUsers_Username.Text);
                    cmd.Parameters.AddWithValue("@contact", AdminAddUsers_Contact.Text);
                    cmd.Parameters.AddWithValue("@room", int.TryParse(AdminAddUsers_Room.Text, out int room) ? room : 0);
                    cmd.Parameters.AddWithValue("@status", comAdminAddUsers_status.Text);
                    cmd.Parameters.AddWithValue("@id", Id);
                }
                else
                {
                    cmd = new SqlCommand("UPDATE Patient_Reg SET FullName = @fullname, Username = @username, Contact = @contact, Status = @status WHERE Patient_ID = @id", Conn1);
                    cmd.Parameters.AddWithValue("@fullname", AdminAddUsers_Fullname.Text);
                    cmd.Parameters.AddWithValue("@username", AdminAddUsers_Username.Text);
                    cmd.Parameters.AddWithValue("@contact", AdminAddUsers_Contact.Text);
                    cmd.Parameters.AddWithValue("@status", comAdminAddUsers_status.Text);
                    cmd.Parameters.AddWithValue("@id", PatientId);
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (Id != 0) DisplayDoctorData();
                else DisplayPatientData();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Conn1.Close();
            }
        }

       
        private void AdminAddUsers_clearbtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            AdminAddUsers_Fullname.Text = "";
            AdminAddUsers_Username.Text = "";
            AdminAddUsers_Contact.Text = "";
            AdminAddUsers_Room.Text = "";
            comAdminAddUsers_status.SelectedIndex = -1;
            Id = 0;
            PatientId = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                AdminAddUsers_Fullname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                AdminAddUsers_Username.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                AdminAddUsers_Contact.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                AdminAddUsers_Room.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                comAdminAddUsers_status.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PatientId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
                AdminAddUsers_Fullname.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                AdminAddUsers_Username.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                AdminAddUsers_Contact.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
                comAdminAddUsers_status.Text = dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

    }
}

