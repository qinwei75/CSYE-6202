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
    public class PatientDAL
    {
        private DataTable appointmentTable = new DataTable();
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

        public DataTable getPatientTable(SqlConnection sqlcon)
        {
            DataTable patientTable = new DataTable();
            
            List<Patient> getPatientList = new List<Patient>();
            getPatientList = this.getPatientList(sqlcon);
            // create table schema
            var patientFirstName = new DataColumn("FirstName", typeof(string));
            var patientLastName = new DataColumn("LastName", typeof(string));
            var patientDOB = new DataColumn("DOB", typeof(DateTime));
            var patientID = new DataColumn("PatientID", typeof(string));



            patientTable.Columns.AddRange(new DataColumn[] { patientFirstName, patientLastName, patientDOB, patientID });

            // now that our table schema is complete, iterate over our List<T> to create rows
            foreach (var patient in getPatientList)
            {
                DataRow newRow = patientTable.NewRow();
                
                newRow["FirstName"] = patient.FirstName;
                newRow["LastName"] = patient.LastName;
                newRow["DOB"] = patient.DOB;
                newRow["PatientID"] = patient.PatientID;

                patientTable.Rows.Add(newRow);
            }
            return patientTable;
        }
    }
}
