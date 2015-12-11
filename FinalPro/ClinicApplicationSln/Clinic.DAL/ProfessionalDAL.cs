using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL
{
    public class ProfessionalDAL
    {
        public List<Professional> getProfessionalList(SqlConnection sqlcon)
        {
            var professinalList = new List<Professional>();

            string sql = "Select * From tb_Professional";
            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    professinalList.Add(new Professional
                    {
                        FirstName = (string)dr["FirstName"],
                        LastName = (string)dr["LastName"],
                        DOB = (DateTime)dr["DOB"],
                        ProfessionalID = (string)dr["ProfessionalID"],
                        profession = (string)dr["Profession"],

                    });
                }
                dr.Close();
            }

            return professinalList;
        }
    }
}
