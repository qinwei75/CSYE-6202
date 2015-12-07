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
    /// Interaction logic for NewWPF.xaml
    /// </summary>
    public partial class NewWPF : Window
    {
        StudentList studentList;
        public NewWPF(StudentList studentList)
        {
            InitializeComponent();
            LoadDefaults();
            LoadDepartment();
            this.studentList = studentList;
        }
        private void LoadDefaults()
        {
            rbtFullTime.IsChecked = true;
            comboBoxDepartment.SelectedIndex = 0;
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
        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBoxDepartment.SelectedIndex = 0;
            rbtFullTime.IsChecked = true;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
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
                Student s = new Student(textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), comboBoxDepartment.SelectedItem.ToString().Trim(), enrollmentType);
                studentList.addStudent(s);
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBoxDepartment.SelectedIndex = 0;
                rbtFullTime.IsChecked = true;
                MessageBox.Show("New Stuent Added!");
            }

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            StudentRegWindow newWPF = new StudentRegWindow(studentList);
            newWPF.Show();
            this.Close();
        }
    }
}
