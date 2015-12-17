using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicAppointment.MVP
{
    public partial class frmUpdateAppointment : Form, IUpdateAppointment
    {
        string LoginType;
        public frmUpdateAppointment(string loginType, string applicationID, string cost, string date, string paId, string reason, string patientName, string age, string Dname, string prof)
        {
            InitializeComponent();
            
            //txtAppID.Text = applicationID;
            //txtCost.Text = cost;
            //txtDate.Text = date;
            //txtPatientID.Text = paId;
            //txtReason.Text = reason;
            //txtPatientName.Text = patientName;
            //txtPatientAge.Text = age;
            //txtDoctorName.Text = Dname;
            //LoginType = loginType;
            //if (prof == rbtDoctor.Text.ToString().Trim())
            //{
            //    rbtDoctor.Checked = true;
            //}
            //else { rbtNurse.Checked = true; }
        }

        private void btnReschedule_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
            IView view = new frmClinicHomePage(LoginType);
            IModel model = new Model();
            var present = new Presenter(model, view);
            present.ShowHome();
        }
    }
}
