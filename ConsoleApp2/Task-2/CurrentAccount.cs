using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp2.Task_2
{
    internal class CurrentAccount : Account, IAccount
    {
        public override string AccountNumber { get; set; } = Guid.NewGuid().ToString();
        public override double Balance { get; set; }


        public CurrentAccount()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Account yaradildi!");
            Console.WriteLine("------------------------");
        }
        public void CalculateInterest()
        {
            throw new NotImplementedException();
        }

        public void Deposite(double value)
        {
            if(value >= 0)
            {
                Balance += value;
            }
            else
            {
                Console.WriteLine("Daxil olunan deyer formata uygun deyil!");
            }
        }

       
        public void Withdraw(double value)
        {
            if(Balance >= value)
            {
                Balance -= value;
            }
            else
            {
                Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur!");
            }
        }


        public override void ShowAccountDetails()
        {
            Console.WriteLine($@"Account number : {AccountNumber}
Balance : {Balance}");
        }

    }
}
