using System;

namespace ClassesAndMethods
{
    public class Triangle
    {
        double _height;
        double _base;

        // public Triangle(double height, double Base )
        // {
        //     this._base = Base;
        //     this._height = height;
            
        // }

        public void areaOfTriangle(double heightPar, double basePar)
        {
            var formula = 0.5 * heightPar * basePar;
            System.Console.WriteLine("The Area of Triangle is " + formula);

        }

         public void perimeter(double heightPar, double basePar, double length)
        {
            var formula = heightPar + basePar + length;
            System.Console.WriteLine("The Perimeter of Triangle is " + formula);

        }
    }
}