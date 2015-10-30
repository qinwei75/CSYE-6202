using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class Car : Item
    {
        public override double CalculateCarbonFootprints(double qty)
        {
            return qty * 20;
        }
    }
}
