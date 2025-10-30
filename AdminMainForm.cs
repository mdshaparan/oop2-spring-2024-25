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
    public partial class AdminMainForm : Form
    {
        
        public AdminMainForm()
        {
            InitializeComponent();
            adminDashboardForm1.Visible = true;
            adminAddUsers1.Visible = false;
           adminAddStaff1.Visible = false;
            adminAppoinmentView1.Visible = false;
            adminNoticeUsers1.Visible = false;


        }
        

        private void adminAddUsers1_Load(object sender, EventArgs e)
        {

        }

        private void Register_close_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?","Confermation Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult chcek = MessageBox.Show("Are you sure you want to logout?", "Confermation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (chcek == DialogResult.Yes) 
            { 
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();


            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = true;
            adminAddUsers1.Visible = false;
            adminAddStaff1.Visible = false;
            adminAppoinmentView1.Visible = false;
            adminNoticeUsers1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
           adminAddStaff1.Visible = true;
            adminAppoinmentView1.Visible = false;
            adminNoticeUsers1.Visible = false;

        }

        private void btnAdd_users_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = true;
          adminAddStaff1.Visible = false;
            adminAppoinmentView1.Visible = false;
            adminNoticeUsers1.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminAppoinmentView1.Visible = true;
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddStaff1.Visible = false;
            adminNoticeUsers1.Visible = false;
            adminNoticeUsers1.Visible = false;

        }

        private void adminAppoinmentView1_Load(object sender, EventArgs e)
        {

        }

        private void btn_AdminMian_Notice_Click(object sender, EventArgs e)
        {

            adminAppoinmentView1.Visible = false;
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddStaff1.Visible = false;
            adminNoticeUsers1.Visible = true;
        }

        private void adminNoticeUsers1_Load(object sender, EventArgs e)
        {

        }
    }
}
