using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HMS
{
    public partial class RegisterForm : Form
    {
        SqlConnection Conn1 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Register_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_signin_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();

        }

        private void Register_Showpass2_CheckedChanged(object sender, EventArgs e)
        {
            txtRegister_Pass.PasswordChar = Register_Showpass2.Checked ? '\0' : '*';
            textRegister_cPass.PasswordChar = Register_Showpass2.Checked ? '\0' : '*';
        }
        public bool emptyFields()
        {
            if (txtRegister_Uname.Text == "" || txtRegister_Pass.Text == "" || textRegister_cPass.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            
           
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string username = txtRegister_Uname.Text.Trim();

            if (!System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-z0-9]{1,14}$"))
            {
                MessageBox.Show("Username must contain only lowercase letters and digits, and be no more than 14 characters.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = txtRegister_Pass.Text;
            string confirmPassword = textRegister_cPass.Text;

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (!rbRegister_Doctor.Checked && !rbRegister_Patient.Checked )
            {
                MessageBox.Show("Please select a role (Doctor, Patient, or Admin).", "Missing Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            
            if (Conn1.State == ConnectionState.Closed)
            {
                try
                {
                    Conn1.Open();

                  
                    string checkDoctorQuery = "SELECT * FROM Doctor_Reg WHERE Doctor_Username = @usern";
                    string checkPatientQuery = "SELECT * FROM Patient_Reg WHERE Username = @usern";

;
                    SqlCommand cmdDoctor = new SqlCommand(checkDoctorQuery, Conn1);
                    SqlCommand cmdPatient = new SqlCommand(checkPatientQuery, Conn1);

                   
                    cmdDoctor.Parameters.AddWithValue("@usern", username);
                    cmdPatient.Parameters.AddWithValue("@usern", username);

                    bool userExists = false;

                 
               

                    if (!userExists)
                    {
                        using (SqlDataReader reader2 = cmdDoctor.ExecuteReader())
                        {
                            userExists = reader2.HasRows;
                        }
                    }

                    if (!userExists)
                    {
                        using (SqlDataReader reader3 = cmdPatient.ExecuteReader())
                        {
                            userExists = reader3.HasRows;
                        }
                    }

                    if (userExists)
                    {
                        MessageBox.Show("Username already exists in the system (Users, Doctors, or Patients).", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                  
                    if (rbRegister_Doctor.Checked)
                    {
                        DocUser D1 = new DocUser(null, 0, username, password, 0, null, 0, 0);
                        DoctorRegisterForm DRF1 = new DoctorRegisterForm(D1);
                        DRF1.Show();
                    }
                    else if (rbRegister_Patient.Checked)
                    {
                        PatientUser P1 = new PatientUser(null, 0, username, password, 0, 0, null, null, null);
                        PatientRegisterForm PRF1 = new PatientRegisterForm(P1);
                        PRF1.Show();
                    }
                   

                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Conn1.Close();
                }
            }
        }

        private void textRegister_cPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
            
  
