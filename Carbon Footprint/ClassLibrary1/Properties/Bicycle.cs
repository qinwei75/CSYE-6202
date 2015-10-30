using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Bicycle : Item
    {
        public override double CalculateCarbonFootprints(double time)
        {
            return 0 * time;
        }
    }
}
