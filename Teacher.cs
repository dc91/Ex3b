using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3b
{
    internal class Teacher : Person
    {
        private int Salary { get; set; }

        public Teacher(string name, string address, int salary) : base(name, address)
        {
            Salary = salary;
        }

        public override string Show()
        {
            return base.Show() + $"\n  salary {Salary} euro/month";
        }
    }
}
