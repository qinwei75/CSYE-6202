using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Professional : Person, IEmployee
    {
        public enum Profession
        {
            Doctor,
            Nurse
        }
        public enum Active
        {
            Active,
            DisActive
        }

        public string profession { get; set; }
        public string ProfessionalID { get; set; }
        public string active { get; set; }
    }
}
