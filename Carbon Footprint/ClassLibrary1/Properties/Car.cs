using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Car : Item
    {
        public override double CalculateCarbonFootprints(double gasQty)
        {
            return 20 * gasQty;
        }
    }
}
