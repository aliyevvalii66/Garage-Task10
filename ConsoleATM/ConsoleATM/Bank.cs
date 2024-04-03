using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleATM
{
    public class Bank
    {
        public List<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();

        public void AddAccount(BankAccount bankAccount)
        {
            BankAccounts.Add(bankAccount);
        }
        
    }
}
