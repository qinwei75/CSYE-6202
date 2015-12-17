using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class VisitReason
    {
        public string ReasonID { get; set; }
        public string Reason { get; set; }
        public int Cost { get; set; }

        public override string ToString()
        {
            return Reason;
        }
    }
}
