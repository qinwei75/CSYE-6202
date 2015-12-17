using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1
namespace Clinic.DAL
{
    
    public class AppointmentDAL
    {
        private DataTable appointmentTable = new DataTable();

        public List<Appointment> getAppointmentsList(SqlConnection sqlcon)
        {
            var appointmentList = new List<Appointment>();

            string sql = "Select * From tb_Appointment";
            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    appointmentList.Add(new Appointment
                    {
                        AppointmentID = (string)dr["AppointmentID"],
                        PatientID = (string)dr["PatientID"],
                        ProfessionalID = (string)dr["ProfessionalID"],
                        VisitDate = (DateTime)dr["VisitDate"],
                        LastUpdateTime = (DateTime)dr["LastUpdateTime"],
                        Reason = (string)dr["Reason"],
                        Cost = (int)dr["Cost"],
                        Location = (string)dr["Location"]
                    });
                }
                dr.Close();
            }
            return appointmentList;
        }

        public DataTable getAppointmentsTable(SqlConnection sqlcon) {
            DataTable appointmentTable = new DataTable();
            List<Appointment> appointmentList = new List<Appointment>();
            appointmentList = getAppointmentsList(sqlcon);
            // create table schema
            var appIDColumn = new DataColumn("AppointmentID", typeof(string));
            var appPatientNameColumn = new DataColumn("PatientID", typeof(string));
            var appProfessionalNameColumn = new DataColumn("ProfessionalID", typeof(string));
            var appVisitDateColumn = new DataColumn("VisitDate", typeof(string));
            var appLastUpdateTimeColumn = new DataColumn("LastUpdateTime", typeof(string));
            var appVisitReasonColumn = new DataColumn("VisitReason", typeof(string));
            var appCost = new DataColumn("Cost", typeof(string));
            var appLocation = new DataColumn("Location", typeof(string));


            appointmentTable.Columns.AddRange(new DataColumn[] { appIDColumn, appPatientNameColumn, appProfessionalNameColumn, appVisitDateColumn, appLastUpdateTimeColumn, appVisitReasonColumn, appCost, appLocation });

            // now that our table schema is complete, iterate over our List<T> to create rows
            foreach (var appointment in appointmentList)
            {
                DataRow newRow = appointmentTable.NewRow();
                newRow["AppointmentID"] = appointment.AppointmentID;
                newRow["PatientID"] = appointment.PatientID;
                newRow["ProfessionalID"] = appointment.ProfessionalID;
                newRow["VisitDate"] = appointment.VisitDate;
                newRow["LastUpdateTime"] = appointment.LastUpdateTime;
                newRow["VisitReason"] = appointment.Reason;
                newRow["Cost"] = appointment.Cost;
                newRow["Location"] = appointment.Location;
                appointmentTable.Rows.Add(newRow);
            }
            return appointmentTable;
        }
        public void InsertAppointment(Appointment newAppointment, SqlConnection sqlcon)
        {
            // format and execute SQL statement
            string sql = string.Format("Insert Into tb_Appointment" +
                "(AppointmentID, PatientID, ProfessionalID, VisitDate,LastUpdateTime, Reason, Cost,Location) Values" +
                "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}','Dana 429')",
                newAppointment.AppointmentID,
                newAppointment.PatientID,
                newAppointment.ProfessionalID,
                newAppointment.VisitDate,
                newAppointment.LastUpdateTime,
                newAppointment.Reason,
                newAppointment.Cost,
                newAppointment.Location
                );

            // execute this insert statement using our connection
            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {
                command.ExecuteNonQuery();
            }
        }

        public bool checkIfAppointmentIDExist(string newAppointmentID, SqlConnection sqlcon) {
            string sql = string.Format("Select count(*) as number  From tb_Appointment where AppointmentID ='{0}'", newAppointmentID);
            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {
                
                SqlDataReader Dr = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (Dr.Read())
                {
                    int count = int.Parse(Dr["number"].ToString().Trim());
                    if (count  >0) { return true; }
                }

                Dr.Close();

            }
            return false;
        }


        public void UpdateTime(string appointmentID, string newVisitDate, SqlConnection sqlcon)
        {
            string sql = string.Format("Update tb_Appointment Set VisitDate = '{0}' Where AppointmentID = '{1}'",
                newVisitDate, appointmentID);

            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {
                command.ExecuteNonQuery();
            }
        }

        public void DeleteAppointment(string id, SqlConnection sqlcon)
        {
            // get ID of the car to delete, then try
            string sql = string.Format("Delete from tb_Appointment where AppointmentID = '{0}'", id);

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
