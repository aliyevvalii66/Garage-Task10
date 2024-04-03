using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Square : Shape
    {
        public double A { get; set; }
        public Square(double a)
        {
            A = a;
        }
        public override void CalculateArea()
        {
            double result = A * A;
            Console.WriteLine($"Square area : {result}");
        }
    }
}
