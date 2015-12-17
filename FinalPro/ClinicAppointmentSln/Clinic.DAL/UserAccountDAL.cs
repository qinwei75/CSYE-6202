using Business;
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
        public List<UserAccount> getProfessionalList(SqlConnection sqlcon)
        {
            var userAccountList = new List<UserAccount>();

            string sql = "Select * From tb_Professional";
            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    userAccountList.Add(new UserAccount
                    {
                        UserName = (string)dr["UserName"],
                        Password = (string)dr["Password"],
                        Type = (string)dr["UserType"]
                    });
                }
                dr.Close();
            }

            return userAccountList;
        }

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
        public void DeleteUserAccount(string userName, SqlConnection sqlcon)
        {
            // get ID of the car to delete, then try
            string sql = string.Format("Delete from tb_UserAccount where UserName = '{0}'", userName);

            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Sql related exception occurred. Exception details: {0}", e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("A generic exception occurred. Exception details: {0}", e.Message);
                }
            }
        }
    }
}
