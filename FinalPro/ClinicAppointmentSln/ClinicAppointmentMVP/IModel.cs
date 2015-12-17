using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppointment.MVP
{
    public interface IModel 
    {
        void Add();
        void Remove();
        void Edit();
    }
}
