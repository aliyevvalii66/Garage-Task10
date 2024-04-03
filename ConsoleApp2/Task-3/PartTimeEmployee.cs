using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Task_3
{
    internal class PartTimeEmployee : Employee
    {
        private static int _id;
        public override int EmployeeId { get; }

        public override string Name { get; set;  }
        public override double BasicSalary { get; set; }

        public PartTimeEmployee(string name , double basicSalary)
        {
            _id++;
            EmployeeId = _id;
            Name = name;
            BasicSalary = basicSalary;
        }
        public override double CalculateSalary()
        {
            return BasicSalary / 2;
        }
    }
}
