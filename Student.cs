using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3b
{
    internal class Student : Person
    {
        private int studyCredits;

        public Student(string name, string address) : base(name, address)
        {
            studyCredits = 0;
        }

        public void Study()
        {
            studyCredits++;
        }

        public int Credits()
        {
            return studyCredits;
        }

        public override string Show()
        {
            return base.Show() + $"\n  Study credits {studyCredits}";
        }
    }
}
