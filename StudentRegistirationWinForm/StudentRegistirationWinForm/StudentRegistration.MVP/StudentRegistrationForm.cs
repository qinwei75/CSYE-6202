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
    public partial class StudentRegistrationForm : Form, IStudentRegistrationForm
    {
        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")] //API
        extern static System.IntPtr GetSystemMenu(System.IntPtr hWnd, System.IntPtr bRevert);
        [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
        extern static int RemoveMenu(IntPtr hMenu, int nPos, int flags);
        static int MF_BYPOSITION = 0x400;
        static int MF_REMOVE = 0x1000;

        public event EventHandler DataChanged;

        public StudentRegistrationForm()
        {
            InitializeComponent();
            RemoveMenu(GetSystemMenu(Handle, IntPtr.Zero), 0, MF_BYPOSITION | MF_REMOVE);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            LoadDefaults();
            LoadDepartments();
            LoadInformation();
        }
        private void LoadDepartments()
        {
            comboBoxDepartment.Items.AddRange(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }
        private void LoadDefaults()
        {
            rbtFullTime.Select();
            //comboBoxDepartment.SelectedIndex = 0;
        }
        private void LoadInformation()
        {
            string con, sql;
            con = "Server=WEIQIN-PC\\SQLEXPRESS;Database=StudentRegistration;Trusted_Connection=SSPI";
            sql = "Select * from tb_student";
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();

            SqlDataAdapter mydata = new SqlDataAdapter(sql, con);
            DataSet myds = new DataSet();
            mydata.Fill(myds, "tb_student");
            dataGridView1.DataSource = myds.Tables["tb_student"];

            mycon.Close();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            //Dispose();
            IView view = new NewStudentRegistrationForm();
            IModel model = new Model();
            var present = new Present(model, view);

            present.ShowNewStudent();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Dispose();
            IView view = new EditStudentRegistrationForm();
            IModel model = new Model();
            var present = new Present(model, view);

            present.ShowEditForm();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Dispose();
            IView view = new RemoveStudentRegistration();
            IModel model = new Model();
            var present = new Present(model, view);

            present.ShowRemoveForm();
        }
    }
}
