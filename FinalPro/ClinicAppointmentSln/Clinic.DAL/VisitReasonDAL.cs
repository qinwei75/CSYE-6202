using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL
{
    public class VisitReasonDAL
    {
        public List<VisitReason> getVisitReason(SqlConnection sqlcon)
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
                        ReasonID = (string)dr["ReasonID"],
                        Reason = (string)dr["Reason"],
                        Cost = (int)dr["Cost"]
                    });
                }
                dr.Close();
            }

            return visitReasonList;
        }
        public DataTable getVisitReasonTable(SqlConnection sqlcon)
        {
            DataTable visitReasonTable = new DataTable();
            List<VisitReason> visitReasonList = new List<VisitReason>();
            visitReasonList = this.getVisitReason(sqlcon);
            // create table schema
            var visitReasonIDCOL = new DataColumn("ReasonID", typeof(string));
            var visitReasonCOL = new DataColumn("Reason", typeof(string));
            var costCOL = new DataColumn("Cost", typeof(int));



            visitReasonTable.Columns.AddRange(new DataColumn[] { visitReasonIDCOL, visitReasonCOL, costCOL });

            // now that our table schema is complete, iterate over our List<T> to create rows
            foreach (var visitReason in visitReasonList)
            {
                DataRow newRow = visitReasonTable.NewRow();
                newRow["ReasonID"] = visitReason.ReasonID;
                newRow["Reason"] = visitReason.Reason;
                newRow["Cost"] = visitReason.Cost.ToString();


                visitReasonTable.Rows.Add(newRow);
            }
            return visitReasonTable;
        }
        public string getNextVisitID(SqlConnection sqlcon)
        {
            string sql = string.Format("Select max(ReasonID) as number From tb_VisitReason");

            
            string newID = null;
            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {

                SqlDataReader dr = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    int count = int.Parse(dr["number"].ToString().Trim())+1;
                    newID = count.ToString().Trim();
                }
                dr.Close();

                return newID;
            }



        }
        public void InsertVisitReason(VisitReason newVisitReason, SqlConnection sqlcon)
        {
            // format and execute SQL statement
            string sql = string.Format("Insert Into tb_VisitReason" +
                "(ReasonID, Reason, Cost) Values" +
                "('{0}', '{1}', '{2}')",
                newVisitReason.ReasonID,
                newVisitReason.Reason,
                newVisitReason.Cost
                );
            // execute this insert statement using our connection
            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {
                command.ExecuteNonQuery();
            }
        }

        public void UpdateVisitReason(string ReasonID, string newReason, string newCost, SqlConnection sqlcon)
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
            string sql = string.Format("Delete from tb_VisitReason where ReasonID = '{0}'", id);

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
