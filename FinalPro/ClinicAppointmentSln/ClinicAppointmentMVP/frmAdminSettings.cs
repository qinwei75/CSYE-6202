using Business;
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
    public partial class frmAdminSettings : Form, IAddminSettings
    {
        
        string admin = UserAccount.UserType.Admin.ToString().Trim();
        public frmAdminSettings()
        {
            InitializeComponent();
            
        }

        private void btnProfessional_Click(object sender, EventArgs e)
        {
            Dispose();
            IView view = new frmProfessionalEdit();
            IModel model = new Model();
            var present = new Presenter(model, view);
            present.ShowAdminProfessionalEdit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
            IView view = new frmClinicHomePage(admin);
            IModel model = new Model();
            var present = new Presenter(model, view);
            present.ShowHome();
        }

        private void btnEditReason_Click(object sender, EventArgs e)
        {
            Dispose();
            IView view = new frmVisitReasonEdit();
            IModel model = new Model();
            var present = new Presenter(model, view);
            present.ShowAdminVisitReasonEdit();

        }
    }
}
