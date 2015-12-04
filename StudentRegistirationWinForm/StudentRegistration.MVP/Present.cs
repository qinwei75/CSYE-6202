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

        public void ShowNewStudent() {
            var form = view as NewStudentRegistrationForm;

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
        public void ShowEditForm()
        {
            var form = view as EditStudents;

            if (form != null)
            {
                form.ShowDialog();
            }
        }

        public void ShowRemoveForm()
        {
            var form = view as RemoveStudentRegistration;

            if (form != null)
            {
                form.ShowDialog();
            }
        }
    }
}
