﻿using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicMVP
{
    public partial class frmLoginPage : Form, IView
    {
        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")] //API
        extern static System.IntPtr GetSystemMenu(System.IntPtr hWnd, System.IntPtr bRevert);
        [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
        extern static int RemoveMenu(IntPtr hMenu, int nPos, int flags);
        static int MF_BYPOSITION = 0x400;
        static int MF_REMOVE = 0x1000;
        int lefttime = 3;


        public frmLoginPage()
        {
            InitializeComponent();

            RemoveMenu(GetSystemMenu(Handle, IntPtr.Zero), 0, MF_BYPOSITION | MF_REMOVE);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameInput = txtUserName.Text.ToString().Trim();
            string passwordInput = txtPassword.Text.ToString().Trim();
            if (usernameInput == "" || passwordInput == "") {
                MessageBox.Show("UserName and Password can't be empty!");
                return;
            }

            //Open DBconnection
            DBconnectionConfig loginCon = new DBconnectionConfig();
            //get UserAccount
            SqlDataAdapter mydata = loginCon.getUserAccount();
            DataTable userTable = new DataTable();
            mydata.Fill(userTable);

            string type;
            bool succ = false;
            for (int i = 0; i < userTable.Rows.Count; i++)
            {
                if ((string)userTable.Rows[i][0].ToString().Trim() == usernameInput ||
                    (string)userTable.Rows[i][0].ToString().Trim() == passwordInput)
                {
                    type = userTable.Rows[i][2].ToString().Trim();
                    Dispose();
                    IView view = new frmClinicHomePage(type);
                    IModel model = new Model();
                    var present = new Present(model, view);
                    succ = true;
                    present.ShowHome();
                }
            }
            if (succ == false)
            {
                lefttime--;
                if (lefttime <= 0)
                {
                    MessageBox.Show("You have no time left! LOL! BYE!");
                    Environment.Exit(1);
                }
                MessageBox.Show("Usename and password are not match! You have " + lefttime + " time(s) left!");
            }
        }
    }
}
