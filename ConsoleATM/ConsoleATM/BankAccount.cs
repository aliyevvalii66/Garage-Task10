using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security;
using System.Text;

namespace ConsoleATM
{
    public class BankAccount
    {
        private string _accountNumber = Guid.NewGuid().ToString();
        private string _pin;
        private string _name;
        private string _surname;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                string temp = value.Trim();
                for (int i = 0; i < temp.Length; i++)
                {
                    if (i == 0)
                    {
                        _name += Char.ToUpper(temp[i]);
                    }
                    else
                    {
                        _name += Char.ToLower(temp[i]);
                    }
                }
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                string temp = value.Trim();
                for (int i = 0; i < temp.Length; i++)
                {
                    if(i == 0)
                    {
                        _surname += Char.ToUpper(temp[i]);
                    }
                    else
                    {
                        _surname += Char.ToLower(temp[i]);
                    }
                }
            }
        }
        public string AccountNumber { get => _accountNumber; }
        public string Pin
        {
            get => _pin;
            set
            {
                if (value.Length > 4 || value.Length < 0)
                {
                    throw new ArgumentException("Invalid");
                }
                _pin = value;
            }
        }
        public double Balance { get; set; }

        public bool Gender { get; set; } // false = man
        public Bank Bank { get; set; }

        public void Deposite(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Added!");
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine("Thank you :)");
            }
            else
            {
                Console.WriteLine("Insufficient balance :(");
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Balance : {Balance}");
        }
        public void PersonInfo()
        {
            Console.WriteLine($@"Adiniz : {Name}
Soyadiniz : {Surname}
Cinsiyyet : {GenderValue()}");
        }


        public string GenderValue()
        {
            return Gender == true ? "Woman" : "Man";
        }


    }
}
