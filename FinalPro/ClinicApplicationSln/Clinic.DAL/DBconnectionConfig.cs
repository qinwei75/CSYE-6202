using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusiness
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
            con = new SqlConnection();
            con.ConnectionString = this.StringBuilder();
            con.Open();
        }

        public void CloseConnection()
        {
            con.Close();
        }

        public SqlDataAdapter getUserAccount() {
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

    }
}
