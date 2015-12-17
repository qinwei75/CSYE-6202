using Business;
using Clinic.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicAppointment.MVP
{
    
    public partial class frmMakeAppointment : Form, IMakeAppointment
    {
        //private List<Appointment> appList;
        private List<Patient> patientList;
        private List<Professional> professionalList;
        private List<VisitReason> visitReasonList;
        private DataTable patientTable = new DataTable();
        private DataTable professionalTable = new DataTable();
        private DBconnectionConfig dbconfig = new DBconnectionConfig();
        private AppointmentDAL appDAL = new AppointmentDAL();
        private PatientDAL patientDAL = new PatientDAL();
        private ProfessionalDAL professionalDAL = new ProfessionalDAL();
        private VisitReasonDAL visitReasonDAL = new VisitReasonDAL();
        string LoginType;
        string admin = UserAccount.UserType.Admin.ToString().Trim();
        public frmMakeAppointment(string loginType)
        {
            InitializeComponent();
            LoginType = loginType;
            if (loginType == admin)
            {
                txtCost.Enabled = true;
            }
            else
            {
                txtCost.Enabled = false;
            }
            LoadVisitReasonComboBox();
            PopulateProfessionalInformation();
            PopulatePatientInformation();
            cmbTime.SelectedIndex = 0;
        }

        private void LoadVisitReasonComboBox() {
            cmbVisitReason.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();
            visitReasonList = visitReasonDAL.getVisitReason(con);
            foreach (VisitReason vs in visitReasonList) {
                cmbVisitReason.Items.Add(vs);
            }
            cmbVisitReason.SelectedIndex = 0;
            
            con.Close();
        }

        private List<Patient> LoadPatientInformation() {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();
            var patientList = patientDAL.getPatientList(con);
            return patientList;
            con.Close();
        }

        private void PopulatePatientInformation()
        {
            DBPatient.DataSource = null;
            DataTable patientTable = new DataTable();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();
            patientTable = patientDAL.getPatientTable(con);
            this.DBPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DBPatient.DataSource = patientTable;
            con.Close();
        }
        private List<Professional> LoadProfessionalInformation()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();

            professionalList = professionalDAL.getProfessionalList(con);
            return professionalList;

            dbconfig.CloseConnection();
        }

        private void PopulateProfessionalInformation()
        {
            DBProfession.DataSource = null;
            DataTable professionalTable = new DataTable();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();
            professionalTable = professionalDAL.getProfessionalTable(con);
            this.DBProfession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DBProfession.DataSource = professionalTable;
            con.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string paId = txtPatientID.Text.ToString();
            string poID = txtProID.Text.ToString();
            if (paId == String.Empty)
            {
                MessageBox.Show("Please select a Patient");
                return;
            }
            if (poID == String.Empty)
            {
                MessageBox.Show("Please select a Doctor or Nurse!");
                return;
            }
            //check exist

            string strDate = this.dateTimePikerAppointment.Value.ToString("yyyyMMdd");
            string strTime = this.cmbTime.SelectedItem.ToString().Trim();
            string strDT = strDate + strTime;
            string newAppointmentID = strDT + poID;
            DateTime dt = DateTime.ParseExact(strDT, "yyyyMMddHHmm", System.Globalization.CultureInfo.CurrentCulture);
            if (DateTime.Compare(dt, DateTime.Now) < 0) {
                MessageBox.Show("Appointment Time can not be earlier than now!");
                return;
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();
            bool exist = appDAL.checkIfAppointmentIDExist(newAppointmentID, con);
            con.Close();

            
            if (exist == false)
            {
                Appointment newAppointment = new Appointment();
                newAppointment.AppointmentID = newAppointmentID;
                newAppointment.PatientID = paId;
                newAppointment.ProfessionalID = poID;
                newAppointment.Reason = cmbVisitReason.SelectedItem.ToString().Trim();
                newAppointment.VisitDate = dt;
                newAppointment.LastUpdateTime = DateTime.Now;
                try
                {
                    newAppointment.Cost = int.Parse(txtCost.Text.ToString().Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cost should be number!");
                    return;
                }
                newAppointment.Location = "";
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = dbconfig.StringBuilder();
                sqlcon.Open();
                appDAL.InsertAppointment(newAppointment, sqlcon);
                con.Close();
                sqlcon.Close();
                //string newAppointmentID = strDate + strTime + poID;
                //MessageBox.Show(newAppointmentID);
                MessageBox.Show("Appointment saved");
            }
            else {
                MessageBox.Show("This Time already occupied!");
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
            IView view = new frmClinicHomePage(LoginType);
            IModel model = new Model();
            var present = new Presenter(model, view);
            present.ShowHome();
        }

        private void cmbVisitReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisitReason vs = (VisitReason)cmbVisitReason.SelectedItem;
            txtCost.Text = vs.Cost.ToString().Trim();
        }

        private void DBPatient_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DBPatient.SelectedRows)
            {
                txtPatientID.Text = row.Cells[3].Value.ToString();
                txtpaFirstName.Text = row.Cells[0].Value.ToString();
                txtpaLastName.Text = row.Cells[1].Value.ToString();

            }
        }

        private void DBProfession_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DBProfession.SelectedRows)
            {
                string active = row.Cells[5].Value.ToString().Trim();
                if (active == "DisActive") {
                    MessageBox.Show("Please select an Active health professional.");
                    txtProID.Text = "";
                    txtproFirstName.Text = "";
                    txtproLastName.Text = "";
                    return;
                }
                txtProID.Text = row.Cells[3].Value.ToString();
                txtproFirstName.Text = row.Cells[0].Value.ToString();
                txtproLastName.Text = row.Cells[1].Value.ToString();
                

                string Type = row.Cells[4].Value.ToString().Trim();
                if (rbtDoctor.Text.Trim() == Type)
                {
                    rbtDoctor.Checked = true;
                }
                else if (rbtNurse.Text.Trim() == Type)
                {
                    rbtNurse.Checked = true;
                }

            }
        }
    }
}
