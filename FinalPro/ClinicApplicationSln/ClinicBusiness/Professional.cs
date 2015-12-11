using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusiness
{
    public class Professional : Person, IEmployee
    {
        public enum Profession {
            Doctor,
            Nurse
        }

        public string profession { get; set; }
        public string ProfessionalID {get;set;}

    }
}
