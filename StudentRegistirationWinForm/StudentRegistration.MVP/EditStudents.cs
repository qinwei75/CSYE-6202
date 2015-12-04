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
    public partial class EditStudents : Form, IEditStudentRegistrationForm
    {
        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")] //API
        extern static System.IntPtr GetSystemMenu(System.IntPtr hWnd, System.IntPtr bRevert);
        [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
        extern static int RemoveMenu(IntPtr hMenu, int nPos, int flags);
        static int MF_BYPOSITION = 0x400;
        static int MF_REMOVE = 0x1000;
        public EditStudents()
        {
            InitializeComponent();
            LoadDepartments();
            RemoveMenu(GetSystemMenu(Handle, IntPtr.Zero), 0, MF_BYPOSITION | MF_REMOVE);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void LoadDepartments()
        {
            comboBoxDepartment.Items.AddRange(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }

        public EditStudents(string studentID, string firstName, string lastName, object department, string enrollmentType)
            : this()
        {
            textBox2.Text = studentID;
            textBox3.Text = firstName;
            textBox4.Text = lastName;
            comboBoxDepartment.SelectedItem = department;
            if (rbtFullTime.Text.Trim() == enrollmentType)
            {
                rbtFullTime.Checked = true;
            }
            else if (rbtPartTime.Text.Trim() == enrollmentType)
            {
                rbtPartTime.Checked = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == String.Empty ||
                             textBox3.Text.Trim() == String.Empty ||
                             textBox4.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please fill in all the fields!!!!");
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update this student?", "Edit Registration Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string enrollmentType = null;
                    if (rbtFullTime.Checked == true)
                    {
                        enrollmentType = rbtFullTime.Text.Trim();
                    }
                    else if (rbtPartTime.Checked == true)
                    {
                        enrollmentType = rbtPartTime.Text.Trim();
                    }
                    string con, sql;
                    con = "Server=WEIQIN-PC\\SQLEXPRESS;Database=StudentRegistration;Trusted_Connection=SSPI";
                    SqlConnection mycon = new SqlConnection(con);
                    mycon.Open();
                    //check if ID is exist
                    //Insert sql
                    sql = "Update tb_student set FirstName = '" + textBox3.Text.Trim() + "' , LastName = '" + textBox4.Text.Trim() + "' , Department = '" + comboBoxDepartment.SelectedItem.ToString() + "' , enrollmentType = '" + enrollmentType + "'  where StudentID = '" + textBox2.Text.Trim() + "' ";
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
    }
}
