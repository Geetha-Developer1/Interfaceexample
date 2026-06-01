using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceexample
{
    interface IShape
    {
        void Area();
        double Perimeter();
    }
    class Circle : IShape
    {
        public double radius {  get; set; }
        public void Area()
        {
            Console.WriteLine("Area of Circle is: " + (Math.PI * radius * radius));
        }
        public double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
    class Rectangle : IShape
    {
        public double legnth {  get; set; }
        public double width {  get; set; }
        public void Area()
        {
            Console.WriteLine("Area of rectangle is: " + (legnth * width));
        }
        public double Perimeter()
        {
            return 2 * (legnth + width);
        }
    }
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    IShape s = new Circle { radius = 5 };
        //    s.Area();
        //    Console.WriteLine("Perimeter of Circle is: " + s.Perimeter());
        //    Console.WriteLine("\n");
        //    IShape s1 = new Rectangle { legnth = 4, width = 6 };
        //    s1.Area();
        //    Console.WriteLine("Perimeter of Rectangle is: " + s1.Perimeter());
        //}
    }
}
