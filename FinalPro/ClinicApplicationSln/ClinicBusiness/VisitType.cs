using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusiness { 

    public class VisitType
    {

    public enum Profession
    {
        Doctor,
        Nurse
    }
        public string VisitTypeID { get; set; }
        public string Reason { get; set; }
        public string Cost { get; set; }
        
    }
}
