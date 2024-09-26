using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Game
    {
        string _name;

        Game(string name)
        {
            _name = name;
        }

        public string GetGameName()
        {
            return _name;
        }

        public void SetGameName(string name)
        {
            _name = name;
        }
    }
}
