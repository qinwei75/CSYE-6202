using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL
{
    public class UserAccountDAL
    {
        private SqlConnection connection = null;


        public void InsertUser(UserAccount newUser)
        {
            // format and execute SQL statement
            string sql = string.Format("Insert Into tb_UserAccount" +
                "(UserName, Password, UserType) Values" +
                "('{0}', '{1}', '{2}')", newUser.UserName, newUser.Password, newUser.Type);

            // execute this insert statement using our connection
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void UpdatePassword(int userName, string password)
        {
            string sql = string.Format("Update tb_UserAccount Set Password = '{0}' Where CarID = '{1}'",
                password, userName);

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

    }
}
