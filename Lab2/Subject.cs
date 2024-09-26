using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Subject
    {
        private string _name;

        public Subject(string name)
        {
            _name = name;
        }

        public string GetSubjectName()
        {
            return _name;
        }

        public void SetSubjectName(string name)
        {
            _name = name;
        }
    }
}
