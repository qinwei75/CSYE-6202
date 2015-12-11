﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicMVP
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
            IView view = new frmLoginPage();
            var present = new Present(model, view);

            present.ShowLogin();
        }
    }
}
