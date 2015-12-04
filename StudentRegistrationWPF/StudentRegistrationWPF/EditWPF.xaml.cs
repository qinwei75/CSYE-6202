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
        public EditWPF()
        {
            InitializeComponent();
        }

        public EditWPF(string studentID, string firstName, string lastName, object department, string enrollmentType)
            : this()
        {
            textBox2.Text = studentID;
            textBox3.Text = firstName;
            textBox4.Text = lastName;
            comboBoxDepartment.SelectedItem = department;
            if (rbtFullTime.Name.ToString().Trim() == enrollmentType)
            {
                rbtFullTime.IsChecked = true;
            }
            else if (rbtPartTime.Name.ToString().Trim() == enrollmentType)
            {
                rbtPartTime.IsChecked = true;
            }
        }
    }
}
