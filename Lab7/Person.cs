using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public abstract class Person
    {
        protected Person(string Fullname)
        {
            this.Fullname = Fullname ?? throw new ArgumentNullException(nameof(Fullname));
        }

        public string Fullname { get; set; }
    }
}
