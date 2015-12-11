using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicMVP
{
    public class Present
    {
        private IModel model;
        private IView view;

        public Present(IModel model, IView view)
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
            var form = view as frmAdminSetting;

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
    }

}
