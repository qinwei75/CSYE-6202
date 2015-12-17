using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicAppointment.MVP
{
    public class Presenter
    {
        private IModel model;
        private IView view;

        public Presenter(IModel model, IView view)
        {
            this.model = model;
            this.view = view;
        }

        public void ShowLogin()
        {
            var form = view as frmLoginPage;

            if (form != null)
            {
                form.ShowDialog();
            }
        }
        public void ShowHome()
        {
            var form = view as frmClinicHomePage;

            if (form != null)
            {
                form.ShowDialog();
            }
        }
        public void ShowMakeAppointment()
        {
            var form = view as frmMakeAppointment;

            if (form != null)
            {
                form.ShowDialog();
            }
        }

        public void ShowAdminSettings()
        {
            var form = view as frmProfessionalEdit;

            if (form != null)
            {
                form.ShowDialog();
            }
        }
        public void ShowCancel()
        {
            var form = view as frmCancelAppointment;

            if (form != null)
            {
                form.ShowDialog();
            }
        }
        //public void ShowUpdate()
        //{
        //    var form = view as frmUpdateAppointment;

        //    if (form != null)
        //    {
        //        form.ShowDialog();
        //    }
        //}
        public void ShowAdminHome()
        {
            var form = view as frmAdminSettings;

            if (form != null)
            {
                form.ShowDialog();
            }
        }
        public void ShowAdminProfessionalEdit()
        {
            var form = view as frmProfessionalEdit;

            if (form != null)
            {
                form.ShowDialog();
            }
        }

        public void ShowAdminVisitReasonEdit()
        {
            var form = view as frmVisitReasonEdit;

            if (form != null)
            {
                form.ShowDialog();
            }
        }
    }
}
