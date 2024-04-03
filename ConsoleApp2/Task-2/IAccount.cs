using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public interface IAccount
    {
        public void Deposite(double value);
        public void Withdraw(double value);
        public void CalculateInterest();
    }
}
