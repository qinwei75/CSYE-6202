using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudentRegistrationWPF
{
    /// <summary>
    /// Interaction logic for StudentRegistrationWindow.xaml
    /// </summary>
    public partial class StudentRegistrationWindow : Window
    {
        public StudentRegistrationWindow()
        {
            LoadDepartments();
            //LoadInformation();
            //datagridStudentInformation.IsReadOnly = true;
            //LoadDefaults();
            InitializeComponent();
            GetData();
        }

        string sqlstr = "Server=WEIQIN-PC\\SQLEXPRESS;Database=StudentRegistration;Trusted_Connection=SSPI";
        private void GetData()
        {
            using (SqlConnection sqlcnn = new SqlConnection(sqlstr))
            {
                using (SqlCommand sqlcmm = sqlcnn.CreateCommand())
                {
                    sqlcmm.CommandText = "Select * from tb_student";
                    DataSet dt = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlcmm);
                    adapter.Fill(dt);
                    this.datagridStudentInformation.ItemsSource = dt.Tables[0].DefaultView;
                }
            }
        }

        private void LoadDepartments()
        {
            //comboBoxDepartment.Items.Add("");
            comboBoxDepartment.Items.Add("Information Systems");
            //comboBoxDepartment.Items.Add("International Affairs");
            //comboBoxDepartment.Items.Add("Nursing");
            //comboBoxDepartment.Items.Add("Pharmacy");
            //comboBoxDepartment.Items.Add("Professional Studies");
            //comboBoxDepartment.Items.Add("Psychology");
            //comboBoxDepartment.Items.Add("Public Administration");
            //comboBoxDepartment.SelectedIndex = 0;

            //using (SqlConnection sqlcnn = new SqlConnection(sqlstr))
            //{
            //    using (SqlCommand sqlcmm = sqlcnn.CreateCommand())
            //    {
            //        sqlcmm.CommandText = "Select * from tb_department";
            //        DataSet dt = new DataSet();
            //        SqlDataAdapter adapter = new SqlDataAdapter(sqlcmm);
            //        adapter.Fill(dt);
            //        this.comboBoxDepartment.DisplayMemberPath = "DepartmentName";
            //        this.comboBoxDepartment.ItemsSource = dt.Tables[0].DefaultView;

            //        comboBoxDepartment.SelectedIndex = 0;
            //    }
            //}


            //string con, sql;
            //con = "Server=WEIQIN-PC\\SQLEXPRESS;Database=StudentRegistration;Trusted_Connection=SSPI";
            //sql = "Select * from tb_department";
            //SqlConnection mycon = new SqlConnection(con);
            //mycon.Open();

            //SqlDataAdapter mydata = new SqlDataAdapter(sql, con);
            //DataSet myds = new DataSet();
            //mydata.Fill(myds, "tb_department");
            //comboBoxDepartment.ItemsSource = myds.Tables[0].DefaultView;
            //comboBoxDepartment.DisplayMemberPath = "DepartmentName";
            //comboBoxDepartment.SelectedIndex = 0;

            //mycon.Close();
            //comboBoxDepartment.Items.Add(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
            //    "Professional Studies", "Psychology", "Public Administration" });
        }
        private void LoadDefaults()
        {
            rbtFullTime.IsChecked = true;
            comboBoxDepartment.SelectedIndex = 0;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (textBox2.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please select a student to Edit!!!!!!!!!");
                return;
            }
            else
            {
                string enrollmentType = null;
                if (rbtFullTime.IsChecked == true)
                {
                    enrollmentType = rbtFullTime.Name.ToString().Trim();
                }
                else if (rbtPartTime.IsChecked == true)
                {
                    enrollmentType = rbtPartTime.Name.ToString().Trim();
                }
                //EditStudentRegistrationForm editForm = new EditStudentRegistrationForm();
                //EditStudentRegistrationForm editForm = new EditStudentRegistrationForm(textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), comboBoxDepartment.SelectedItem, enrollmentType.Trim());
                EditWPF editWindow = new EditWPF(textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), comboBoxDepartment.SelectedItem, enrollmentType.Trim());

                editWindow.Show();

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
                if (rbtFullTime.IsChecked == true)
                {
                    enrollmentType = rbtFullTime.Name.ToString().Trim();
                }
                else if (rbtPartTime.IsChecked == true)
                {
                    enrollmentType = rbtPartTime.Name.ToString().Trim();
                }

                //RemoveStudentRegistration removeForm = new RemoveStudentRegistration(textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), comboBoxDepartment.SelectedItem, enrollmentType.Trim());
                RemoveWPF removeForm = new RemoveWPF(textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), comboBoxDepartment.SelectedItem, enrollmentType.Trim());

                removeForm.Show();
            }
        }


        private void datagridStudentInformation_SelectionChanged(object sender, EventArgs e)
        {
            
            if (datagridStudentInformation.SelectedItems.Count > 0)
            {
                //textBox2.Text = row.Cells[0].Value.ToString();
                //textBox3.Text = row.Cells[1].Value.ToString();
                //textBox4.Text = row.Cells[2].Value.ToString();

                //comboBoxDepartment.SelectedItem = row.Cells[3].Value.ToString().Trim();

                // enrollment type selection driven by the grid itself
                //string enrollmentType = row.Cells[4].Value.ToString().Trim();
                //if (rbtFullTime.Name.ToString().Trim() == enrollmentType)
                //{
                //    rbtFullTime.IsChecked = true;
                //}
                //else if (rbtPartTime.Name.ToString().Trim() == enrollmentType)
                //{
                 //   rbtPartTime.IsChecked = true;
                //}
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetData();
        }

    }
}
