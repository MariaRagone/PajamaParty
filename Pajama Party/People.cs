using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pajama_Party
{
    internal class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool HasLicense { get; set; }

        public People(string _name, int _age, bool _hasLIcense)
        {
            Name = _name;
            Age = _age;
            HasLicense = _hasLIcense;
        }

        public People()
        {
            Name = "Enter Name";
            Age = 0;
            HasLicense = false;
        }

        public override string ToString()
        {
            return string.Format("{0,10} {1,10}", Name, Age);
        }

        public string IsOldEnough()
        {
            if (Age >= 21 && HasLicense)
            {

                return $"{Name} can drink, drive, and vote.";
            }
            if (Age >= 21)
            {

                return $"{Name} can drink and vote.";
            }

            if (Age >= 18 && HasLicense)
            {
                return $"{Name} can drive and vote";
            }
            if (Age >= 18)
            {
                return $"{Name} can vote";
            }

            if (Age >= 16 && HasLicense)
            {

                return $"{Name} can drive";

            }
            if (Age >= 16)
            {

                return $"{Name} is {Age} and does not have a license.";

            }


            return $"{Name} is too young";

        }
    }
}
