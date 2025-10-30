namespace HMS
{
    partial class DoctorPrescriptionUser
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.patientid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.medicineTxt = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.instructionTxt = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 191);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 47);
            this.textBox1.TabIndex = 0;
            // 
            // patientid
            // 
            this.patientid.AutoSize = true;
            this.patientid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientid.Location = new System.Drawing.Point(80, 191);
            this.patientid.Name = "patientid";
            this.patientid.Size = new System.Drawing.Size(106, 25);
            this.patientid.TabIndex = 1;
            this.patientid.Text = "Patient ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(970, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diagonisis";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Covid-19",
            "Diabetes",
            "Pneumonia",
            "Anxiety Disorders"});
            this.checkedListBox1.Location = new System.Drawing.Point(975, 219);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(184, 140);
            this.checkedListBox1.TabIndex = 3;
            // 
            // medicineTxt
            // 
            this.medicineTxt.AutoSize = true;
            this.medicineTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineTxt.Location = new System.Drawing.Point(81, 279);
            this.medicineTxt.Name = "medicineTxt";
            this.medicineTxt.Size = new System.Drawing.Size(105, 25);
            this.medicineTxt.TabIndex = 4;
            this.medicineTxt.Text = "Medicine ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 307);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(612, 167);
            this.textBox2.TabIndex = 5;
            // 
            // instructionTxt
            // 
            this.instructionTxt.AutoSize = true;
            this.instructionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionTxt.Location = new System.Drawing.Point(81, 505);
            this.instructionTxt.Name = "instructionTxt";
            this.instructionTxt.Size = new System.Drawing.Size(112, 25);
            this.instructionTxt.TabIndex = 6;
            this.instructionTxt.Text = "Instruction";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 547);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(612, 97);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(955, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Complete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(16, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 49);
            this.panel1.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(457, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(313, 35);
            this.label11.TabIndex = 1;
            this.label11.Text = "DOCTOR PRESCRIPTION";
            // 
            // DoctorPrescriptionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.instructionTxt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.medicineTxt);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientid);
            this.Controls.Add(this.textBox1);
            this.Name = "DoctorPrescriptionUser";
            this.Size = new System.Drawing.Size(1302, 742);
            this.Load += new System.EventHandler(this.DoctorPrescriptionUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label patientid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label medicineTxt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label instructionTxt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
    }
}
