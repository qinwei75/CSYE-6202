using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL
{
    public class PatientDAL
    {
        
        public List<Patient> getPatientList(SqlConnection sqlcon)
        {
            var patientList = new List<Patient>();

            string sql = "Select * From tb_Patient";
            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    patientList.Add(new Patient
                    {
                        FirstName = (string)dr["FirstName"],
                        LastName = (string)dr["LastName"],
                        DOB = (DateTime)dr["DOB"],
                        PatientID = (string)dr["PatientID"],
                    });
                }
                dr.Close();
            }

            return patientList;
        }
    }
}
