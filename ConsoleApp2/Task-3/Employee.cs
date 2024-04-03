using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Task_3
{
    public abstract class Employee
    {
        public abstract int EmployeeId { get;  }
        public abstract string Name { get; set; }
        public abstract double BasicSalary { get; set; }


        public abstract double CalculateSalary();
    }
}
