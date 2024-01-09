using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pajama_Party
{
    //Employee Class
//      Create an Employee class with properties such as Name, Position, 
//        and Salary.Implement methods for giving a raise and displaying
//        the employee details. Create instances of the class and test these methods.
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public double salary { get; set; }


        public Employee(int _id, string _name, string _position, double _salary)
        {
            id = _id;
            name = _name;
            position = _position;
            salary = _salary;
        }

        public Employee()
        {
            id = 0;
            name = "newbie";
            position = "new hire";
            salary = 0.0;
        }

        //methods
        public static double GiveRaise(int id, double salary)
        {
            double raise = .03; //the raise is 3%
            double newSalary = (salary * raise) + salary;
            return newSalary;
        }

        public override string ToString()
        {
            return String.Format("{0,20} {1,20} {2,20}", name, position, salary);
        }

    }
}
