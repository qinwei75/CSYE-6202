namespace ClinicAppointment.MVP
{
    partial class frmClinicHomePage
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
            this.btnLogOut = new System.Windows.Forms.Button();
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
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.AppointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.AppointmentInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1139, 11);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(68, 37);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnRefreshTable_Click);
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
            this.AppointmentInfo.Location = new System.Drawing.Point(12, 11);
            this.AppointmentInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AppointmentInfo.Name = "AppointmentInfo";
            this.AppointmentInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AppointmentInfo.Size = new System.Drawing.Size(896, 193);
            this.AppointmentInfo.TabIndex = 10;
            this.AppointmentInfo.TabStop = false;
            this.AppointmentInfo.Text = "Appointment Info";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(119, 121);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(73, 22);
            this.txtCost.TabIndex = 28;
            // 
            // txtAppID
            // 
            this.txtAppID.Location = new System.Drawing.Point(117, 26);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.Size = new System.Drawing.Size(172, 22);
            this.txtAppID.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Appointment ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cost:";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(703, 21);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(167, 22);
            this.txtDoctorName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Professional Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtDoctor);
            this.groupBox1.Controls.Add(this.rbtNurse);
            this.groupBox1.Location = new System.Drawing.Point(703, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(169, 81);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professional";
            // 
            // rbtDoctor
            // 
            this.rbtDoctor.AutoSize = true;
            this.rbtDoctor.Location = new System.Drawing.Point(86, 27);
            this.rbtDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtDoctor.Name = "rbtDoctor";
            this.rbtDoctor.Size = new System.Drawing.Size(71, 21);
            this.rbtDoctor.TabIndex = 1;
            this.rbtDoctor.Text = "Doctor";
            this.rbtDoctor.UseVisualStyleBackColor = true;
            // 
            // rbtNurse
            // 
            this.rbtNurse.AutoSize = true;
            this.rbtNurse.Checked = true;
            this.rbtNurse.Location = new System.Drawing.Point(5, 27);
            this.rbtNurse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtNurse.Name = "rbtNurse";
            this.rbtNurse.Size = new System.Drawing.Size(67, 21);
            this.rbtNurse.TabIndex = 0;
            this.rbtNurse.TabStop = true;
            this.rbtNurse.Text = "Nurse";
            this.rbtNurse.UseVisualStyleBackColor = true;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(119, 90);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(170, 22);
            this.txtDate.TabIndex = 20;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(119, 60);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(170, 22);
            this.txtReason.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Visit Reason:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Date:";
            // 
            // txtPatientAge
            // 
            this.txtPatientAge.Location = new System.Drawing.Point(412, 88);
            this.txtPatientAge.Name = "txtPatientAge";
            this.txtPatientAge.Size = new System.Drawing.Size(73, 22);
            this.txtPatientAge.TabIndex = 16;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(412, 54);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(135, 22);
            this.txtPatientName.TabIndex = 15;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(412, 26);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(135, 22);
            this.txtPatientID.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(316, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 17);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Patient Name:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(332, 26);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(73, 17);
            this.lblStudentID.TabIndex = 12;
            this.lblStudentID.Text = "Patient ID:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(370, 90);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 17);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // btnCancelAppointment
            // 
            this.btnCancelAppointment.Location = new System.Drawing.Point(914, 53);
            this.btnCancelAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(186, 37);
            this.btnCancelAppointment.TabIndex = 9;
            this.btnCancelAppointment.Text = "Cancel Appointment";
            this.btnCancelAppointment.UseVisualStyleBackColor = true;
            this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(914, 11);
            this.btnAddAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(186, 37);
            this.btnAddAppointment.TabIndex = 8;
            this.btnAddAppointment.Text = "Make Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // AppointmentDataGridView
            // 
            this.AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentDataGridView.Location = new System.Drawing.Point(12, 220);
            this.AppointmentDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AppointmentDataGridView.Name = "AppointmentDataGridView";
            this.AppointmentDataGridView.ReadOnly = true;
            this.AppointmentDataGridView.RowTemplate.Height = 28;
            this.AppointmentDataGridView.Size = new System.Drawing.Size(1195, 350);
            this.AppointmentDataGridView.TabIndex = 7;
            this.AppointmentDataGridView.SelectionChanged += new System.EventHandler(this.AppointmentDataGridView_SelectionChanged);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(914, 97);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(186, 37);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Power Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // frmClinicHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 583);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.AppointmentInfo);
            this.Controls.Add(this.btnCancelAppointment);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.AppointmentDataGridView);
            this.Controls.Add(this.btnAdmin);
            this.Name = "frmClinicHomePage";
            this.Text = "Clinic Home Page";
            this.AppointmentInfo.ResumeLayout(false);
            this.AppointmentInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
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
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.DataGridView AppointmentDataGridView;
        private System.Windows.Forms.Button btnAdmin;
    }
}