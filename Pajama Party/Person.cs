using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pajama_Party
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() {
            Name = "Maria";
            Age = 38;
        }
        public Person(string _name, int _age)
        {
            Name = _name;
            Age = _age;
        }
        public override string ToString()
        {
            return $"Name: {Name} Age: {Age}";
        }
    }
}
