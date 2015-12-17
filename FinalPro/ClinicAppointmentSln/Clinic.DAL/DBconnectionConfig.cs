using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL
{
    public class DBconnectionConfig
    {

        SqlConnection con = null;
        public string StringBuilder()
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.InitialCatalog = "Clinic";
            connectionStringBuilder.DataSource = @"WEIQIN-PC\SQLEXPRESS";
            connectionStringBuilder.ConnectTimeout = 30;
            connectionStringBuilder.IntegratedSecurity = true;
            return connectionStringBuilder.ConnectionString;
        }
        public void OpenConnection()
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = this.StringBuilder();
                con.Open();
            }
            catch (Exception ex) {
                Console.WriteLine("Connection problem!");
                Console.ReadLine();
            }
        }

        public void CloseConnection()
        {
            con.Close();
        }

        public SqlDataAdapter getUserAccount()
        {
            string con = "Server=WEIQIN-PC\\SQLEXPRESS;Database=Clinic;Trusted_Connection=SSPI";
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();
            string sql = "Select * from tb_UserAccount";
            SqlDataAdapter mydata = new SqlDataAdapter(sql, mycon);
            return mydata;
            mycon.Close();
        }

        public SqlDataAdapter getAppointmentTable()
        {
            string con = "Server=WEIQIN-PC\\SQLEXPRESS;Database=Clinic;Trusted_Connection=SSPI";
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();
            string sql = "Select * from tb_Appointment";
            SqlDataAdapter mydata = new SqlDataAdapter(sql, mycon);
            return mydata;
            mycon.Close();
        }

        public SqlDataAdapter getPatientTable()
        {
            string con = "Server=WEIQIN-PC\\SQLEXPRESS;Database=Clinic;Trusted_Connection=SSPI";
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();
            string sql = "Select * from tb_Patient";
            SqlDataAdapter mydata = new SqlDataAdapter(sql, mycon);
            return mydata;
            mycon.Close();
        }
        public SqlDataAdapter getProfessional()
        {
            string con = "Server=WEIQIN-PC\\SQLEXPRESS;Database=Clinic;Trusted_Connection=SSPI";
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();
            string sql = "Select * from tb_Professional";
            SqlDataAdapter mydata = new SqlDataAdapter(sql, mycon);
            return mydata;
            mycon.Close();
        }
        public SqlDataAdapter getType()
        {
            string con = "Server=WEIQIN-PC\\SQLEXPRESS;Database=Clinic;Trusted_Connection=SSPI";
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();
            string sql = "Select Reason from tb_VisitReason";
            SqlDataAdapter mydata = new SqlDataAdapter(sql, mycon);
            return mydata;
            mycon.Close();
        }
    }
}
