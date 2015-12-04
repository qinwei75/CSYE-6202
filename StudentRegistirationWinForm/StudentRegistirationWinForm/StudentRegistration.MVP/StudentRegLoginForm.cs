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

namespace StudentRegistration.MVP
{
    public partial class StudentRegLoginForm : Form, IStudentRegLogin
    { 
        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")] //API
        extern static System.IntPtr GetSystemMenu(System.IntPtr hWnd, System.IntPtr bRevert);
        [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
        extern static int RemoveMenu(IntPtr hMenu, int nPos, int flags);
        static int MF_BYPOSITION = 0x400;
        static int MF_REMOVE = 0x1000;

        int wrongcount = 0;
        public StudentRegLoginForm()
        {
            InitializeComponent();
            RemoveMenu(GetSystemMenu(Handle, IntPtr.Zero), 0, MF_BYPOSITION | MF_REMOVE);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        public event EventHandler DataChanged;

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string con, sql;
            string str_username = txtUsername.Text;
            string str_pw = txtUsername.Text;
            con = "Server=WEIQIN-PC\\SQLEXPRESS;Database=StudentRegistration;Trusted_Connection=SSPI";
            sql = "Select * from tb_user where UserName =@username and Password =@password";
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();


            SqlCommand cmd = new SqlCommand(sql, mycon);
            cmd.Parameters.Add(new SqlParameter("@username", str_username));
            cmd.Parameters.Add(new SqlParameter("@password", str_pw));
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows == true)
            {
                Dispose();
                IView view = new StudentRegistrationForm();
                IModel model = new Model();
                var present = new Present(model, view);

                present.ShowRegForm();
            }
            else
            {

                wrongcount++;
                int lefttime = 3 - wrongcount;
                if (wrongcount >= 3)
                {
                    Environment.Exit(1);
                }
                MessageBox.Show("Usename and password are not match! You have " + lefttime + " time(s) left!");
            }
            dataReader.Close();
        }


    }


}
