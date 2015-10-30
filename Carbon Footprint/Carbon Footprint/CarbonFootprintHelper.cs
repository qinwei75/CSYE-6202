using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbon_Footprint
{
    public class CarbonFootprintHelper
    {
        public static bool ValidateItemType(string enteredType, ref ItemType itemType)
        {
            if (enteredType == "Male")
            {
                itemType = ItemType;
                return true;
            }
            else if (enteredGender == "Female")
            {
                patientGender = Gender.Female;
                return true;
            }
            else if (enteredGender == "Unspecified")
            {
                patientGender = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
