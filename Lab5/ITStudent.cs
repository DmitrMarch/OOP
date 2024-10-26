using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab4
{
    public class ITStudent : Student
    {
        public ITStudent(string name) : base("")
        {
            _name = name;
        }

        public ITStudent(string name, int age) : base("", 0)
        {
            _name = name;
            Age = age;
        }

        public new void WritePersonType()
        {
            Console.WriteLine("Я" + " айти " + PersonType);
        }

        public override void WriteStudentType()
        {
            Console.WriteLine("Я" + " айти " + PersonType);
        }
    }
}
