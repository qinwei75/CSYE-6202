using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class StudentList
    {
        private Student student;
        List<Student> studentList = new List<Student>();

        public List<Student> getSList {
            get { return studentList; }
        }
        public void addStudent(Student s) {
            studentList.Add(s);
        }

        public void deleteStudent(Student s) {
            studentList.Remove(s);
        }
    }
}
