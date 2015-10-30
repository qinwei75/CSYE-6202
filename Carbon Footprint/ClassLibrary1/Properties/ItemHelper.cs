using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ItemHelper
    {

        public static bool ValidateQty(string qtyInString, ref double qty)
        {
            //0 is not allowed
            try { Convert.ToInt32(qtyInString); }
            catch (Exception) { return false; }
            double q = Convert.ToInt32(qtyInString);
            if (q > 0)
            {
                qty = q;
                return true;
            }
            else
            {
                return false;
            }

        }
    }

}
