using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pajama_Party
{
    public class Shapes
    {
        public int sides { get; set; }
        public string color { get; set; }

        public Shapes(int _sides, string _color)
        {
            sides = _sides;
            color = _color;
        }
    }

    public class Circle : Shapes
    {
        public double radius { get; set; }
        public double circumference { get; set; }

        //constructor 
        public Circle(double _radius, double _circumference, int _sides, string _color)
                : base(_sides, _color)
        {
            radius = _radius;
            circumference = _circumference;
        }

        //method
        public static double CalculateCircleArea(double radius, double circumference)
        {
            double area = Math.PI * (Math.Pow(radius, 2));
            return area;
        }
    }

    public class Rectangle : Shapes
    {
        public double length { get; set; }
        public double width { get; set; }

        //constructor 
        public Rectangle(double _length, double _width, int _sides, string _color)
            : base(_sides, _color)
        {
            length = _length;
            width = _width;
        }

        //method
        public static double CalculateRectangleArea(double length, double width)
        {
            double area = length * width;
            return area;
        }
    }

    public class Triangle : Shapes
    {
        public double height { get; set; }
        public double lengthBase { get; set; }

        public Triangle(double height, double lengthBase, int _sides, string _color)
            : base(_sides, _color)
        {
            height = height;
            lengthBase = lengthBase;
        }

        //Method
        public static double CalculateTriangleArea(double height, double lengthBase)
        {
            double area = .5 * height * lengthBase;
            return area;
        }
    }

}
