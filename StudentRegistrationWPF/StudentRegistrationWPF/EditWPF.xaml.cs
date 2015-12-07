using Business;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for EditWPF.xaml
    /// </summary>
    public partial class EditWPF : Window, IEditWPF
    {
        Student student;
        StudentList studentList;
        public EditWPF(Student student, StudentList studentList)
        {
            InitializeComponent();
            this.student = student;
            LoadDepartment();
            this.studentList = studentList;
            textBox2.Text = student.StudentID;
            textBox3.Text = student.FirstName;
            textBox4.Text = student.LastName;
            comboBoxDepartment.SelectedItem = student.Department;
            if ("Full Time" == student.EnrollmentType)
            {
                rbtFullTime.IsChecked = true;
            }
            else if ("Part Time" == student.EnrollmentType)
            {
                rbtPartTime.IsChecked = true;
            }
        }

        private void LoadDepartment()
        {
            comboBoxDepartment.Items.Add("Information Systems");
            comboBoxDepartment.Items.Add("International Affairs");
            comboBoxDepartment.Items.Add("Nursing");
            comboBoxDepartment.Items.Add("Pharmacy");
            comboBoxDepartment.Items.Add("Professional Studies");
            comboBoxDepartment.Items.Add("Psychology");
            comboBoxDepartment.Items.Add("Public Administration");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StudentRegWindow newWPF = new StudentRegWindow(studentList);
            newWPF.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            button3.IsEnabled = true;
            button2.IsEnabled = false;
            textBox2.IsEnabled = true;
            textBox3.IsEnabled = true;
            textBox4.IsEnabled = true;
            comboBoxDepartment.IsEnabled = true;
            rbtFullTime.IsEnabled = true;
            rbtPartTime.IsEnabled = true;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
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
                    string enrollmentType = null;
                    if (rbtFullTime.IsChecked == true)
                    {
                        enrollmentType = "Full Time";
                    }
                    else if (rbtPartTime.IsChecked == true)
                    {
                        enrollmentType = "Part Time";
                    }
                    button3.IsEnabled = false;
                    button2.IsEnabled = true;
                textBox2.IsEnabled = false;
                textBox3.IsEnabled = false;
                textBox4.IsEnabled = false;
                comboBoxDepartment.IsEnabled = false;
                rbtFullTime.IsEnabled = false;
                rbtPartTime.IsEnabled = false;
                student.StudentID = textBox2.Text.Trim();
                student.FirstName = textBox3.Text.Trim();
                student.LastName = textBox4.Text.Trim();
                student.Department = comboBoxDepartment.SelectedItem.ToString().Trim();
                student.EnrollmentType = enrollmentType;
                MessageBox.Show("Updated");

            }
        }
    }
}
