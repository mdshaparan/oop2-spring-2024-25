namespace HMS
{
    partial class AdminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd_users = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_AdminMian_Notice = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminNoticeUsers1 = new HMS.AdminNoticeUsers();
            this.adminAddStaff1 = new HMS.AdminAddStaff();
            this.adminAppoinmentView1 = new HMS.AdminAppoinmentView();
            this.adminDashboardForm1 = new HMS.AdminDashboardForm();
            this.adminAddUsers1 = new HMS.AdminAddUsers();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 45);
            this.panel1.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.Crimson;
            this.Close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(1462, 8);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(26, 27);
            this.Close.TabIndex = 14;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.btnAdd_users);
            this.panel2.Controls.Add(this.btn_Logout);
            this.panel2.Controls.Add(this.btn_AdminMian_Notice);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 745);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAdd_users
            // 
            this.btnAdd_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_users.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_users.ForeColor = System.Drawing.Color.White;
            this.btnAdd_users.Location = new System.Drawing.Point(40, 282);
            this.btnAdd_users.Name = "btnAdd_users";
            this.btnAdd_users.Size = new System.Drawing.Size(145, 41);
            this.btnAdd_users.TabIndex = 24;
            this.btnAdd_users.Text = "Users";
            this.btnAdd_users.UseVisualStyleBackColor = true;
            this.btnAdd_users.Click += new System.EventHandler(this.btnAdd_users_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Logout.Location = new System.Drawing.Point(61, 696);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(116, 37);
            this.btn_Logout.TabIndex = 23;
            this.btn_Logout.Text = "LOGOUT";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_AdminMian_Notice
            // 
            this.btn_AdminMian_Notice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdminMian_Notice.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminMian_Notice.ForeColor = System.Drawing.Color.White;
            this.btn_AdminMian_Notice.Location = new System.Drawing.Point(40, 531);
            this.btn_AdminMian_Notice.Name = "btn_AdminMian_Notice";
            this.btn_AdminMian_Notice.Size = new System.Drawing.Size(145, 41);
            this.btn_AdminMian_Notice.TabIndex = 22;
            this.btn_AdminMian_Notice.Text = "Notice";
            this.btn_AdminMian_Notice.UseVisualStyleBackColor = true;
            this.btn_AdminMian_Notice.Click += new System.EventHandler(this.btn_AdminMian_Notice_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(40, 438);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 60);
            this.button5.TabIndex = 21;
            this.button5.Text = "Appoinment\r\n List";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(40, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 63);
            this.button4.TabIndex = 20;
            this.button4.Text = "Stuff Management";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(40, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "User: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Admin\'s Portal";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminNoticeUsers1);
            this.panel3.Controls.Add(this.adminAddStaff1);
            this.panel3.Controls.Add(this.adminAppoinmentView1);
            this.panel3.Controls.Add(this.adminDashboardForm1);
            this.panel3.Controls.Add(this.adminAddUsers1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(241, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1259, 745);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.image_2;
            this.pictureBox1.Location = new System.Drawing.Point(61, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 86);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // adminNoticeUsers1
            // 
            this.adminNoticeUsers1.BackColor = System.Drawing.Color.LightCyan;
            this.adminNoticeUsers1.Location = new System.Drawing.Point(0, 0);
            this.adminNoticeUsers1.Name = "adminNoticeUsers1";
            this.adminNoticeUsers1.Size = new System.Drawing.Size(1259, 745);
            this.adminNoticeUsers1.TabIndex = 5;
            this.adminNoticeUsers1.Load += new System.EventHandler(this.adminNoticeUsers1_Load);
            // 
            // adminAddStaff1
            // 
            this.adminAddStaff1.BackColor = System.Drawing.Color.LightCyan;
            this.adminAddStaff1.Location = new System.Drawing.Point(0, 0);
            this.adminAddStaff1.Name = "adminAddStaff1";
            this.adminAddStaff1.Size = new System.Drawing.Size(1259, 745);
            this.adminAddStaff1.TabIndex = 4;
            // 
            // adminAppoinmentView1
            // 
            this.adminAppoinmentView1.BackColor = System.Drawing.Color.LightCyan;
            this.adminAppoinmentView1.Location = new System.Drawing.Point(0, 0);
            this.adminAppoinmentView1.Name = "adminAppoinmentView1";
            this.adminAppoinmentView1.Size = new System.Drawing.Size(1259, 745);
            this.adminAppoinmentView1.TabIndex = 3;
            this.adminAppoinmentView1.Load += new System.EventHandler(this.adminAppoinmentView1_Load);
            // 
            // adminDashboardForm1
            // 
            this.adminDashboardForm1.BackColor = System.Drawing.Color.LightCyan;
            this.adminDashboardForm1.Location = new System.Drawing.Point(0, 3);
            this.adminDashboardForm1.Name = "adminDashboardForm1";
            this.adminDashboardForm1.Size = new System.Drawing.Size(1259, 745);
            this.adminDashboardForm1.TabIndex = 2;
            // 
            // adminAddUsers1
            // 
            this.adminAddUsers1.BackColor = System.Drawing.Color.LightCyan;
            this.adminAddUsers1.Location = new System.Drawing.Point(0, 3);
            this.adminAddUsers1.Name = "adminAddUsers1";
            this.adminAddUsers1.Size = new System.Drawing.Size(1259, 745);
            this.adminAddUsers1.TabIndex = 0;
            this.adminAddUsers1.Load += new System.EventHandler(this.adminAddUsers1_Load);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 790);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_AdminMian_Notice;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private AdminAddUsers adminAddUsers1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Button btnAdd_users;
        private AdminAppoinmentView adminAppoinmentView1;
        private AdminDashboardForm adminDashboardForm1;
        private AdminAddStaff adminAddStaff1;
        private AdminNoticeUsers adminNoticeUsers1;
    }
}