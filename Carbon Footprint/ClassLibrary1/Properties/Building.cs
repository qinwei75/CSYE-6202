using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class Building : Item
    {
        public override double CalculateCarbonFootprints(double ammount)
        {
            return 50 * ammount;
        }
    }
}
