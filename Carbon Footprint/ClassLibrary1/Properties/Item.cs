using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public abstract class Item
    {
        public enum ItemType
        {
            Bicycle,
            Car,
            Building
        }
        private ItemType typeName { get; set; }//Car, Bike, Building
        private double carbonOutput { get; set; }
        public abstract double CalculateCarbonFootprints(double qty);
    }
}
