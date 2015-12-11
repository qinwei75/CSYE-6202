using Clinic.DAL;
using ClinicBusiness;
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

namespace ClinicMVP
{
    public partial class frmCancelAppointment : Form,IView
    {
        private List<Appointment> appList;
        private List<Patient> patientList;
        private List<Professional> professionalList;
        private DBconnectionConfig dbconfig = new DBconnectionConfig();
        private AppointmentDAL appDAL = new AppointmentDAL();
        private PatientDAL patientDAL = new PatientDAL();
        private ProfessionalDAL professionalDaL = new ProfessionalDAL();
        public frmCancelAppointment(string applicationID, string cost, string date, string paId, string reason, string patientName, string age, string Dname, string prof)
        {
            InitializeComponent();
            MessageBox.Show(applicationID);
            txtAppID.Text = applicationID;
            txtCost.Text = cost;
            txtDate.Text = date;
            txtPatientID.Text = paId;
            txtReason.Text= reason;
            txtPatientName.Text = patientName;
            txtPatientAge.Text = age;
            txtDoctorName.Text = Dname;
            if (prof == rbtDoctor.Text.ToString().Trim())
            {
                rbtDoctor.Checked = true;
            }
            else { rbtNurse.Checked = true; }
        }


        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            string appID = txtAppID.Text.Trim();
            if (MessageBox.Show("Are you sure you want to remove this student?", "RemoveStudent Registration Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = dbconfig.StringBuilder();
                    con.Open();

                    appDAL.DeleteAppointment(appID, con);
                    //dbconfig.CloseConnection();

                    txtAppID.Text = "";
                    txtCost.Text = "";
                    txtDate.Text = "";
                    txtPatientID.Text = "";
                    txtReason.Text = "";
                    txtPatientName.Text = "";
                    txtPatientAge.Text = "";
                    txtDoctorName.Text = "";
                    MessageBox.Show("appointment deleted!");

                }

                Close();
                IView view = new frmClinicHomePage();
                IModel model = new Model();
                var present = new Present(model, view);
                present.ShowHome();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
            IView view = new frmClinicHomePage();
            IModel model = new Model();
            var present = new Present(model, view);
            present.ShowHome();
        }
    }
}
