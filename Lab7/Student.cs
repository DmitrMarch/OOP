using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6
{
    public class Student : Person
    {
        private string _recordBook;
        private string _department;
        private string _specification;
        private string _group;
        private string _dateOfAdmission;

        public Student(string fullname, string recordBook, string department, 
            string specification, string group, string dateOfAdmission)
        : base("")
        {
            this.Fullname = fullname;
            this._recordBook = recordBook;
            this._department = department;
            this._specification = specification;
            this._group = group;
            this._dateOfAdmission = dateOfAdmission;
        }

        public string RecordBook 
        {
            get { 
                return _recordBook;
            }
            set { 
                _recordBook = value;
            }
        }

        public string Department
        {
            get
            {
                return _department;
            }
            set
            {
                _department = value;
            }
        }

        public string Specification
        {
            get
            {
                return _specification;
            }
            set
            {
                _specification = value;
            }
        }

        public string Group
        {
            get
            {
                return _group;
            }
            set
            {
                _group = value;
            }
        }

        public string DateOfAdmission
        {
            get
            {
                return _dateOfAdmission;
            }
            set
            {
                _dateOfAdmission = value;
            }
        }

    }
}
