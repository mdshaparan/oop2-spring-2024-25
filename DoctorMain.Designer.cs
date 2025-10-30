namespace HMS
{
    partial class DoctorMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Myprofile = new System.Windows.Forms.Button();
            this.doctorPrescriptionUser1 = new HMS.DoctorPrescriptionUser();
            this.doctorUser1 = new HMS.DoctorUser();
            this.patientHistoryUser1 = new HMS.PatientHistoryUser();
            this.doctorDashboard1 = new HMS.DoctorDashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.btn_Myprofile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 742);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(13, 665);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "LOGOUT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(13, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "Dashboard\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(13, 539);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Patient History";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Prescription";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Appointment List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.doctorPrescriptionUser1);
            this.panel2.Controls.Add(this.doctorUser1);
            this.panel2.Controls.Add(this.patientHistoryUser1);
            this.panel2.Controls.Add(this.doctorDashboard1);
            this.panel2.Location = new System.Drawing.Point(181, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1302, 742);
            this.panel2.TabIndex = 1;
            // 
            // btn_Myprofile
            // 
            this.btn_Myprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Myprofile.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Myprofile.Location = new System.Drawing.Point(13, 196);
            this.btn_Myprofile.Name = "btn_Myprofile";
            this.btn_Myprofile.Size = new System.Drawing.Size(144, 54);
            this.btn_Myprofile.TabIndex = 5;
            this.btn_Myprofile.Text = "My Profile";
            this.btn_Myprofile.UseVisualStyleBackColor = true;
            this.btn_Myprofile.Click += new System.EventHandler(this.btn_Myprofile_Click);
            // 
            // doctorPrescriptionUser1
            // 
            this.doctorPrescriptionUser1.BackColor = System.Drawing.Color.Tan;
            this.doctorPrescriptionUser1.Location = new System.Drawing.Point(0, 0);
            this.doctorPrescriptionUser1.Name = "doctorPrescriptionUser1";
            this.doctorPrescriptionUser1.Size = new System.Drawing.Size(1302, 742);
            this.doctorPrescriptionUser1.TabIndex = 3;
            this.doctorPrescriptionUser1.Load += new System.EventHandler(this.doctorPrescriptionUser1_Load);
            // 
            // doctorUser1
            // 
            this.doctorUser1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.doctorUser1.BackColor = System.Drawing.Color.Tan;
            this.doctorUser1.Location = new System.Drawing.Point(0, 0);
            this.doctorUser1.Name = "doctorUser1";
            this.doctorUser1.Size = new System.Drawing.Size(1289, 742);
            this.doctorUser1.TabIndex = 2;
            this.doctorUser1.Load += new System.EventHandler(this.doctorUser1_Load_1);
            // 
            // patientHistoryUser1
            // 
            this.patientHistoryUser1.BackColor = System.Drawing.Color.LightCyan;
            this.patientHistoryUser1.Location = new System.Drawing.Point(0, 3);
            this.patientHistoryUser1.Name = "patientHistoryUser1";
            this.patientHistoryUser1.Size = new System.Drawing.Size(1259, 745);
            this.patientHistoryUser1.TabIndex = 1;
            // 
            // doctorDashboard1
            // 
            this.doctorDashboard1.BackColor = System.Drawing.Color.LightCyan;
            this.doctorDashboard1.Location = new System.Drawing.Point(3, 0);
            this.doctorDashboard1.Name = "doctorDashboard1";
            this.doctorDashboard1.Size = new System.Drawing.Size(1292, 745);
            this.doctorDashboard1.TabIndex = 0;
            // 
            // DoctorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 743);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private PatientHistoryUser patientHistoryUser1;
        private DoctorDashboard doctorDashboard1;
        private DoctorUser doctorUser1;
        private System.Windows.Forms.Label label1;
        private DoctorPrescriptionUser doctorPrescriptionUser1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_Myprofile;
    }
}