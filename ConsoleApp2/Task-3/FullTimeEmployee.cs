using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Task_3
{
    internal class FullTimeEmployee : Employee
    {
        private static int _id;
        public override int EmployeeId { get; }

        public override string Name { get; set; }
        public override double BasicSalary { get; set; }

        private FullTimeEmployee()
        {
            _id++;
            EmployeeId = _id;
        }
        public FullTimeEmployee(string name, double salary) : this()
        {
            Name =  name;
            BasicSalary = salary;
        }

        public override double CalculateSalary() => BasicSalary;
      
    }
}
