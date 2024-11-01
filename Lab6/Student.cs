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
        public static string group = "";
        private string _name;
        private int _age;
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

        public override int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (_age < 0) throw new Exception("Age must be a non-negative number");
                _age = value;
            }
        }
        public Student(string name)
        {
            if (name == "") throw new Exception("Name must contain at least 1 character");
            _name = name;
        }

        public Student(string name, int age)
        {
            if (name == "") throw new Exception("Name must contain at least 1 character");
            else if (age < 0) throw new Exception("Age must be a non-negative number");
            _name = name;
            Age = age;
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

        public override string WriteInfo()
        {
            return "Студент " + _name + " имеет возраст " + Age.ToString() + " лет";
        }

        public override string ToString()
        {
            return $"{_name}, {Age}, {_type}, {group}";
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
