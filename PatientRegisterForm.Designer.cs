namespace HMS
{
    partial class PatientRegisterForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.comPatient_RegisterBloodgroup = new System.Windows.Forms.ComboBox();
            this.txtPatient_RegisterFullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatient_RegisterAge = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUname = new System.Windows.Forms.Label();
            this.rbPatient_RegisterMale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPatient_RegisterFemale = new System.Windows.Forms.RadioButton();
            this.txtPatient_RegisterContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatient_RegisterAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 750);
            this.panel2.TabIndex = 16;
            // 
            // comPatient_RegisterBloodgroup
            // 
            this.comPatient_RegisterBloodgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPatient_RegisterBloodgroup.FormattingEnabled = true;
            this.comPatient_RegisterBloodgroup.Items.AddRange(new object[] {
            "O+",
            "O-",
            "AB+",
            "AB-",
            "B+",
            "B-"});
            this.comPatient_RegisterBloodgroup.Location = new System.Drawing.Point(748, 356);
            this.comPatient_RegisterBloodgroup.Name = "comPatient_RegisterBloodgroup";
            this.comPatient_RegisterBloodgroup.Size = new System.Drawing.Size(339, 30);
            this.comPatient_RegisterBloodgroup.TabIndex = 34;
            // 
            // txtPatient_RegisterFullname
            // 
            this.txtPatient_RegisterFullname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatient_RegisterFullname.Location = new System.Drawing.Point(748, 90);
            this.txtPatient_RegisterFullname.Name = "txtPatient_RegisterFullname";
            this.txtPatient_RegisterFullname.Size = new System.Drawing.Size(398, 31);
            this.txtPatient_RegisterFullname.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "FullName";
            // 
            // txtPatient_RegisterAge
            // 
            this.txtPatient_RegisterAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatient_RegisterAge.Location = new System.Drawing.Point(748, 192);
            this.txtPatient_RegisterAge.Name = "txtPatient_RegisterAge";
            this.txtPatient_RegisterAge.Size = new System.Drawing.Size(398, 31);
            this.txtPatient_RegisterAge.TabIndex = 31;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(553, 355);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(159, 27);
            this.lblPass.TabIndex = 30;
            this.lblPass.Text = "Blood_Group";
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.Location = new System.Drawing.Point(643, 196);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(57, 27);
            this.lblUname.TabIndex = 29;
            this.lblUname.Text = "Age";
            // 
            // rbPatient_RegisterMale
            // 
            this.rbPatient_RegisterMale.AutoSize = true;
            this.rbPatient_RegisterMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPatient_RegisterMale.Location = new System.Drawing.Point(748, 284);
            this.rbPatient_RegisterMale.Name = "rbPatient_RegisterMale";
            this.rbPatient_RegisterMale.Size = new System.Drawing.Size(69, 26);
            this.rbPatient_RegisterMale.TabIndex = 35;
            this.rbPatient_RegisterMale.TabStop = true;
            this.rbPatient_RegisterMale.Text = "Male";
            this.rbPatient_RegisterMale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 36;
            this.label1.Text = "Gender";
            // 
            // rbPatient_RegisterFemale
            // 
            this.rbPatient_RegisterFemale.AutoSize = true;
            this.rbPatient_RegisterFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPatient_RegisterFemale.Location = new System.Drawing.Point(867, 282);
            this.rbPatient_RegisterFemale.Name = "rbPatient_RegisterFemale";
            this.rbPatient_RegisterFemale.Size = new System.Drawing.Size(90, 26);
            this.rbPatient_RegisterFemale.TabIndex = 37;
            this.rbPatient_RegisterFemale.TabStop = true;
            this.rbPatient_RegisterFemale.Text = "Female";
            this.rbPatient_RegisterFemale.UseVisualStyleBackColor = true;
            // 
            // txtPatient_RegisterContact
            // 
            this.txtPatient_RegisterContact.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatient_RegisterContact.Location = new System.Drawing.Point(748, 431);
            this.txtPatient_RegisterContact.Name = "txtPatient_RegisterContact";
            this.txtPatient_RegisterContact.Size = new System.Drawing.Size(398, 31);
            this.txtPatient_RegisterContact.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 38;
            this.label2.Text = "Contact";
            // 
            // txtPatient_RegisterAddress
            // 
            this.txtPatient_RegisterAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatient_RegisterAddress.Location = new System.Drawing.Point(748, 507);
            this.txtPatient_RegisterAddress.Name = "txtPatient_RegisterAddress";
            this.txtPatient_RegisterAddress.Size = new System.Drawing.Size(398, 31);
            this.txtPatient_RegisterAddress.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(595, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 27);
            this.label3.TabIndex = 40;
            this.label3.Text = "Address";
            // 
            // btnPSubmit
            // 
            this.btnPSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSubmit.ForeColor = System.Drawing.Color.White;
            this.btnPSubmit.Location = new System.Drawing.Point(844, 600);
            this.btnPSubmit.Name = "btnPSubmit";
            this.btnPSubmit.Size = new System.Drawing.Size(113, 40);
            this.btnPSubmit.TabIndex = 42;
            this.btnPSubmit.Text = "SUBMIT";
            this.btnPSubmit.UseVisualStyleBackColor = false;
            this.btnPSubmit.Click += new System.EventHandler(this.btnPSubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.image1;
            this.pictureBox1.Location = new System.Drawing.Point(72, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 360);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(552, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 33);
            this.label5.TabIndex = 43;
            this.label5.Text = "PATIENT REGISTER";
            // 
            // PatientRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPSubmit);
            this.Controls.Add(this.txtPatient_RegisterAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPatient_RegisterContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbPatient_RegisterFemale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbPatient_RegisterMale);
            this.Controls.Add(this.comPatient_RegisterBloodgroup);
            this.Controls.Add(this.txtPatient_RegisterFullname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPatient_RegisterAge);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientRegisterForm";
            this.Text = "PatientRegisterForm";
            this.Load += new System.EventHandler(this.PatientRegisterForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comPatient_RegisterBloodgroup;
        private System.Windows.Forms.TextBox txtPatient_RegisterFullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPatient_RegisterAge;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.RadioButton rbPatient_RegisterMale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPatient_RegisterFemale;
        private System.Windows.Forms.TextBox txtPatient_RegisterContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatient_RegisterAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPSubmit;
        private System.Windows.Forms.Label label5;
    }
}