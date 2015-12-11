using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusiness
{
    public class AppointmentList
    {
        List<Appointment> appointmentList= new List<Appointment>();
        public List<Appointment> getAList
        {
            get { return appointmentList; }
        }
        public void addStudent(Appointment a)
        {
            appointmentList.Add(a);
        }

        public void deleteStudent(Appointment a)
        {
            appointmentList.Remove(a);
        }

        public int getMaxAppointmentNumber() {


            return 0;
        }
    }

}
