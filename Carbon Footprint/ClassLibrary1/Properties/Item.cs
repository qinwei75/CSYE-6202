using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public abstract class Item
    {
        private string type { get; set; }
        private double ammount { get; set; }
        //private const ...
        private double carbonOutput { get; set; }

        public abstract double CalculateCarbonFootprints(double ammount);
    }
}
