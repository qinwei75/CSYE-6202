namespace ClinicMVP
{
    partial class frmCancelAppointment
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
            this.AppointmentInfo = new System.Windows.Forms.GroupBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtDoctor = new System.Windows.Forms.RadioButton();
            this.rbtNurse = new System.Windows.Forms.RadioButton();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientAge = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnCancelAppointment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.AppointmentInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppointmentInfo
            // 
            this.AppointmentInfo.Controls.Add(this.txtCost);
            this.AppointmentInfo.Controls.Add(this.txtAppID);
            this.AppointmentInfo.Controls.Add(this.label5);
            this.AppointmentInfo.Controls.Add(this.label6);
            this.AppointmentInfo.Controls.Add(this.txtDoctorName);
            this.AppointmentInfo.Controls.Add(this.label3);
            this.AppointmentInfo.Controls.Add(this.groupBox1);
            this.AppointmentInfo.Controls.Add(this.txtDate);
            this.AppointmentInfo.Controls.Add(this.txtReason);
            this.AppointmentInfo.Controls.Add(this.label1);
            this.AppointmentInfo.Controls.Add(this.label2);
            this.AppointmentInfo.Controls.Add(this.txtPatientAge);
            this.AppointmentInfo.Controls.Add(this.txtPatientName);
            this.AppointmentInfo.Controls.Add(this.txtPatientID);
            this.AppointmentInfo.Controls.Add(this.lblName);
            this.AppointmentInfo.Controls.Add(this.lblStudentID);
            this.AppointmentInfo.Controls.Add(this.lblAge);
            this.AppointmentInfo.Enabled = false;
            this.AppointmentInfo.Location = new System.Drawing.Point(12, 72);
            this.AppointmentInfo.Name = "AppointmentInfo";
            this.AppointmentInfo.Size = new System.Drawing.Size(1008, 205);
            this.AppointmentInfo.TabIndex = 5;
            this.AppointmentInfo.TabStop = false;
            this.AppointmentInfo.Text = "Appointment Info";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(134, 151);
            this.txtCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(82, 26);
            this.txtCost.TabIndex = 28;
            // 
            // txtAppID
            // 
            this.txtAppID.Location = new System.Drawing.Point(132, 32);
            this.txtAppID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.Size = new System.Drawing.Size(193, 26);
            this.txtAppID.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Appointment ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cost:";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(791, 26);
            this.txtDoctorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(187, 26);
            this.txtDoctorName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Professional Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtDoctor);
            this.groupBox1.Controls.Add(this.rbtNurse);
            this.groupBox1.Location = new System.Drawing.Point(791, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 73);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professional";
            // 
            // rbtDoctor
            // 
            this.rbtDoctor.AutoSize = true;
            this.rbtDoctor.Location = new System.Drawing.Point(97, 34);
            this.rbtDoctor.Name = "rbtDoctor";
            this.rbtDoctor.Size = new System.Drawing.Size(82, 24);
            this.rbtDoctor.TabIndex = 1;
            this.rbtDoctor.Text = "Doctor";
            this.rbtDoctor.UseVisualStyleBackColor = true;
            // 
            // rbtNurse
            // 
            this.rbtNurse.AutoSize = true;
            this.rbtNurse.Checked = true;
            this.rbtNurse.Location = new System.Drawing.Point(6, 34);
            this.rbtNurse.Name = "rbtNurse";
            this.rbtNurse.Size = new System.Drawing.Size(76, 24);
            this.rbtNurse.TabIndex = 0;
            this.rbtNurse.TabStop = true;
            this.rbtNurse.Text = "Nurse";
            this.rbtNurse.UseVisualStyleBackColor = true;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(134, 113);
            this.txtDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(191, 26);
            this.txtDate.TabIndex = 20;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(134, 75);
            this.txtReason.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(191, 26);
            this.txtReason.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Visit Reason:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Date:";
            // 
            // txtPatientAge
            // 
            this.txtPatientAge.Location = new System.Drawing.Point(464, 110);
            this.txtPatientAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientAge.Name = "txtPatientAge";
            this.txtPatientAge.Size = new System.Drawing.Size(82, 26);
            this.txtPatientAge.TabIndex = 16;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(464, 68);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(151, 26);
            this.txtPatientName.TabIndex = 15;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(464, 32);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(151, 26);
            this.txtPatientID.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(355, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 20);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Patient Name:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(374, 32);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(84, 20);
            this.lblStudentID.TabIndex = 12;
            this.lblStudentID.Text = "Patient ID:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(416, 113);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 20);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // btnCancelAppointment
            // 
            this.btnCancelAppointment.Location = new System.Drawing.Point(836, 300);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(184, 46);
            this.btnCancelAppointment.TabIndex = 6;
            this.btnCancelAppointment.Text = "Cancel Appointment";
            this.btnCancelAppointment.UseVisualStyleBackColor = true;
            this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(688, 300);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 49);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CancelAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 569);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancelAppointment);
            this.Controls.Add(this.AppointmentInfo);
            this.Name = "CancelAppointment";
            this.Text = "CancelAppointment";
            this.AppointmentInfo.ResumeLayout(false);
            this.AppointmentInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AppointmentInfo;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtDoctor;
        private System.Windows.Forms.RadioButton rbtNurse;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientAge;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnCancelAppointment;
        private System.Windows.Forms.Button btnBack;
    }
}