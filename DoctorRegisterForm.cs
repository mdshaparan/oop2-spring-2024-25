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
    public partial class DoctorRegisterForm : Form
    {
        SqlConnection Conn1 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;");
        DocUser D1;
        private AdminDashboardForm dashboardForm;

        public DoctorRegisterForm(AdminDashboardForm dashboardForm)
        {
            InitializeComponent();
            this.dashboardForm = dashboardForm;
        }

        public DoctorRegisterForm()
        {
            InitializeComponent();
        }

        public DoctorRegisterForm(DocUser D1)
        {
            InitializeComponent();
            this.D1 = D1;
        }

        private void txtDoctor_RegisterFullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Conn1.State == ConnectionState.Closed)
            {
                try
                {
                    Conn1.Open();

                    string insertDoctor = "INSERT INTO Doctor_Reg " +
                        "(Doctor_FullName, Doctor_Username, Doctor_Password, Contact_no, Department, Room_no, Status) " +
                        "VALUES (@fullname, @username, @password, @contact, @department, 0 , 'Approval')";

                    SqlCommand cmd = new SqlCommand(insertDoctor, Conn1);
                    cmd.Parameters.AddWithValue("@fullname", txtDoctor_RegisterFullname.Text.Trim());
                    cmd.Parameters.AddWithValue("@username", D1.Username);
                    cmd.Parameters.AddWithValue("@password", D1.Password);
                    cmd.Parameters.AddWithValue("@contact", txtDoctor_RegisterContact.Text.Trim());
                    cmd.Parameters.AddWithValue("@department", comDoctor_RegisterDepartment.Text.Trim());
                   
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Doctor Registered Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                    this.Hide();
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
        }

        private void DoctorRegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
