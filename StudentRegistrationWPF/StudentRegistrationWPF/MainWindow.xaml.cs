using Business;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentRegistrationWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int lefttime = 3;
        public MainWindow()
        {
            
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            
            string con, sql;
            string str_username = txtUsername.Text;
            string str_pw = txtUsername.Text;
            con = "Server=WEIQIN-PC\\SQLEXPRESS;Database=StudentRegistration;Trusted_Connection=SSPI";
            sql = "Select * from tb_user where UserName =@username and Password =@password";
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();


            SqlCommand cmd = new SqlCommand(sql, mycon);
            cmd.Parameters.Add(new SqlParameter("@username", str_username));
            cmd.Parameters.Add(new SqlParameter("@password", str_pw));
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows == true)
            {
                
                StudentList sl = new StudentList();
                StudentInfoRandom.Randomizer(sl);
                
                StudentRegWindow view = new StudentRegWindow(sl);
                view.Show();
                this.Close();

            }
            else
            {
                lefttime--;

                if (lefttime <= 0)
                {
                    Environment.Exit(1);
                }
                MessageBox.Show("Usename and password are not match! You have " + lefttime + " time(s) left!");
            }
            dataReader.Close();
        }
    }
}
