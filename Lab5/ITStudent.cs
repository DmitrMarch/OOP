using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab5
{
    public class ITStudent : Student, ISpecialist
    {
        public ITStudent(string name, Subject subject) : base("", new(""))
        {
            _name = name;
            _subject = subject;
        }

        public ITStudent(string name, int age, Subject subject) : base("", 0, new(""))
        {
            _name = name;
            Age = age;
            _subject = subject;
        }

        public new void WritePersonType()
        {
            Console.WriteLine("Я" + " айти " + PersonType);
        }

        public override void WriteStudentType()
        {
            Console.WriteLine("Я" + " айти " + PersonType);
        }

        string IPerson.WriteInfo()
        {
            return "Студент " + _name + " имеет возраст " + Age.ToString() + " лет\n" +
                "Его любимый предмет " + _subject.GetSubjectName();
        }

        string ISpecialist.WriteInfo()
        {
            return "Айти студент " + _name + " имеет возраст " + Age.ToString() + " лет\n" +
                "Его любимый предмет " + _subject.GetSubjectName();
        }
    }
}
