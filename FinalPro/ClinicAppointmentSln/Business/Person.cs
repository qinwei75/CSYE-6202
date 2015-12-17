using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }

        public int CalculateAge()
        {
            int age = DateTime.Today.Year - DOB.Year;
            if (DateTime.Today.Month < DOB.Month ||
                (DateTime.Today.Month == DOB.Month && DateTime.Today.Day < DOB.Day))
            {
                age--;
            }
            return age;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
