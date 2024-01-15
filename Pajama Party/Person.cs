using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pajama_Party
{
    internal class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person ()
        {
            this.age = 0;
            this.name = "new person"; 
        }

        public override string ToString()
        {
            return String.Format("{0,20} {1,20}", name, age);
        }

    }
}
