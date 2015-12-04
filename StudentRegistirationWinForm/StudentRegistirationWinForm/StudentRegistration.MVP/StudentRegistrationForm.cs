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
            
            LoadDepartments();
            LoadInformation();
            datagridStudentInformation.ReadOnly = true;
            LoadDefaults();

        }
        private void LoadDepartments()
        {
            comboBoxDepartment.Items.AddRange(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }
        private void LoadDefaults()
        {
            rbtFullTime.Select();
            comboBoxDepartment.SelectedIndex = 0;
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
            datagridStudentInformation.DataSource = myds.Tables["tb_student"];

            mycon.Close();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            Dispose();
            IView view = new NewStudentRegistrationForm();
            IModel model = new Model();
            var present = new Present(model, view);

            present.ShowNewStudent();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text.Trim() == String.Empty) {
                MessageBox.Show("Please select a student to Edit!!!!!!!!!");
                return;
            }
            else
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
                //EditStudentRegistrationForm editForm = new EditStudentRegistrationForm();
                //EditStudentRegistrationForm editForm = new EditStudentRegistrationForm(textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), comboBoxDepartment.SelectedItem, enrollmentType.Trim());
                IView view = new EditStudents(textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), comboBoxDepartment.SelectedItem, enrollmentType.Trim());
                IModel model = new Model();
                var present = new Present(model, view);
                
                this.Dispose();
                present.ShowEditForm();
                //editForm.Show();

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please select a student to Delete!!!!");
                return;
            }
            else
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
                
                //RemoveStudentRegistration removeForm = new RemoveStudentRegistration(textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), comboBoxDepartment.SelectedItem, enrollmentType.Trim());
                IView view = new RemoveStudentRegistration(textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), comboBoxDepartment.SelectedItem, enrollmentType.Trim());
                IModel model = new Model();
                var present = new Present(model, view);
                this.Dispose();
                present.ShowRemoveForm();
                
                //removeForm.Show();
            }
        }


        private void datagridStudentInformation_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in datagridStudentInformation.SelectedRows)
            {
                textBox2.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                textBox4.Text = row.Cells[2].Value.ToString();

                comboBoxDepartment.SelectedItem = row.Cells[3].Value.ToString().Trim();

                // enrollment type selection driven by the grid itself
                string enrollmentType = row.Cells[4].Value.ToString().Trim();
                if (rbtFullTime.Text.Trim() == enrollmentType)
                {
                    rbtFullTime.Checked = true;
                }
                else if (rbtPartTime.Text.Trim() == enrollmentType)
                {
                    rbtPartTime.Checked = true;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInformation();
        }
    }
}
