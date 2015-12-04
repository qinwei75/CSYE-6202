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
    public partial class NewStudentRegistrationForm : Form, INewStudentRegistrationForm
    {
        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")] //API
        extern static System.IntPtr GetSystemMenu(System.IntPtr hWnd, System.IntPtr bRevert);
        [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
        extern static int RemoveMenu(IntPtr hMenu, int nPos, int flags);
        static int MF_BYPOSITION = 0x400;
        static int MF_REMOVE = 0x1000;
        public NewStudentRegistrationForm()
        {
            InitializeComponent();
            LoadDepartments();
            LoadDefaults();
            RemoveMenu(GetSystemMenu(Handle, IntPtr.Zero), 0, MF_BYPOSITION | MF_REMOVE);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void LoadDefaults()
        {
            rbtFullTime.Select();
            comboBoxDepartment.SelectedIndex = 0;
        }
        private void LoadDepartments()
        {
            comboBoxDepartment.Items.AddRange(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             if (textBox2.Text.Trim() == String.Empty ||
                 textBox3.Text.Trim() == String.Empty ||
                 textBox4.Text.Trim() == String.Empty )
                 {
                        MessageBox.Show("Please fill in all the fields!!!!");
                return;
                    }
                    else {
                    string enrollmentType = null;
                    if (rbtFullTime.Checked == true)
                    {
                        enrollmentType = rbtFullTime.Text.Trim();
                    }
                    else if (rbtPartTime.Checked == true)
                    {
                        enrollmentType = rbtPartTime.Text.Trim();
                    }
                    string con, sql, querySql;
                    con = "Server=WEIQIN-PC\\SQLEXPRESS;Database=StudentRegistration;Trusted_Connection=SSPI";
                    SqlConnection mycon = new SqlConnection(con);
                    mycon.Open();
                    //check if ID is exist
                    querySql = "Select count(*) from tb_student where StudentID = '" + textBox2.Text.Trim() + "'";
                    SqlCommand queryCmd = new SqlCommand(querySql, mycon);
                    if ((int)new SqlCommand(querySql, mycon).ExecuteScalar() > 0){
                        MessageBox.Show("ID exist!");
                    }
                    else{
                    //Insert sql
                    sql = " Insert into tb_student (StudentID,FirstName,LastName,Department,EnrollmentType) VALUES('" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "' ,'" + textBox4.Text.Trim() + "'  , '" + comboBoxDepartment.SelectedItem.ToString().Trim() + "', '" + enrollmentType.ToString().Trim() + "')";
                    SqlCommand cmd = new SqlCommand(sql, mycon);

                    cmd.ExecuteNonQuery();
                    mycon.Close();

                    Dispose();
                    IView view = new StudentRegistrationForm();
                    IModel model = new Model();
                    var present = new Present(model, view);
                    present.ShowRegForm();
                }
                   }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnAdd.Enabled = true;
            btnReset.Enabled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnAdd.Enabled = true;
            btnReset.Enabled = true;

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnAdd.Enabled = true;
            btnReset.Enabled = true;
        }
    }
}
