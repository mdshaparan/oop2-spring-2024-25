using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        string @usern, @pass;

        SqlConnection Conn1 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

            this.Hide();
        }

        private void chkShowpass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = chkShowpass.Checked ? '\0' : '*';
        }

        public bool emptyFields()
        {
            if (txtUname.Text == "" || txtPass.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            string connString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;");

            string username = txtUname.Text.Trim();

            string password = txtPass.Text.Trim();

            using (SqlConnection con = new SqlConnection(connString))

            {

                con.Open();
                if (username == "admin" && password == "admin123")
                {
                    AdminMainForm adminmainform = new AdminMainForm();
                    adminmainform.Show();
                    this.Hide();
                }
                else
                {



                    string doctorQuery = "SELECT * FROM Doctor_Reg WHERE Doctor_Username = '" + txtUname.Text + "' AND Doctor_Password = '" + txtPass.Text + "' ";




                    SqlDataAdapter sda = new SqlDataAdapter(doctorQuery, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        if (dt.Rows[0]["Status"].ToString().Trim().Equals("Active", StringComparison.OrdinalIgnoreCase))
                        {
                            DoctorMain loggedInDoctor = new DoctorMain(dt);
                            loggedInDoctor.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Account isn't active yet. Please wait for admin approval.");
                        }

                    }
                    else
                    {

                        string patientQuery = "SELECT * FROM Patient_Reg WHERE Username = @user AND Password = @pass";
                        SqlDataAdapter sda1 = new SqlDataAdapter(patientQuery, con);


                        sda1.SelectCommand.Parameters.AddWithValue("@user", txtUname.Text.Trim());
                        sda1.SelectCommand.Parameters.AddWithValue("@pass", txtPass.Text.Trim());

                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);

                        if (dt1.Rows.Count == 1)
                        {
                           
                            if (dt1.Rows[0]["Status"].ToString().Trim().Equals("Active", StringComparison.OrdinalIgnoreCase))
                            {
                                PatientMain loggedInPatient = new PatientMain(dt1);
                                loggedInPatient.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Account isn't active yet. Please wait for admin approval.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account doesn't exist or credentials are wrong.");
                        }
                    }
                }
            }
        }
    }
}


                        

