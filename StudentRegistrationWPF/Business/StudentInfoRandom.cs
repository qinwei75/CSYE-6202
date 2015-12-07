using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class StudentInfoRandom
    {
        //Student ID, First Name, Last Name, Department, Enrollment Type
            //111-11-1212, Bart, Simpson, Information Systems, Full Time
            //123-12-1234, Maggie, Simpson, International Affairs, Part Time
            //133-33-2234, Lisa, Simpson, Nursing, Part Time
            //255-33-3456, Homer, Simpson, Pharmacy, Part Time
            //366-77-8888, Otto, Mann, Professional Studies, Full Time
            //166-12-1111, Dr.Marvin, Monroe, Psychology, Full Time
            //333-44-5566, Radioactive, Man, Public Administration, Part Time
        public static string[] studentID = { "111-11-1212", "123-12-1234", "133-33-2234", "255-33-3456", "366-77-8888", "166-12-1111", "333-44-5566" };
        public static string[] firstname = { "Bart", "Maggie", "Dona", "Homer", "Micky", "Dr.Marvin", "Radioactive" };
        public static string[] lastname = { "Simpson", "Mann", "Mouse", "Lee", "Louis", "Jordan", "Duck" };
        public static string[] department = { "Information Systems", "International Affairs", "Nursing", "Pharmacy", "Professional Studies", "Psychology", "Public Administration" };
        public static string[] enrollmentType = { "Full Time", "Part Time" };
        
        public static ObservableCollection<Student> Randomizer(StudentList sl)
        {
            Random ran = new Random();
            
            ObservableCollection<Student> result = new ObservableCollection<Student>();
            for (int i = 0; i < 10; i++)
            {
                Student student = new Student(studentID[ran.Next(0, 7)], 
                                        firstname[ran.Next(0, 7)], 
                                        lastname[ran.Next(0, 7)], 
                                        department[ran.Next(0, 7)],
                                        enrollmentType[ran.Next(0, 2)]);
                sl.addStudent(student);
            }
            return result;
        }
    }
}
