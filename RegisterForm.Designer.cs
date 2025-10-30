namespace HMS
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister_signin = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtRegister_Pass = new System.Windows.Forms.TextBox();
            this.txtRegister_Uname = new System.Windows.Forms.TextBox();
            this.lblRegister_Pass = new System.Windows.Forms.Label();
            this.lblRegister_Uname = new System.Windows.Forms.Label();
            this.Register_close = new System.Windows.Forms.Label();
            this.lblRegister_Confirmpass = new System.Windows.Forms.Label();
            this.textRegister_cPass = new System.Windows.Forms.TextBox();
            this.Register_Showpass2 = new System.Windows.Forms.CheckBox();
            this.lblRegister_role = new System.Windows.Forms.Label();
            this.rbRegister_Doctor = new System.Windows.Forms.RadioButton();
            this.rbRegister_Patient = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnRegister_signin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 694);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(110, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Already have an account?";
            // 
            // btnRegister_signin
            // 
            this.btnRegister_signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnRegister_signin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister_signin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegister_signin.Location = new System.Drawing.Point(57, 572);
            this.btnRegister_signin.Name = "btnRegister_signin";
            this.btnRegister_signin.Size = new System.Drawing.Size(394, 46);
            this.btnRegister_signin.TabIndex = 13;
            this.btnRegister_signin.Text = "SIGN IN";
            this.btnRegister_signin.UseVisualStyleBackColor = false;
            this.btnRegister_signin.Click += new System.EventHandler(this.btnRegister_signin_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(556, 30);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(171, 34);
            this.lblRegister.TabIndex = 18;
            this.lblRegister.Text = "REGISTER";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnNext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Location = new System.Drawing.Point(870, 554);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(146, 47);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // txtRegister_Pass
            // 
            this.txtRegister_Pass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegister_Pass.Location = new System.Drawing.Point(562, 238);
            this.txtRegister_Pass.Name = "txtRegister_Pass";
            this.txtRegister_Pass.PasswordChar = '*';
            this.txtRegister_Pass.Size = new System.Drawing.Size(398, 31);
            this.txtRegister_Pass.TabIndex = 15;
            // 
            // txtRegister_Uname
            // 
            this.txtRegister_Uname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegister_Uname.Location = new System.Drawing.Point(562, 138);
            this.txtRegister_Uname.Name = "txtRegister_Uname";
            this.txtRegister_Uname.Size = new System.Drawing.Size(398, 31);
            this.txtRegister_Uname.TabIndex = 14;
            // 
            // lblRegister_Pass
            // 
            this.lblRegister_Pass.AutoSize = true;
            this.lblRegister_Pass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister_Pass.Location = new System.Drawing.Point(565, 198);
            this.lblRegister_Pass.Name = "lblRegister_Pass";
            this.lblRegister_Pass.Size = new System.Drawing.Size(122, 27);
            this.lblRegister_Pass.TabIndex = 13;
            this.lblRegister_Pass.Text = "Password";
            // 
            // lblRegister_Uname
            // 
            this.lblRegister_Uname.AutoSize = true;
            this.lblRegister_Uname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister_Uname.Location = new System.Drawing.Point(564, 89);
            this.lblRegister_Uname.Name = "lblRegister_Uname";
            this.lblRegister_Uname.Size = new System.Drawing.Size(127, 27);
            this.lblRegister_Uname.TabIndex = 12;
            this.lblRegister_Uname.Text = "Username";
            // 
            // Register_close
            // 
            this.Register_close.AutoSize = true;
            this.Register_close.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_close.Location = new System.Drawing.Point(1136, 11);
            this.Register_close.Name = "Register_close";
            this.Register_close.Size = new System.Drawing.Size(26, 27);
            this.Register_close.TabIndex = 11;
            this.Register_close.Text = "X";
            this.Register_close.Click += new System.EventHandler(this.Register_close_Click);
            // 
            // lblRegister_Confirmpass
            // 
            this.lblRegister_Confirmpass.AutoSize = true;
            this.lblRegister_Confirmpass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister_Confirmpass.Location = new System.Drawing.Point(564, 307);
            this.lblRegister_Confirmpass.Name = "lblRegister_Confirmpass";
            this.lblRegister_Confirmpass.Size = new System.Drawing.Size(216, 27);
            this.lblRegister_Confirmpass.TabIndex = 19;
            this.lblRegister_Confirmpass.Text = "Confirm password";
            // 
            // textRegister_cPass
            // 
            this.textRegister_cPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRegister_cPass.Location = new System.Drawing.Point(562, 346);
            this.textRegister_cPass.Name = "textRegister_cPass";
            this.textRegister_cPass.PasswordChar = '*';
            this.textRegister_cPass.Size = new System.Drawing.Size(398, 31);
            this.textRegister_cPass.TabIndex = 20;
            this.textRegister_cPass.TextChanged += new System.EventHandler(this.textRegister_cPass_TextChanged);
            // 
            // Register_Showpass2
            // 
            this.Register_Showpass2.AutoSize = true;
            this.Register_Showpass2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Showpass2.Location = new System.Drawing.Point(562, 383);
            this.Register_Showpass2.Name = "Register_Showpass2";
            this.Register_Showpass2.Size = new System.Drawing.Size(174, 25);
            this.Register_Showpass2.TabIndex = 21;
            this.Register_Showpass2.Text = "Show Password";
            this.Register_Showpass2.UseVisualStyleBackColor = true;
            this.Register_Showpass2.CheckedChanged += new System.EventHandler(this.Register_Showpass2_CheckedChanged);
            // 
            // lblRegister_role
            // 
            this.lblRegister_role.AutoSize = true;
            this.lblRegister_role.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister_role.Location = new System.Drawing.Point(565, 440);
            this.lblRegister_role.Name = "lblRegister_role";
            this.lblRegister_role.Size = new System.Drawing.Size(63, 27);
            this.lblRegister_role.TabIndex = 22;
            this.lblRegister_role.Text = "Role";
            // 
            // rbRegister_Doctor
            // 
            this.rbRegister_Doctor.AutoSize = true;
            this.rbRegister_Doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegister_Doctor.Location = new System.Drawing.Point(637, 440);
            this.rbRegister_Doctor.Name = "rbRegister_Doctor";
            this.rbRegister_Doctor.Size = new System.Drawing.Size(90, 29);
            this.rbRegister_Doctor.TabIndex = 23;
            this.rbRegister_Doctor.TabStop = true;
            this.rbRegister_Doctor.Text = "Doctor";
            this.rbRegister_Doctor.UseVisualStyleBackColor = true;
            // 
            // rbRegister_Patient
            // 
            this.rbRegister_Patient.AutoSize = true;
            this.rbRegister_Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegister_Patient.Location = new System.Drawing.Point(759, 440);
            this.rbRegister_Patient.Name = "rbRegister_Patient";
            this.rbRegister_Patient.Size = new System.Drawing.Size(93, 29);
            this.rbRegister_Patient.TabIndex = 24;
            this.rbRegister_Patient.TabStop = true;
            this.rbRegister_Patient.Text = "Patient";
            this.rbRegister_Patient.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HMS.Properties.Resources.image1;
            this.pictureBox2.Location = new System.Drawing.Point(75, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 360);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 694);
            this.Controls.Add(this.rbRegister_Patient);
            this.Controls.Add(this.rbRegister_Doctor);
            this.Controls.Add(this.lblRegister_role);
            this.Controls.Add(this.Register_Showpass2);
            this.Controls.Add(this.textRegister_cPass);
            this.Controls.Add(this.lblRegister_Confirmpass);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtRegister_Pass);
            this.Controls.Add(this.txtRegister_Uname);
            this.Controls.Add(this.lblRegister_Pass);
            this.Controls.Add(this.lblRegister_Uname);
            this.Controls.Add(this.Register_close);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister_signin;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtRegister_Pass;
        private System.Windows.Forms.TextBox txtRegister_Uname;
        private System.Windows.Forms.Label lblRegister_Pass;
        private System.Windows.Forms.Label lblRegister_Uname;
        private System.Windows.Forms.Label Register_close;
        private System.Windows.Forms.Label lblRegister_Confirmpass;
        private System.Windows.Forms.TextBox textRegister_cPass;
        private System.Windows.Forms.CheckBox Register_Showpass2;
        private System.Windows.Forms.Label lblRegister_role;
        private System.Windows.Forms.RadioButton rbRegister_Doctor;
        private System.Windows.Forms.RadioButton rbRegister_Patient;
    }
}