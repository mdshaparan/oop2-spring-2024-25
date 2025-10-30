namespace HMS
{
    partial class PatientMain
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
            this.homebtn = new System.Windows.Forms.Button();
            this.doctorbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mkappointbtn = new System.Windows.Forms.Button();
            this.helpbtn = new System.Windows.Forms.Button();
            this.aboutbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.patientabout1 = new HMS.Patientabout();
            this.patientprescriptionviewuser1 = new HMS.Patientprescriptionviewuser();
            this.patientdashboarduser1 = new HMS.Patientdashboarduser();
            this.patientdoctorviewuser1 = new HMS.Patientdoctorviewuser();
            this.makeappointmentuser1 = new HMS.makeappointmentuser();
            this.patienthelp1 = new HMS.Patienthelp();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.aboutbtn);
            this.panel1.Controls.Add(this.helpbtn);
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Controls.Add(this.doctorbtn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.mkappointbtn);
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 783);
            this.panel1.TabIndex = 1;
            // 
            // homebtn
            // 
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.Location = new System.Drawing.Point(15, 115);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(163, 55);
            this.homebtn.TabIndex = 3;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // doctorbtn
            // 
            this.doctorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorbtn.Location = new System.Drawing.Point(15, 380);
            this.doctorbtn.Name = "doctorbtn";
            this.doctorbtn.Size = new System.Drawing.Size(163, 55);
            this.doctorbtn.TabIndex = 2;
            this.doctorbtn.Text = "Doctor";
            this.doctorbtn.UseVisualStyleBackColor = true;
            this.doctorbtn.Click += new System.EventHandler(this.doctorbtn_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Prescription";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mkappointbtn
            // 
            this.mkappointbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mkappointbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkappointbtn.Location = new System.Drawing.Point(15, 204);
            this.mkappointbtn.Name = "mkappointbtn";
            this.mkappointbtn.Size = new System.Drawing.Size(163, 55);
            this.mkappointbtn.TabIndex = 0;
            this.mkappointbtn.Text = "Make Appointment";
            this.mkappointbtn.UseVisualStyleBackColor = true;
            this.mkappointbtn.Click += new System.EventHandler(this.mkappointbtn_Click);
            // 
            // helpbtn
            // 
            this.helpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpbtn.Location = new System.Drawing.Point(15, 463);
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Size = new System.Drawing.Size(163, 55);
            this.helpbtn.TabIndex = 4;
            this.helpbtn.Text = "Help";
            this.helpbtn.UseVisualStyleBackColor = true;
            this.helpbtn.Click += new System.EventHandler(this.helpbtn_Click);
            // 
            // aboutbtn
            // 
            this.aboutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutbtn.Location = new System.Drawing.Point(15, 551);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(163, 55);
            this.aboutbtn.TabIndex = 6;
            this.aboutbtn.Text = "About";
            this.aboutbtn.UseVisualStyleBackColor = true;
            this.aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.patienthelp1);
            this.panel2.Controls.Add(this.patientabout1);
            this.panel2.Controls.Add(this.patientprescriptionviewuser1);
            this.panel2.Controls.Add(this.patientdashboarduser1);
            this.panel2.Controls.Add(this.patientdoctorviewuser1);
            this.panel2.Controls.Add(this.makeappointmentuser1);
            this.panel2.Location = new System.Drawing.Point(202, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1314, 776);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(0, 736);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // patientabout1
            // 
            this.patientabout1.BackColor = System.Drawing.Color.Tan;
            this.patientabout1.Location = new System.Drawing.Point(0, 3);
            this.patientabout1.Name = "patientabout1";
            this.patientabout1.Size = new System.Drawing.Size(1298, 776);
            this.patientabout1.TabIndex = 4;
            // 
            // patientprescriptionviewuser1
            // 
            this.patientprescriptionviewuser1.BackColor = System.Drawing.Color.Tan;
            this.patientprescriptionviewuser1.Location = new System.Drawing.Point(0, 3);
            this.patientprescriptionviewuser1.Name = "patientprescriptionviewuser1";
            this.patientprescriptionviewuser1.Size = new System.Drawing.Size(1314, 776);
            this.patientprescriptionviewuser1.TabIndex = 3;
            // 
            // patientdashboarduser1
            // 
            this.patientdashboarduser1.BackColor = System.Drawing.Color.Tan;
            this.patientdashboarduser1.Location = new System.Drawing.Point(3, 3);
            this.patientdashboarduser1.Name = "patientdashboarduser1";
            this.patientdashboarduser1.Size = new System.Drawing.Size(1314, 776);
            this.patientdashboarduser1.TabIndex = 2;
            // 
            // patientdoctorviewuser1
            // 
            this.patientdoctorviewuser1.BackColor = System.Drawing.Color.Tan;
            this.patientdoctorviewuser1.Location = new System.Drawing.Point(3, 3);
            this.patientdoctorviewuser1.Name = "patientdoctorviewuser1";
            this.patientdoctorviewuser1.Size = new System.Drawing.Size(1314, 776);
            this.patientdoctorviewuser1.TabIndex = 1;
            // 
            // makeappointmentuser1
            // 
            this.makeappointmentuser1.BackColor = System.Drawing.Color.Tan;
            this.makeappointmentuser1.Location = new System.Drawing.Point(3, 9);
            this.makeappointmentuser1.Name = "makeappointmentuser1";
            this.makeappointmentuser1.Size = new System.Drawing.Size(1311, 770);
            this.makeappointmentuser1.TabIndex = 0;
            // 
            // patienthelp1
            // 
            this.patienthelp1.BackColor = System.Drawing.Color.Tan;
            this.patienthelp1.Location = new System.Drawing.Point(0, 0);
            this.patienthelp1.Name = "patienthelp1";
            this.patienthelp1.Size = new System.Drawing.Size(1314, 776);
            this.patienthelp1.TabIndex = 5;
            // 
            // PatientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 790);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientMain";
            this.Load += new System.EventHandler(this.PatientMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button aboutbtn;
        private System.Windows.Forms.Button helpbtn;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button doctorbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button mkappointbtn;
        private System.Windows.Forms.Panel panel2;
        private makeappointmentuser makeappointmentuser1;
        private Patientdoctorviewuser patientdoctorviewuser1;
        private Patientdashboarduser patientdashboarduser1;
        private Patientprescriptionviewuser patientprescriptionviewuser1;
        private System.Windows.Forms.Button button1;
        private Patientabout patientabout1;
        private Patienthelp patienthelp1;
    }
}