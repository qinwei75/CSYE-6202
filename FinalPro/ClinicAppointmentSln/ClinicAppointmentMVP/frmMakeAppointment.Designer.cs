namespace ClinicAppointment.MVP
{
    partial class frmMakeAppointment
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.dateTimePikerAppointment = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DBProfession = new System.Windows.Forms.DataGridView();
            this.DBPatient = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.txtproFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtproLastName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtDoctor = new System.Windows.Forms.RadioButton();
            this.rbtNurse = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpaFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpaLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbVisitReason = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DBProfession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBPatient)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "Time:";
            // 
            // cmbTime
            // 
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "1000",
            "1100",
            "1200",
            "1300",
            "1400",
            "1500",
            "1600"});
            this.cmbTime.Location = new System.Drawing.Point(374, 167);
            this.cmbTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(108, 24);
            this.cmbTime.TabIndex = 55;
            // 
            // dateTimePikerAppointment
            // 
            this.dateTimePikerAppointment.Location = new System.Drawing.Point(60, 169);
            this.dateTimePikerAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePikerAppointment.Name = "dateTimePikerAppointment";
            this.dateTimePikerAppointment.Size = new System.Drawing.Size(265, 22);
            this.dateTimePikerAppointment.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(431, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 47;
            this.label10.Text = "Professionals";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Patients";
            // 
            // DBProfession
            // 
            this.DBProfession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBProfession.Location = new System.Drawing.Point(435, 230);
            this.DBProfession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBProfession.Name = "DBProfession";
            this.DBProfession.RowTemplate.Height = 28;
            this.DBProfession.Size = new System.Drawing.Size(404, 158);
            this.DBProfession.TabIndex = 52;
            this.DBProfession.SelectionChanged += new System.EventHandler(this.DBProfession_SelectionChanged);
            // 
            // DBPatient
            // 
            this.DBPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBPatient.Location = new System.Drawing.Point(12, 230);
            this.DBPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBPatient.Name = "DBPatient";
            this.DBPatient.RowTemplate.Height = 28;
            this.DBPatient.Size = new System.Drawing.Size(404, 158);
            this.DBPatient.TabIndex = 51;
            this.DBPatient.SelectionChanged += new System.EventHandler(this.DBPatient_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtProID);
            this.groupBox3.Controls.Add(this.txtproFirstName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtproLastName);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(435, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(404, 147);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Professional Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Patient ID:";
            // 
            // txtProID
            // 
            this.txtProID.Enabled = false;
            this.txtProID.Location = new System.Drawing.Point(107, 33);
            this.txtProID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(132, 22);
            this.txtProID.TabIndex = 27;
            // 
            // txtproFirstName
            // 
            this.txtproFirstName.Location = new System.Drawing.Point(107, 68);
            this.txtproFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtproFirstName.Name = "txtproFirstName";
            this.txtproFirstName.Size = new System.Drawing.Size(132, 22);
            this.txtproFirstName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Name:";
            // 
            // txtproLastName
            // 
            this.txtproLastName.Location = new System.Drawing.Point(107, 103);
            this.txtproLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtproLastName.Name = "txtproLastName";
            this.txtproLastName.Size = new System.Drawing.Size(132, 22);
            this.txtproLastName.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtDoctor);
            this.groupBox2.Controls.Add(this.rbtNurse);
            this.groupBox2.Location = new System.Drawing.Point(264, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(135, 102);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Professional";
            // 
            // rbtDoctor
            // 
            this.rbtDoctor.AutoSize = true;
            this.rbtDoctor.Location = new System.Drawing.Point(6, 66);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last Name:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(845, 51);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 30);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(845, 11);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(73, 32);
            this.btnSubmit.TabIndex = 45;
            this.btnSubmit.Text = "Sumbmit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpaFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtpaLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPatientID);
            this.groupBox1.Controls.Add(this.lblStudentID);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(404, 143);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            // 
            // txtpaFirstName
            // 
            this.txtpaFirstName.Location = new System.Drawing.Point(129, 70);
            this.txtpaFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpaFirstName.Name = "txtpaFirstName";
            this.txtpaFirstName.Size = new System.Drawing.Size(132, 22);
            this.txtpaFirstName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name:";
            // 
            // txtpaLastName
            // 
            this.txtpaLastName.Location = new System.Drawing.Point(129, 108);
            this.txtpaLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpaLastName.Name = "txtpaLastName";
            this.txtpaLastName.Size = new System.Drawing.Size(132, 22);
            this.txtpaLastName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(129, 33);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(132, 22);
            this.txtPatientID.TabIndex = 29;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(46, 33);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(73, 17);
            this.lblStudentID.TabIndex = 27;
            this.lblStudentID.Text = "Patient ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Visit Reason:";
            // 
            // cmbVisitReason
            // 
            this.cmbVisitReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVisitReason.FormattingEnabled = true;
            this.cmbVisitReason.Location = new System.Drawing.Point(585, 166);
            this.cmbVisitReason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVisitReason.Name = "cmbVisitReason";
            this.cmbVisitReason.Size = new System.Drawing.Size(108, 24);
            this.cmbVisitReason.TabIndex = 57;
            this.cmbVisitReason.SelectedIndexChanged += new System.EventHandler(this.cmbVisitReason_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(718, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 59;
            this.label11.Text = "Cost: $";
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(776, 167);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(63, 22);
            this.txtCost.TabIndex = 60;
            // 
            // frmMakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 402);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbVisitReason);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.dateTimePikerAppointment);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DBProfession);
            this.Controls.Add(this.DBPatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMakeAppointment";
            this.Text = "Make Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.DBProfession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBPatient)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.DateTimePicker dateTimePikerAppointment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DBProfession;
        private System.Windows.Forms.DataGridView DBPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.TextBox txtproFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtproLastName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtDoctor;
        private System.Windows.Forms.RadioButton rbtNurse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpaFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpaLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbVisitReason;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCost;
    }
}