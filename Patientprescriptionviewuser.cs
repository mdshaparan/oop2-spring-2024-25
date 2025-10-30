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
    public partial class Patientprescriptionviewuser : UserControl
    {
        public Patientprescriptionviewuser()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void ShowInfo()
        {
            string connectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;");
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT \r\n    p.Doctor_ID,\r\n    d.Doctor_FullName AS DoctorName,\r\n\tp.Diagnosis,\r\n    p.Medicine,\r\n\tp.Instruction,\r\n    p.Date\r\nFROM \r\n    Prescription p\r\nINNER JOIN \r\n    Doctor_Reg d ON p.Doctor_ID = d.Doctor_ID;\r\n";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void Patientprescriptionviewuser_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void prescription_btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
