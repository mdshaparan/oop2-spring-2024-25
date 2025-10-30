namespace HMS
{
    partial class AdminDashboardForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_TotalPatient = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Totaldoctors = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(20, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 650);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.Controls.Add(this.lbl_TotalPatient);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(691, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 576);
            this.panel4.TabIndex = 1;
            // 
            // lbl_TotalPatient
            // 
            this.lbl_TotalPatient.AutoSize = true;
            this.lbl_TotalPatient.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPatient.ForeColor = System.Drawing.Color.Black;
            this.lbl_TotalPatient.Location = new System.Drawing.Point(347, 519);
            this.lbl_TotalPatient.Name = "lbl_TotalPatient";
            this.lbl_TotalPatient.Size = new System.Drawing.Size(28, 33);
            this.lbl_TotalPatient.TabIndex = 3;
            this.lbl_TotalPatient.Text = "0";
            this.lbl_TotalPatient.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(140, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Patients";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel3.Controls.Add(this.lbl_Totaldoctors);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(94, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 576);
            this.panel3.TabIndex = 0;
            // 
            // lbl_Totaldoctors
            // 
            this.lbl_Totaldoctors.AutoSize = true;
            this.lbl_Totaldoctors.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Totaldoctors.ForeColor = System.Drawing.Color.White;
            this.lbl_Totaldoctors.Location = new System.Drawing.Point(351, 510);
            this.lbl_Totaldoctors.Name = "lbl_Totaldoctors";
            this.lbl_Totaldoctors.Size = new System.Drawing.Size(28, 33);
            this.lbl_Totaldoctors.TabIndex = 2;
            this.lbl_Totaldoctors.Text = "0";
            this.lbl_Totaldoctors.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Doctors";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightYellow;
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(20, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1230, 49);
            this.panel7.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(480, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(265, 35);
            this.label11.TabIndex = 1;
            this.label11.Text = "ADMIN DASHBOARD";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HMS.Properties.Resources.rsz_image5;
            this.pictureBox2.Location = new System.Drawing.Point(116, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 226);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.image41;
            this.pictureBox1.Location = new System.Drawing.Point(105, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 226);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboardForm";
            this.Size = new System.Drawing.Size(1259, 745);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Totaldoctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TotalPatient;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
    }
}
