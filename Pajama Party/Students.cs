using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pajama_Party
{
    internal class Students
    {
        public string name { get; set; }
        public string homeTown { get; set; }
        public string favoriteFood { get; set; }

        //constructor
        //default values
        public Students()
        {
            name = "James";
            homeTown = "Chicago";
            favoriteFood = "Pop";
        }
        public Students(string _name, string _homeTown, string _favoriteFood)
        {
            name = _name;
            homeTown = _homeTown;
            favoriteFood = _favoriteFood;
        }

        //methods
        public override string ToString()
        {
            return $"{name}, is from {homeTown}, and loves {favoriteFood}";
        }

    }
}
