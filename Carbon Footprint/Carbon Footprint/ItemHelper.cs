using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbon_Footprint
{
    public class ItemHelper
    {
        public static bool ValidateItemType(string enteredType, ref Program.ItemType itemType)
        {
            if (enteredType == "")
            {
                return false;
            }
            if (enteredType == "Bicycle")
            {
                itemType = Program.ItemType.Bicycle;
                return true;
            }
            else if (enteredType == "Car")
            {
                itemType = Program.ItemType.Car;
                return true;
            }
            else if (enteredType == "Building")
            {
                itemType = Program.ItemType.Building;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
