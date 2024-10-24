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
            PersonType = "айти студент";
        }

        public ITStudent(string name, int age) : base("", 0)
        {
            PersonType = "айти студент";
        }

        public override void WritePersonType()
        {
            Console.WriteLine("Я " + " айти" + PersonType);
        }

        public new void WriteStudentType()
        {
            Console.WriteLine("Я " + " айти" + PersonType);
        }
    }
}
