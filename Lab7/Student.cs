using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab7
{
    public class Student : Person
    {
        private List<Student> _students = new();

        public Student(string fullname, string recordBook, string department, 
            string specification, string group, string dateOfAdmission)
        : base("")
        {
            Fullname = fullname;
            RecordBook = recordBook;
            Department = department;
            Specification = specification;
            Group = group;
            DateOfAdmission = dateOfAdmission;
        }

        public string RecordBook { get; set; }
        public string Department { get; set; }
        public string Specification { get; set; }
        public string Group { get; set; }
        public string DateOfAdmission { get; set; }
    }
}
