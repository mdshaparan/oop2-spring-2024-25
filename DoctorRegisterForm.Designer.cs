namespace HMS
{
    partial class DoctorRegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDoctor_RegisterContact = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUname = new System.Windows.Forms.Label();
            this.txtDoctor_RegisterFullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comDoctor_RegisterDepartment = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(130, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Create an account";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 750);
            this.panel2.TabIndex = 15;
            // 
            // txtDoctor_RegisterContact
            // 
            this.txtDoctor_RegisterContact.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctor_RegisterContact.Location = new System.Drawing.Point(770, 321);
            this.txtDoctor_RegisterContact.Name = "txtDoctor_RegisterContact";
            this.txtDoctor_RegisterContact.Size = new System.Drawing.Size(398, 31);
            this.txtDoctor_RegisterContact.TabIndex = 18;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(602, 417);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(145, 27);
            this.lblPass.TabIndex = 17;
            this.lblPass.Text = "Department";
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.Location = new System.Drawing.Point(607, 325);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(141, 27);
            this.lblUname.TabIndex = 16;
            this.lblUname.Text = "Contact_no";
            // 
            // txtDoctor_RegisterFullname
            // 
            this.txtDoctor_RegisterFullname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctor_RegisterFullname.Location = new System.Drawing.Point(770, 219);
            this.txtDoctor_RegisterFullname.Name = "txtDoctor_RegisterFullname";
            this.txtDoctor_RegisterFullname.Size = new System.Drawing.Size(398, 31);
            this.txtDoctor_RegisterFullname.TabIndex = 22;
            this.txtDoctor_RegisterFullname.TextChanged += new System.EventHandler(this.txtDoctor_RegisterFullname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 27);
            this.label4.TabIndex = 20;
            this.label4.Text = "Doctor_FullName";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(630, 637);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 40);
            this.btnSubmit.TabIndex = 27;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // comDoctor_RegisterDepartment
            // 
            this.comDoctor_RegisterDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comDoctor_RegisterDepartment.FormattingEnabled = true;
            this.comDoctor_RegisterDepartment.Items.AddRange(new object[] {
            "Cardiology",
            "Neurology",
            "Darmatology",
            "Orthopedics",
            "Urology"});
            this.comDoctor_RegisterDepartment.Location = new System.Drawing.Point(770, 418);
            this.comDoctor_RegisterDepartment.Name = "comDoctor_RegisterDepartment";
            this.comDoctor_RegisterDepartment.Size = new System.Drawing.Size(339, 30);
            this.comDoctor_RegisterDepartment.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.image1;
            this.pictureBox1.Location = new System.Drawing.Point(73, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 360);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HMS.Properties.Resources.image1;
            this.pictureBox2.Location = new System.Drawing.Point(55, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 360);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 33);
            this.label2.TabIndex = 29;
            this.label2.Text = "DOCTOR REGISTER";
            // 
            // DoctorRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comDoctor_RegisterDepartment);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtDoctor_RegisterFullname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDoctor_RegisterContact);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorRegisterForm";
            this.Load += new System.EventHandler(this.DoctorRegisterForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDoctor_RegisterContact;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.TextBox txtDoctor_RegisterFullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox comDoctor_RegisterDepartment;
        private System.Windows.Forms.Label label2;
    }
}