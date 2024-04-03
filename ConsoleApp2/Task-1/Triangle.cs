using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Triangle : Shape
    {
        public double A { get; set; }
        public double H { get; set; }

        public Triangle(double a  , double h)
        {
            A = a;
            H = h;
        }
        public override void CalculateArea()
        {
           
            double result = A * H / 2;

            Console.WriteLine(result);
        }
    }
}
