namespace HMS
{
    partial class doctor_portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctor_portal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_doctor = new System.Windows.Forms.Button();
            this.btn_patient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(285, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btn_doctor
            // 
            this.btn_doctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.btn_doctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doctor.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor.ForeColor = System.Drawing.Color.White;
            this.btn_doctor.Location = new System.Drawing.Point(27, 255);
            this.btn_doctor.Name = "btn_doctor";
            this.btn_doctor.Size = new System.Drawing.Size(200, 44);
            this.btn_doctor.TabIndex = 38;
            this.btn_doctor.Text = "Doctor Details";
            this.btn_doctor.UseVisualStyleBackColor = false;
            this.btn_doctor.Click += new System.EventHandler(this.btn_doctor_Click);
            // 
            // btn_patient
            // 
            this.btn_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.btn_patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient.ForeColor = System.Drawing.Color.White;
            this.btn_patient.Location = new System.Drawing.Point(285, 255);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Size = new System.Drawing.Size(200, 44);
            this.btn_patient.TabIndex = 38;
            this.btn_patient.Text = "Patient Details";
            this.btn_patient.UseVisualStyleBackColor = false;
            this.btn_patient.Click += new System.EventHandler(this.btn_patient_Click);
            // 
            // doctor_portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 326);
            this.Controls.Add(this.btn_patient);
            this.Controls.Add(this.btn_doctor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "doctor_portal";
            this.Text = "Doctor Portal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_doctor;
        private System.Windows.Forms.Button btn_patient;
    }
}