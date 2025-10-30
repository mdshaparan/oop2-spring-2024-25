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
    public partial class AdminAddStaff : UserControl
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;";
        int selectedStaffId = -1;

        public AdminAddStaff()
        {
            InitializeComponent();
            btn_StaffUpdate.Click += new EventHandler(btn_StaffUpdate_Click);
            btn_StaffDelete.Click += new EventHandler(btn_StaffDelete_Click);
            btn_StaffClear.Click += new EventHandler(btn_StaffClear_Click);

            
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            LoadStaffData();
        }

        private void btn_StaffAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = rb_StaffMale.Checked ? "Male" : rb_StaffFemale.Checked ? "Female" : "";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Staff (FullName, Email, Username, Gender, Blood_Group, Role, Department, Contact, Address, Status,Reg_Date) " +
                                   "VALUES (@FullName, @Email, @Username, @Gender, @Blood_Group, @Role, @Department, @Contact, @Address, @Status,@reg_date)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txt_StaffFullname.Text);
                        cmd.Parameters.AddWithValue("@Email", txt_StaffEmail.Text);
                        cmd.Parameters.AddWithValue("@Username", txt_StaffUsername.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Blood_Group", com_StaffBloodgroup.Text);
                        cmd.Parameters.AddWithValue("@Role", com_StaffRole.Text);
                        cmd.Parameters.AddWithValue("@Department", com_StaffDepartment.Text);
                        cmd.Parameters.AddWithValue("@Contact", txt_StaffContact.Text);
                        cmd.Parameters.AddWithValue("@Address", txt_StaffAddress.Text);
                        cmd.Parameters.AddWithValue("@Status", com_StaffStatus.Text);
                        cmd.Parameters.AddWithValue("@reg_date", DateTime.Now);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Staff added successfully!");
                        LoadStaffData();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Error: " + ex.Message);
            }
        }

        private void btn_StaffUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == -1)
            {
                MessageBox.Show("Please select a staff from the table to update.");
                return;
            }

            try
            {
                string gender = rb_StaffMale.Checked ? "Male" : rb_StaffFemale.Checked ? "Female" : "";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Staff SET FullName=@FullName, Email=@Email, Username=@Username, Gender=@Gender, Blood_Group=@Blood_Group, " +
                                   "Role=@Role, Department=@Department, Contact=@Contact, Address=@Address, Status=@Status,Reg_Date = @reg_date WHERE Staff_ID=@Staff_ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txt_StaffFullname.Text);
                        cmd.Parameters.AddWithValue("@Email", txt_StaffEmail.Text);
                        cmd.Parameters.AddWithValue("@Username", txt_StaffUsername.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Blood_Group", com_StaffBloodgroup.Text);
                        cmd.Parameters.AddWithValue("@Role", com_StaffRole.Text);
                        cmd.Parameters.AddWithValue("@Department", com_StaffDepartment.Text);
                        cmd.Parameters.AddWithValue("@Contact", txt_StaffContact.Text);
                        cmd.Parameters.AddWithValue("@Address", txt_StaffAddress.Text);
                        cmd.Parameters.AddWithValue("@Status", com_StaffStatus.Text);
                        cmd.Parameters.AddWithValue("@Staff_ID", selectedStaffId);
                        cmd.Parameters.AddWithValue("@reg_date", DateTime.Now);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Staff updated successfully!");
                        LoadStaffData();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message);
            }
        }
        private int selectedStaff_Id = -1;

        private void btn_StaffDelete_Click(object sender, EventArgs e)
        {
            if (selectedStaff_Id == -1)
            {
                MessageBox.Show("Please select a staff from the table to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this staff record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Staff WHERE Staff_ID = @Staff_ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Staff_ID", selectedStaffId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStaffData();   
                            ClearFields();     
                            selectedStaffId = -1;  
                        }
                        else
                        {
                            MessageBox.Show("Delete failed. Staff record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_StaffClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txt_StaffFullname.Clear();
            txt_StaffEmail.Clear();
            txt_StaffUsername.Clear();
            txt_StaffContact.Clear();
            txt_StaffAddress.Clear();
            com_StaffBloodgroup.SelectedIndex = -1;
            com_StaffRole.SelectedIndex = -1;
            com_StaffDepartment.SelectedIndex = -1;
            com_StaffStatus.SelectedIndex = -1;
            rb_StaffMale.Checked = false;
            rb_StaffFemale.Checked = false;
            selectedStaffId = -1;
        }

        private void LoadStaffData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Staff";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedStaffId = Convert.ToInt32(row.Cells["Staff_ID"].Value);
                txt_StaffFullname.Text = row.Cells["FullName"].Value.ToString();
                txt_StaffEmail.Text = row.Cells["Email"].Value.ToString();
                txt_StaffUsername.Text = row.Cells["Username"].Value.ToString();
                txt_StaffContact.Text = row.Cells["Contact"].Value.ToString();
                txt_StaffAddress.Text = row.Cells["Address"].Value.ToString();
                com_StaffBloodgroup.Text = row.Cells["Blood_Group"].Value.ToString();
                com_StaffRole.Text = row.Cells["Role"].Value.ToString();
                com_StaffDepartment.Text = row.Cells["Department"].Value.ToString();
                com_StaffStatus.Text = row.Cells["Status"].Value.ToString();

                string gender = row.Cells["Gender"].Value.ToString();
                if (gender == "Male")
                    rb_StaffMale.Checked = true;
                else if (gender == "Female")
                    rb_StaffFemale.Checked = true;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

    }
}