using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration.MVP
{
    public class Present
    {
        private IModel model;
        private IView view;

        private Present() { }

        public Present(IModel model, IView view)
        {
            this.model = model;
            this.view = view;
        }

        public void ShowLogin()
        {
            var form = view as StudentRegLoginForm;

            if (form != null)
            {
                form.ShowDialog();
            }
        }

        public void ShowRegForm()
        {
            var form = view as StudentRegistrationForm;

            if (form != null)
            {
                form.ShowDialog();
            }
        }
    }
}
