using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public double Pi { get; set; } = Math.PI;
        public override void CalculateArea()
        {
            double result = Pi * Radius * Radius;
            Console.WriteLine($"Cevrenin sahesi : {result}");
        }
    }
}
