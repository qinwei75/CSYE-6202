using Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for StudentRegWindow.xaml
    /// </summary>
    public partial class StudentRegWindow : Window
    {
        StudentList studentList;
        public StudentRegWindow(StudentList studentList)
        {
            InitializeComponent();
            loadDepartment();
            this.studentList = studentList;
        }

        private void loadDepartment() {
            
            comboBoxDepartment.Items.Add("");
            comboBoxDepartment.Items.Add("Information Systems");
            comboBoxDepartment.Items.Add("International Affairs");
            comboBoxDepartment.Items.Add("Nursing");
            comboBoxDepartment.Items.Add("Pharmacy");
            comboBoxDepartment.Items.Add("Professional Studies");
            comboBoxDepartment.Items.Add("Psychology");
            comboBoxDepartment.Items.Add("Public Administration");
            comboBoxDepartment.SelectedIndex = 0;
            populateTable();
        }
        public void populateTable() {
            try
            {
                this.StudentInforTable.ItemsSource = studentList.getSList;
            }
            catch (Exception e)
            {

            }
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            NewWPF newWPF = new NewWPF();
            this.Close();
            newWPF.Show();
        }

        private void btnRemove_Click_1(object sender, RoutedEventArgs e)
        {
            RemoveWPF removeWPF = new RemoveWPF();
            this.Close();
            removeWPF.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditWPF editWPF = new EditWPF();
            this.Close();
            editWPF.Show();
        }

        private void table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student selectedstudent = (Student)this.StudentInforTable.SelectedItem;
            textBox2.Text = selectedstudent.StudentID;
            textBox3.Text = selectedstudent.FirstName;
            textBox4.Text = selectedstudent.LastName;
            comboBoxDepartment.SelectedValue = selectedstudent.Department.ToString().Trim();

            if ("Full Time" == selectedstudent.EnrollmentType.ToString().Trim())
            {
                rbtFullTime.IsChecked = true;
  
            }
            else if ("Part Time" == selectedstudent.EnrollmentType.ToString().Trim())
            {
                rbtPartTime.IsChecked = true;

            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            populateTable();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)//magic
        {
            populateTable();
        }
    }
}
