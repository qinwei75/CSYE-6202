using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ItemHelper
    {
        public static bool ValidateItemType(string enteredType, ref Item.ItemType itemType)
        {
            if (enteredType == "")
            {
                return false;
            }
            if (enteredType == "Bicycle")
            {
                itemType = Item.ItemType.Bicycle;
                return true;
            }
            else if (enteredType == "Car")
            {
                itemType = Item.ItemType.Car;
                return true;
            }
            else if (enteredType == "Building")
            {
                itemType = Item.ItemType.Building;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidateNumber(string enteredType, ref Item.ItemType itemType)
        {
            if (enteredType == "")
            {
                return false;
            }
            if (enteredType == "Bicycle")
            {
                itemType = Item.ItemType.Bicycle;
                return true;
            }
            else if (enteredType == "Car")
            {
                itemType = Item.ItemType.Car;
                return true;
            }
            else if (enteredType == "Building")
            {
                itemType = Item.ItemType.Building;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
