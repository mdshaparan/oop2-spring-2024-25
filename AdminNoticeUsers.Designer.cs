namespace HMS
{
    partial class AdminNoticeUsers
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txtAdmin_DoctorId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdmin_Message = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightYellow;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(16, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1230, 49);
            this.panel3.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(493, -3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 35);
            this.label11.TabIndex = 1;
            this.label11.Text = "NOTICE BOARD";
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Send.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.ForeColor = System.Drawing.Color.White;
            this.btn_Send.Location = new System.Drawing.Point(558, 558);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(124, 53);
            this.btn_Send.TabIndex = 10;
            this.btn_Send.Text = "SEND";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txtAdmin_DoctorId
            // 
            this.txtAdmin_DoctorId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmin_DoctorId.Location = new System.Drawing.Point(151, 69);
            this.txtAdmin_DoctorId.Multiline = true;
            this.txtAdmin_DoctorId.Name = "txtAdmin_DoctorId";
            this.txtAdmin_DoctorId.Size = new System.Drawing.Size(269, 46);
            this.txtAdmin_DoctorId.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAdmin_Message);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAdmin_DoctorId);
            this.panel1.Controls.Add(this.btn_Send);
            this.panel1.Location = new System.Drawing.Point(16, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 652);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Doctor ID";
            // 
            // txtAdmin_Message
            // 
            this.txtAdmin_Message.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmin_Message.Location = new System.Drawing.Point(47, 241);
            this.txtAdmin_Message.Multiline = true;
            this.txtAdmin_Message.Name = "txtAdmin_Message";
            this.txtAdmin_Message.Size = new System.Drawing.Size(469, 225);
            this.txtAdmin_Message.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Message";
            // 
            // AdminNoticeUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "AdminNoticeUsers";
            this.Size = new System.Drawing.Size(1259, 745);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txtAdmin_DoctorId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdmin_Message;
    }
}
