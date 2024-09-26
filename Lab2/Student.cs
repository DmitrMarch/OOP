using Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {
        private string _name;
        private Game _game;
        private Subject _subject;


        public int Age { get; set; }

        public Student(string name, Game game, Subject subject)
        {
            _name = name;
            _game = game;
            _subject = subject;
        }

        public Student(string name, int age, Game game, Subject subject)
        {
            _name = name;
            _game = game;
            _subject = subject;
            Age = age;
        }

        public string WriteInfo()
        {
            return "Студент " + _name + " имеет возраст " + Age.ToString() + " лет\n" + 
                "Его любимый предмет - это " + _subject.GetSubjectName() + "\n" +
                "Его любимая игра - это " + _game.GetGameName();
        }

        public void BecomeOlder()
        {
            Age += 1;
        }
    }
}
