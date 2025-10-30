using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class DoctorMain : Form
    {
        DataTable dt1;
        public DoctorMain()
        {
            InitializeComponent();
           

        }
        public DoctorMain(DataTable dt)
        {
            this.dt1 = dt;
            InitializeComponent();
            doctorDashboard1.Visible = true;
            patientHistoryUser1.Visible = false;
            doctorUser1.Visible = false;
            doctorPrescriptionUser1.Visible = false;
            doctorPrescriptionUser1.SetPatientData(dt1);
            doctorDashboard1.SetDoctorData1(dt1);

           LoadDoctorInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doctorDashboard1.Visible = false;
            patientHistoryUser1.Visible = true;
            doctorUser1.Visible = false;
            doctorPrescriptionUser1.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            doctorDashboard1.Visible = false;
            patientHistoryUser1.Visible = false;
            doctorUser1.Visible = true;
            doctorPrescriptionUser1.Visible = false;
        }

        private void doctorUser1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            doctorDashboard1.Visible = true;
           patientHistoryUser1.Visible = false; 
            doctorUser1.Visible = false;
            doctorPrescriptionUser1.Visible = false;
           
        }

        private void doctorDashboard1_Load(object sender, EventArgs e)
        {

        }
        private void LoadDoctorInfo()
        {
            if (dt1 != null && dt1.Rows.Count > 0)
            {
              
                string value = dt1.Rows[0][1].ToString();

            

                label1.Text = "" + value;
            }
            else
            {
                label1.Text = "No data found.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void doctorUser1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // DoctorPrescriptionUser1.Visible = true;
            doctorPrescriptionUser1.SetPatientData(dt1);
            doctorDashboard1.Visible = false;
            patientHistoryUser1.Visible = false;
            doctorUser1.Visible = false;
            doctorPrescriptionUser1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult chcek = MessageBox.Show("Are you sure you want to logout?", "Confermation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (chcek == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();


            }
        }

        private void btn_Myprofile_Click(object sender, EventArgs e)
        {
            if (dt1 != null)
            {
                DoctorMyProfile profileForm = new DoctorMyProfile(dt1);
                profileForm.Show();
            }
            else
            {
                MessageBox.Show("Doctor data not loaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //DoctorMyProfile doctorMyProfile = new DoctorMyProfile(dt1);
            //doctorMyProfile.Show();
            //this.Show();

        }

        private void doctorPrescriptionUser1_Load(object sender, EventArgs e)
        {

        }
    }
    }

