namespace ClinicAppointment.MVP
{
    partial class frmAdminSettings
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
            this.btnProfessional = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEditReason = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfessional
            // 
            this.btnProfessional.Location = new System.Drawing.Point(12, 11);
            this.btnProfessional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfessional.Name = "btnProfessional";
            this.btnProfessional.Size = new System.Drawing.Size(202, 32);
            this.btnProfessional.TabIndex = 57;
            this.btnProfessional.Text = "Edit Professional";
            this.btnProfessional.UseVisualStyleBackColor = true;
            this.btnProfessional.Click += new System.EventHandler(this.btnProfessional_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 115);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(202, 32);
            this.btnBack.TabIndex = 58;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEditReason
            // 
            this.btnEditReason.Location = new System.Drawing.Point(12, 68);
            this.btnEditReason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditReason.Name = "btnEditReason";
            this.btnEditReason.Size = new System.Drawing.Size(202, 32);
            this.btnEditReason.TabIndex = 59;
            this.btnEditReason.Text = "Edit VisitReason";
            this.btnEditReason.UseVisualStyleBackColor = true;
            this.btnEditReason.Click += new System.EventHandler(this.btnEditReason_Click);
            // 
            // frmAdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 188);
            this.Controls.Add(this.btnEditReason);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProfessional);
            this.Name = "frmAdminSettings";
            this.Text = "AdminSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfessional;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEditReason;
    }
}