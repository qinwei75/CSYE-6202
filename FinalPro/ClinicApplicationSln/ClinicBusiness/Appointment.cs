using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusiness
{
    public class Appointment
    {
        //public enum VisitType
        //{
        //    Other = 0,
        //    Stomatology = 1,
        //    Orthopedic = 2,
        //    Psychiatry = 3,
        //    Internal_medicine = 4
        //}
        public string AppointmentID {get; set;}
        public string PatientID { get; set; }
        public string ProfessionalID { get; set; }
        public DateTime VisitDate { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public string Reason { get; set; }
        public int Cost { get; set; }
        public string Location { get; set; }


    }
}
