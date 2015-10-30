using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Building : Item
    {
        public override double CalculateCarbonFootprints(double area)
        {
            return 50 * area;
        }
    }
}
