using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL
{
    public class VisitReasonDAL
    {
        public List<VisitReason> getPatientList(SqlConnection sqlcon)
        {
            var visitReasonList = new List<VisitReason>();

            string sql = "Select * From tb_VisitReason";
            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    visitReasonList.Add(new VisitReason
                    {
                        ReasonID = (int)dr["ReasonID"],
                        Reason = (string)dr["Reason"],
                        Cost = (int)dr["Cost"]
                    });
                }
                dr.Close();
            }

            return visitReasonList;
        }

        public void InsertVisitReason(VisitReason newVisitReason, SqlConnection sqlcon)
        {
            // format and execute SQL statement
            string sql = string.Format("Insert Into tb_VisitReason" +
                "((select case when max(id) is null then 1 else max(ReasonID)+1 end from tb_VisitReason), Reason, Cost) Values" +
                "('{0}', '{1}', '{2}')",
                newVisitReason.ReasonID,
                newVisitReason.ReasonID,
                newVisitReason.Cost
                );
            // execute this insert statement using our connection
            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {
                command.ExecuteNonQuery();
            }
        }

        public void UpdateVisitReason(int ReasonID, string newReason, string newCost, SqlConnection sqlcon)
        {
            string sql = string.Format("Update tb_VisitReason Set Reason = '{0}', Cost = '{1}'  Where ReasonID = '{2}'",
                newReason, newCost, ReasonID);

            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {
                command.ExecuteNonQuery();
            }
        }

        public void DeleteVisitReason(string id, SqlConnection sqlcon)
        {
            // get ID of the car to delete, then try
            string sql = string.Format("Delete from tb_Appointment where CarID = '{0}'", id);

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
