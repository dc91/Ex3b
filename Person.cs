using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3b
{
    internal class Person
    {
        private string Name { get; set; }
        private string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public virtual string Show()
        {
            return Name + "\n  " + Address;
        }
    }
}
