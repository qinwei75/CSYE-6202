using StudentRegistration.MVP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationWinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IModel model = new Model();
            IView view = new StudentRegLoginForm();
            var presenter = new Present(model, view);

            presenter.ShowLogin();
        }
    }
}
