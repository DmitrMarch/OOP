using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Student : IPerson, ICloneable, IComparable<Student>
    {
        public static string group = "";
        protected string _name = "";
        protected Subject _subject;
        private string _type = "студент";

        public static string Group
        {
            set
            {
                group = value;
            }

            get
            {
                return group;
            }
        }

        public string PersonType
        {
            set
            {
                _type = value;
            }

            get
            {
                return _type;
            }
        }

        public string Name 
        {
            set
            {
                _name = value!;
            }

            get
            {
                return _name!;
            }
        }

        public int Age { get; set; }

        public Student(string name, Subject subject)
        {
            Name = name;
            _subject = subject;
        }

        public Student(string name, int age, Subject subject)
        {
            Name = name;
            Age = age;
            _subject = subject;
        }

        static Student()
        {
            group = "131б-ПИо";
        }

        public virtual void WritePersonType()
        {
            Console.WriteLine("Я" + " обычный " + PersonType);
        }

        public virtual void WriteStudentType()
        {
            Console.WriteLine("Я" + " обычный " + PersonType);
        }

        public string WriteInfo()
        {
            return "Студент " + _name + " имеет возраст " + Age.ToString() + " лет\n" +
                "Его любимый предмет " + _subject.GetSubjectName();
        }

        public override string ToString()
        {
            return $"{_name}, {Age}, {_type}, {_subject.GetSubjectName()}, {group}";
        }

        public Object Clone()
        {
            return new Student(Name, Age, _subject);
        }

        public int CompareTo(Student? other)
        {
            if (Age < other?.Age) return -1;

            else if (Age == other?.Age) return 0;

            else return 1;
        }

        public static void GroupToConsole()
        {
            Console.WriteLine(group);
        }

        public void BecomeOlder()
        {
            Age += 1;
        }

        public static class University
        {
            public static void Love()
            {
                Console.WriteLine("I love SyktSU");
            }
        }
    }
}
