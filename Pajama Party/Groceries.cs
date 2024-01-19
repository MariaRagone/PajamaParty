using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pajama_Party
{
    internal class Groceries
    {
        public string Name { get; set; }
        public int Isle { get; set; }
        public double Price { get; set; }


        public Groceries(string _name, int _isle, double _price)
        {
            Name = _name;
            Isle = _isle;
            Price = _price;
        }
        public Groceries()
        {
            Name = "Milk";
            Isle = 1;
            Price = 3.49;

        }

        public override string ToString()
        {
            return string.Format("{0,10} {1,20} {2,20}", Name, Isle, Price); 
        }
    }
}
