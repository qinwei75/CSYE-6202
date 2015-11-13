using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public abstract class Item
    {
        public string type { get; set; } //CAR BIKE BUILDING
        public double ammount { get; set; }
 
        public double carbonOutput { get; set; }

        public abstract double CalculateCarbonFootprints(double ammount);
    }
}
