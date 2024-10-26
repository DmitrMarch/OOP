using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public abstract class Person
    {
        public abstract int Age { get; set; }

        public abstract string WriteInfo();
    }
}
