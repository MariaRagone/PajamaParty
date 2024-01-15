using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pajama_Party
{
    internal class Clothing
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

        public Clothing(string _name, int _quantity, string _description, double _price)
        {

            Name = _name;
            Quantity = _quantity;
            Description = _description;
            Price = _price;
        }

        public Clothing()
        {
            Name = "article";
            Quantity = 0;
            Description = "for sale";
            Price = 0;
        }

        public override string ToString()
        {
            return string.Format("{0,20} {1,20} {2,20} {3,20}", Name , Quantity, Description, Price);
        }
    }
}
