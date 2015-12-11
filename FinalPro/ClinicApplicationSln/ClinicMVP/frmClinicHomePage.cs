using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicBusiness;
using System.Data.SqlClient;
using Clinic.DAL;

namespace ClinicMVP
{

    public partial class frmClinicHomePage : Form, IView
    {
        private List<Appointment> appList;
        private List<Patient> patientList;
        private List<Professional> professionalList;
        private DataTable appointmentTable = new DataTable();
        private DBconnectionConfig dbconfig = new DBconnectionConfig();
        private AppointmentDAL appDAL = new AppointmentDAL();
        private PatientDAL patientDAL = new PatientDAL();
        private ProfessionalDAL professionalDaL = new ProfessionalDAL();
        string admin = UserAccount.UserType.Admin.ToString().Trim();
        public frmClinicHomePage(string type)
        {
            InitializeComponent();
            //populateAppointmentInfo();
            //populatePatientInfo();

            if (type == admin)
            {
                btnAdmin.Visible = true;
            }
            else
            {
                btnAdmin.Visible = false;
            }
            LoadInformation();
        }
        private List<Appointment> LoadAppInfo()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();

            var apps = appDAL.getAppointments(con);
            return apps;

            dbconfig.CloseConnection();
        }

        private List<Patient> LoadPatientInfo()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();

            var patients = patientDAL.getPatientList(con);
            return patients;

            dbconfig.CloseConnection();
        }

        private List<Professional> LoadProfessionalInfo()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();

            var professionals = professionalDaL.getProfessionalList(con);
            return professionals;

            dbconfig.CloseConnection();
        }

        private void LoadInformation()
        {
            appList = LoadAppInfo();
            // create table schema
            var appIDColumn = new DataColumn("AppointmentID", typeof(int));
            var appPatientNameColumn = new DataColumn("PatientID", typeof(string));
            var appProfessionalNameColumn = new DataColumn("ProfessionalID", typeof(string));
            var appVisitDateColumn = new DataColumn("VisitDate", typeof(string));
            var appLastUpdateTimeColumn = new DataColumn("LastUpdateTime", typeof(string));
            var appVisitReasonColumn = new DataColumn("VisitReason", typeof(string));
            var appCost = new DataColumn("Cost", typeof(string));
            var appLocation = new DataColumn("Location", typeof(string));


            appointmentTable.Columns.AddRange(new DataColumn[] { appIDColumn, appPatientNameColumn, appProfessionalNameColumn, appVisitDateColumn, appLastUpdateTimeColumn, appVisitReasonColumn, appCost, appLocation });

            // now that our table schema is complete, iterate over our List<T> to create rows
            foreach (var appointment in appList)
            {
                DataRow newRow = appointmentTable.NewRow();
                newRow["AppointmentID"] = appointment.AppointmentID;
                newRow["PatientID"] = appointment.PatientID;
                newRow["ProfessionalID"] = appointment.ProfessionalID;
                newRow["VisitDate"] = appointment.VisitDate;
                newRow["LastUpdateTime"] = appointment.LastUpdateTime;
                newRow["VisitReason"] = appointment.Reason;
                newRow["Cost"] = appointment.Cost;
                newRow["Location"] = appointment.Location;
                appointmentTable.Rows.Add(newRow);
            }

            // finally bind the DataTable to the gridView
            AppointmentDataGridView.DataSource = appointmentTable;

        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            Dispose();
            IView view = new frmMakeAppointment();
            IModel model = new Model();
            var present = new Present(model, view);

            present.ShowMakeAppointment();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Dispose();
            IView view = new frmAdminSetting();
            IModel model = new Model();
            var present = new Present(model, view);

            present.ShowAdminSettings();
        }

        private void AppointmentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AppointmentDataGridView.SelectedRows)
            {
                patientList = LoadPatientInfo();
                professionalList = LoadProfessionalInfo();
                //newRow["AppointmentID"] = appointment.AppointmentID;
                //newRow["PatientID"] = appointment.PatientID;
                //newRow["ProfessionalID"] = appointment.ProfessionalID;
                //newRow["VisitDate"] = appointment.VisitDate;
                //newRow["LastUpdateTime"] = appointment.LastUpdateTime;
                //newRow["VisitReason"] = appointment.Reason;
                //newRow["Cost"] = appointment.Cost;
                //newRow["Location"] = appointment.Location;
                string applicationID = row.Cells[0].Value.ToString();
                string patientID = row.Cells[1].Value.ToString();
                string professionalID = row.Cells[2].Value.ToString();
                string visitDate = row.Cells[3].Value.ToString();
                string lastUpdateTime = row.Cells[4].Value.ToString();
                string visitReason = row.Cells[5].Value.ToString();
                string cost = row.Cells[6].Value.ToString();
                string location = row.Cells[7].Value.ToString();

                txtAppID.Text = applicationID;
                txtCost.Text = cost.ToString();
                txtDate.Text = visitDate;

                txtPatientID.Text = patientID;
                txtReason.Text = visitReason;

                foreach (Patient pa in patientList)
                {
                    if (patientID == pa.PatientID)
                    {
                        string patientName = pa.FirstName + " " + pa.LastName;
                        int age = pa.CalculateAge();
                        txtPatientName.Text = patientName;
                        txtPatientAge.Text = age.ToString().Trim();
                        break;
                    }
                }

                foreach (Professional pr in professionalList)
                {
                    if (professionalID == pr.ProfessionalID)
                    {
                        string profName = pr.FirstName + " " + pr.LastName;
                        txtDoctorName.Text = profName.ToString().Trim();
                        if (pr.profession == Professional.Profession.Doctor.ToString().Trim())
                        {
                            rbtDoctor.Checked = true;
                        }
                        else
                        {
                            rbtNurse.Checked = true;
                        }
                        break;
                    }
                }

            }
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            string appID = txtAppID.Text.Trim();
            if (appID != String.Empty)
            {
                if (MessageBox.Show("Are you sure you want to remove this student?", "RemoveStudent Registration Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    string prof;
                    if (rbtDoctor.Checked == true) { prof = rbtDoctor.Text.ToString().Trim(); } else { prof = rbtNurse.Text.ToString().Trim(); }
                    IView view = new frmCancelAppointment(
                    txtAppID.Text.ToString().Trim(),
                    txtCost.Text.ToString().Trim(),
                    txtDate.Text.ToString().Trim(),
                    txtPatientID.Text.ToString().Trim(),
                    txtReason.Text.ToString().Trim(),
                    txtPatientName.Text.ToString().Trim(),
                    txtPatientAge.Text.ToString().Trim(),
                    txtDoctorName.Text.ToString().Trim(),
                    prof
                    );
                    Dispose();
                    
                    IModel model = new Model();
                    var present = new Present(model, view);
                    present.ShowCancel();



                    
                }
                
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
            IView view = new frmClinicHomePage();
            IModel model = new Model();
            var present = new Present(model, view);
            present.ShowHome();
        }
    }
}
