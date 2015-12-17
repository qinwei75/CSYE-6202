namespace ClinicAppointment.MVP
{
    partial class frmProfessionalEdit
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
            this.DBProfession = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBProfession)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DBProfession
            // 
            this.DBProfession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBProfession.Location = new System.Drawing.Point(15, 228);
            this.DBProfession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBProfession.Name = "DBProfession";
            this.DBProfession.RowTemplate.Height = 28;
            this.DBProfession.Size = new System.Drawing.Size(611, 158);
            this.DBProfession.TabIndex = 53;
            this.DBProfession.SelectionChanged += new System.EventHandler(this.DBProfession_SelectionChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 54;
            this.label10.Text = "Professionals";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.label1);
            this.groupBoxInfo.Controls.Add(this.txtDOB);
            this.groupBoxInfo.Controls.Add(this.dateTimePicker1);
            this.groupBoxInfo.Controls.Add(this.label7);
            this.groupBoxInfo.Controls.Add(this.txtProID);
            this.groupBoxInfo.Controls.Add(this.txtproFirstName);
            this.groupBoxInfo.Controls.Add(this.label4);
            this.groupBoxInfo.Controls.Add(this.txtproLastName);
            this.groupBoxInfo.Controls.Add(this.groupBox2);
            this.groupBoxInfo.Controls.Add(this.label5);
            this.groupBoxInfo.Enabled = false;
            this.groupBoxInfo.Location = new System.Drawing.Point(15, 11);
            this.groupBoxInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInfo.Size = new System.Drawing.Size(404, 196);
            this.groupBoxInfo.TabIndex = 55;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Professional Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "DOB:";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(107, 136);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(200, 22);
            this.txtDOB.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Professional ID:";
            // 
            // txtProID
            // 
            this.txtProID.Enabled = false;
            this.txtProID.Location = new System.Drawing.Point(126, 33);
            this.txtProID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(132, 22);
            this.txtProID.TabIndex = 27;
            // 
            // txtproFirstName
            // 
            this.txtproFirstName.Location = new System.Drawing.Point(126, 67);
            this.txtproFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtproFirstName.Name = "txtproFirstName";
            this.txtproFirstName.Size = new System.Drawing.Size(132, 22);
            this.txtproFirstName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Name:";
            // 
            // txtproLastName
            // 
            this.txtproLastName.Location = new System.Drawing.Point(126, 103);
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
            this.label5.Location = new System.Drawing.Point(13, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last Name:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(431, 184);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 30);
            this.btnBack.TabIndex = 57;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Enabled = false;
            this.btnSaveNew.Location = new System.Drawing.Point(122, 19);
            this.btnSaveNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(73, 31);
            this.btnSaveNew.TabIndex = 56;
            this.btnSaveNew.Text = "Save";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 20);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(73, 30);
            this.btnUpdate.TabIndex = 58;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(122, 20);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 30);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(431, 150);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 30);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(425, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 59);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnSaveNew);
            this.groupBox3.Location = new System.Drawing.Point(425, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 59);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 31);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmProfessionalEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 448);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DBProfession);
            this.Name = "frmProfessionalEdit";
            this.Text = "Professional Edit Page";
            ((System.ComponentModel.ISupportInitialize)(this.DBProfession)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DBProfession;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.TextBox txtproFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtproLastName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtDoctor;
        private System.Windows.Forms.RadioButton rbtNurse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdd;
    }
}