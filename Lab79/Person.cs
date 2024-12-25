using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab79
{
    public abstract class Person
    {
        protected Person(string fullname)
        {
            Fullname = fullname ?? throw new ArgumentNullException(nameof(fullname));
        }

        public string Fullname { get; set; }
    }
}
