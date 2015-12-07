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
    /// Interaction logic for RemoveWPF.xaml
    /// </summary>
    public partial class RemoveWPF : Window
    {
        Student student;
        StudentList studentList;
        public RemoveWPF(Student student, StudentList studentList)
        {
            InitializeComponent();
            LoadDepartment();
            this.student = student;
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
        private void button_Click(object sender, RoutedEventArgs e)
        {
            StudentRegWindow newWPF = new StudentRegWindow(studentList);
            newWPF.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            studentList.deleteStudent(student);
            MessageBox.Show("Student Removed");
            StudentRegWindow newWPF = new StudentRegWindow(studentList);
            newWPF.Show();
            this.Close(); 
        }
    }
}
