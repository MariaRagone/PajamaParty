using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pajama_Party
{
    public class Borrower
    {
        public string Name { get; set; }
        public double DTI { get; set; }
        public int PropertiesOwned { get; set; }

        //constructor
        public Borrower(string _name, double _dti, int _propertiesOwned)
        {
            Name = _name;
            DTI = _dti;
            PropertiesOwned = _propertiesOwned;
        }

        //methods

        public override string ToString()
        {
            return $"Name: {Name}, DTI: {DTI}, Properties Owned: {PropertiesOwned}";
        }

        public class BorrowerValidator //create class for adding a method
        {
            public bool IsValid(Borrower borrower1) //create method for validating
            {
                if (string.IsNullOrEmpty(borrower1.Name) || borrower1.DTI > 25 || borrower1.PropertiesOwned > 3)
                {
                    return false;
                }
                return true;
            }
        }

    }
}
