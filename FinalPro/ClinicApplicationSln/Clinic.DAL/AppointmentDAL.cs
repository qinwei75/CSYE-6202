using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL
{
    public class AppointmentDAL
    {
        public List<Appointment> getAppointments(SqlConnection sqlcon)
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
                        ProfessionalID=(string)dr["ProfessionalID"],
                        VisitDate = (DateTime)dr["VisitDate"],
                        LastUpdateTime = (DateTime)dr["LastUpdateTime"],
                        Reason = (string)dr["Reason"],
                        Cost  = (int)dr["Cost"],
                        Location = (string)dr["Location"]
                    });
                }
                dr.Close();
            }
            return appointmentList;
        }

        public void InsertAppointment(Appointment newAppointment, SqlConnection sqlcon)
        {
            // format and execute SQL statement
            string sql = string.Format("Insert Into tb_Appointment" +
                "(AppointmentID, PatientID, ProfessionalID, VisitDate,LastUpdateTime, Reason, Cost,Location) Values" +
                "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", 
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

        public void UpdateTime(string appointmentID, string newVisitDate,SqlConnection sqlcon)
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
