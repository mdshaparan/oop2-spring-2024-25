using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{

    public partial class PatientRegisterForm : Form
    {
        SqlConnection Conn1 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;");
        PatientUser P1;
        private AdminDashboardForm dashboardForm;

        public PatientRegisterForm(AdminDashboardForm dashboardForm)
        {
            InitializeComponent();
            this.dashboardForm = dashboardForm;
        }

        public PatientRegisterForm()
        {
            InitializeComponent();
            
        }
        public PatientRegisterForm(PatientUser P1)
        {
            InitializeComponent();
            this.P1 = P1;
        }

        private void PatientRegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPSubmit_Click(object sender, EventArgs e)
        {
            if (Conn1.State == ConnectionState.Closed)
            {
                // --- Input Validation Start ---
                string fullName = txtPatient_RegisterFullname.Text.Trim();
                string ageText = txtPatient_RegisterAge.Text.Trim();
                string username = P1.Username?.Trim();
                string password = P1.Password;
                string bloodGroup = comPatient_RegisterBloodgroup.Text.Trim();
                string contact = txtPatient_RegisterContact.Text.Trim();
                string address = txtPatient_RegisterAddress.Text.Trim();
                string gender = rbPatient_RegisterMale.Checked ? "Male" : rbPatient_RegisterFemale.Checked ? "Female" : "";

                // Check for empty required fields
                if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(ageText) || string.IsNullOrWhiteSpace(username) ||
                    string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(bloodGroup) || string.IsNullOrWhiteSpace(contact) ||
                    string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(gender))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Age validation (must be integer and reasonable)
                if (!int.TryParse(ageText, out int age) || age < 0 || age > 120)
                {
                    MessageBox.Show("Please enter a valid age (0-120).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Username validation: lowercase only and max 14 characters
                if (username.Any(char.IsUpper) || username.Length > 14)
                {
                    MessageBox.Show("Username must be all lowercase and not more than 14 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Contact number validation: must be exactly 11 digits and numeric
                if (contact.Length != 11 || !contact.All(char.IsDigit))
                {
                    MessageBox.Show("Contact number must be exactly 11 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Password check
                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // --- Validation Passed: Now insert into database ---
                try
                {
                    Conn1.Open();

                    string insertPatient = "INSERT INTO Patient_Reg " +
                        "(FullName, Age, Username, Password, Gender, Blood_Group, Contact, Address, Status) " +
                        "VALUES (@fullname, @age, @username, @password, @gender, @bloodgroup, @contact, @address, 'Approval')";

                    SqlCommand cmd = new SqlCommand(insertPatient, Conn1);
                    cmd.Parameters.AddWithValue("@fullname", fullName);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@bloodgroup", bloodGroup);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@address", address);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Patient registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                    Form1 loginForm = new Form1();
                    loginForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Registration failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Conn1.Close();
                }
            }
        }
    }
}

