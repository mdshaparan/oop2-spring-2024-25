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
    public partial class PatientMain : Form
    {
        DataTable dt;
        public PatientMain()
        {
            InitializeComponent();
           

        }
        public PatientMain(DataTable dt)
        {
            this.dt = dt;
            InitializeComponent();
            makeappointmentuser1.Visible = false;
            patientdoctorviewuser1.Visible = false;
            patientdashboarduser1.Visible = true;
            patientprescriptionviewuser1.Visible = false;
            patientabout1.Visible = false;
            patienthelp1.Visible = false;
            makeappointmentuser1.SetPatientData(dt);
        }
 

        private void PatientMain_Load(object sender, EventArgs e)
        {

        }

        private void mkappointbtn_Click(object sender, EventArgs e)
        {
            makeappointmentuser1.SetPatientData(dt); // ensure always set
            makeappointmentuser1.Visible = true;
            patientdashboarduser1.Visible = false;
            patientdoctorviewuser1.Visible = false;
            patientprescriptionviewuser1.Visible = false;
            patientabout1.Visible = false;
            patienthelp1.Visible = false;
            //makeappointmentuser1.Visible = true;
            //makeappointmentuser bb=new makeappointmentuser(dt);
            //bb.Show();
            //patientdoctorviewuser1.Visible = false;
            //patientdashboarduser1.Visible = false;
            //patientprescriptionviewuser1.Visible = false;
            //makeappointmentuser(dt);

        }

        private void doctorbtn_Click(object sender, EventArgs e)
        {
            patientdoctorviewuser1.Visible = true;
            makeappointmentuser1.Visible = false;
            patientdashboarduser1.Visible = false;
            patientprescriptionviewuser1.Visible = false;
            patientabout1.Visible = false;
            patienthelp1.Visible = false;


        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            makeappointmentuser1.Visible = false;
            patientdoctorviewuser1.Visible = false;
            patientdashboarduser1.Visible = true;
            patientprescriptionviewuser1.Visible = false;
            patientabout1.Visible = false;
            patienthelp1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            makeappointmentuser1.Visible = false;
            patientdoctorviewuser1.Visible = false;
            patientdashboarduser1.Visible = false;
            patientprescriptionviewuser1.Visible = true;
            patientabout1.Visible = false;
            patienthelp1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult chcek = MessageBox.Show("Are you sure you want to logout?", "Confermation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (chcek == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();


            }
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {

            makeappointmentuser1.Visible = false;
            patientdoctorviewuser1.Visible = false;
            patientdashboarduser1.Visible = false;
            patientprescriptionviewuser1.Visible = false;
            patientabout1.Visible = true;
            patienthelp1.Visible = false;

        }

        private void helpbtn_Click(object sender, EventArgs e)
        {
            makeappointmentuser1.Visible = false;
            patientdoctorviewuser1.Visible = false;
            patientdashboarduser1.Visible = false;
            patientprescriptionviewuser1.Visible = false;
            patientabout1.Visible = false;
            patienthelp1.Visible = true;

        }
    }
    }

