using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Task_2
{
    public abstract class Account
    {
        public abstract string AccountNumber { get; set; }
        public abstract double Balance { get; set; }

        public abstract void ShowAccountDetails();
    }
}
