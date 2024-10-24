using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Student
    {
        public static string group = "";
        private string _name;

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

        public int Age { get; set; }

        public Student(string name)
        {
            _name = name;
        }

        public Student(string name, int age)
        {
            _name = name;
            Age = age;
        }

        static Student()
        {
            group = "131б-ПИо";
        }

        public string WriteInfo()
        {
            return "Студент " + _name + " имеет возраст " + Age.ToString() + " лет";
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
