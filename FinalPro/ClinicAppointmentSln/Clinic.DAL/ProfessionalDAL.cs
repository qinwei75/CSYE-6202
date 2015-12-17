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
                        active = (string)dr["Active"]

                    });
                }
                dr.Close();
            }

            return professinalList;
        }
        public DataTable getProfessionalTable(SqlConnection sqlcon)
        {
            DataTable professionalTable = new DataTable();
            List<Professional> professionalList = new List<Professional>();
            professionalList = this.getProfessionalList(sqlcon);
            // create table schema
            var professionalFirstName = new DataColumn("FirstName", typeof(string));
            var professionalLastName = new DataColumn("LastName", typeof(string));
            var professionalDOB = new DataColumn("DOB", typeof(string));
            var professionalID = new DataColumn("ProfessionalID", typeof(string));
            var professionType    = new DataColumn("Profession", typeof(string));
            var professionActive = new DataColumn("Active", typeof(string));



            professionalTable.Columns.AddRange(new DataColumn[] { professionalFirstName, professionalLastName, professionalDOB, professionalID, professionType, professionActive });

            // now that our table schema is complete, iterate over our List<T> to create rows
            foreach (var professional in professionalList)
            {
                DataRow newRow = professionalTable.NewRow();
                newRow["FirstName"] = professional.FirstName;
                newRow["LastName"] = professional.LastName;
                newRow["DOB"] = professional.DOB.ToString("yyyy/MM/dd");
                newRow["ProfessionalID"] = professional.ProfessionalID;
                newRow["Profession"] = professional.profession;
                newRow["Active"] = professional.active;

                professionalTable.Rows.Add(newRow);
            }
            return professionalTable;
        }

        public string getNextProfessionID(string profession, SqlConnection sqlcon) {
            string sql = string.Format("Select count(*) as number From tb_Professional where Profession = '{0}'",
                profession);

            string head;
            string newProfessionID= null;
            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {

                SqlDataReader dr = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    int count = int.Parse(dr["number"].ToString().Trim());
                    if (profession == Professional.Profession.Doctor.ToString().Trim())
                    {
                        head = "D";
                        newProfessionID = head + (1000 + count + 1);

                    }
                    if (profession == Professional.Profession.Nurse.ToString().Trim())
                    {
                        head = "N";
                        newProfessionID = head + (1000 + count + 1);
                    }
                }
                dr.Close();

                return newProfessionID;
            }
            


        }
        public void InsertProfessional(Professional professional, SqlConnection sqlcon)
        {
            // format and execute SQL statement
            string sql = string.Format("Insert Into tb_Professional" +
                "(FirstName, LastName, DOB, ProfessionalID,Profession, Active) Values" +
                "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                professional.FirstName,
                professional.LastName,
                professional.DOB,
                professional.ProfessionalID,
                professional.profession,
                professional.active
                );

            // execute this insert statement using our connection
            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {
                command.ExecuteNonQuery();
            }
        }
        public void DeleteProfessional(string professionalID, SqlConnection sqlcon)
        {
            string sql = string.Format("Update tb_Professional Set Active = 'DisActive' Where ProfessionalID = '{0}'",
                professionalID);

            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {
                command.ExecuteNonQuery();
            }
        }
        public void UpdateProfessional(string professionalID, string Profession, string firstName, string lastName, DateTime dob, SqlConnection sqlcon)
        {
            string sql = string.Format("Update tb_Professional Set FirstName = '{1}', LastName = '{2}', DOB = '{3}',Profession = '{4}' Where ProfessionalID = '{0}'",
                professionalID, firstName, lastName, dob, Profession);

            using (SqlCommand command = new SqlCommand(sql, sqlcon))
            {
                command.ExecuteNonQuery();
            }
        }

    }
}
