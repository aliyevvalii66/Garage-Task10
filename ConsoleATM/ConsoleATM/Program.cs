using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ConsoleATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Bank bank = new Bank();
            do
            {
                Console.Write("1-Bank Account yaradin 2-Movcud bank accountlar 3-Accounta daxil ol 0-Exit ----> ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    BankAccount account = new BankAccount();
                    CreateBankAccount(account, bank);
                    int choice2;
                    do
                    {
                        Console.Write("1-Deposite 2-Withdraw 3-Balance 4-Account Info 0-GoBack ----> ");
                        choice2 = int.Parse(Console.ReadLine());
                        SwitchCase(choice2, account);

                    } while (choice2 != 0);


                }
                else if (choice == 2)
                {

                    try
                    {
                        int i = 1;

                        foreach (var item in bank.BankAccounts)
                        {
                            Console.WriteLine($@"Acc - {i}
AccountNumber : {item.AccountNumber}
Pin : {item.Pin}
Name : {item.Name}
Surname : {item.Surname}
Gender : {item.GenderValue()}
Balance : {item.Balance}");
                            Console.WriteLine("");
                            i++;
                        }

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Bankda movcud account yoxdur");
                    }
                }
                else if (choice == 3)
                {
                Login:
                    Console.Write("Adinizi daxil edin : ");
                    string name = Console.ReadLine();
                    Console.Write("Pini daxil edin : ");
                    string pin = Console.ReadLine();
                    var account = Login(pin, name, bank);
                    int choice2;
                    if (account == null)
                    {
                        Console.WriteLine("Girish melumatlari yalnishdir!");
                        goto Login;
                    }
                    do
                    {
                        Console.Write("1-Deposite 2-Withdraw 3-Balance 4-Account Info 0-GoBack ----> ");
                        choice2 = int.Parse(Console.ReadLine());
                        SwitchCase(choice2, account);


                    } while (choice2 != 0);


                }
                else
                {
                    Console.WriteLine("Duzgun reqem daxil edin");
                }



            } while (choice != 0);

        }




        static void CreateBankAccount(BankAccount bankAccount, Bank bank)
        {

            Console.WriteLine("Qeydiyyat...");
            Console.Write("Adinizi : ");
            string name = Console.ReadLine();
            Console.Write("Soyadiniz : ");
            string surname = Console.ReadLine();
        gender:
            Console.Write("Cinsiyetinizi daxil edin (man , woman) : ");
            string gender = Console.ReadLine();
            if (gender.Trim().ToLower() == "man")
            {
                bankAccount.Gender = false;
            }
            else if (gender.Trim().ToLower() == "woman")
            {
                bankAccount.Gender = true;
            }
            else
            {
                Console.WriteLine("Cinsiyetinizi man ve ya woman olaraq daxil edin!!!!");
                goto gender;
            }

            bankAccount.Name = name;
            bankAccount.Surname = surname;

            Console.WriteLine($"Sizin ucun yaradilan AccNum : {bankAccount.AccountNumber}");
        pin:
            Console.Write("Pin code yaradin : ");
            string pin = Console.ReadLine();
            if (CreatePin(pin))
                bankAccount.Pin = pin;
            else
            {
                goto pin;
            }

            bankAccount.Bank = bank;
            bank.AddAccount(bankAccount);
        }
        static bool CreatePin(string pin)
        {
            if (pin.Length != 4)
            {
                Console.WriteLine("Zehmet olmasa 4 reqemli pin kod daxil edin.");
            }
            else
            {
                return true;
            }
            return false;
        }

        static BankAccount Login(string pin, string name, Bank bank)
        {

            BankAccount bankAccount = bank.BankAccounts.FirstOrDefault(x => x.Name == name && x.Pin == pin);
            return bankAccount;
        }

        static void SwitchCase(int choice2, BankAccount account)
        {
            switch (choice2)
            {
                case 1:
                    Console.Write("Deposite meblegi daxil edin : ");
                    double deposite = double.Parse(Console.ReadLine());
                    account.Deposite(deposite);
                    break;
                case 2:
                    Console.Write("Cixarmaq istediyiniz meblegi daxil edin : ");
                    double withdraw = double.Parse(Console.ReadLine());
                    account.Withdraw(withdraw);
                    break;
                case 3:
                    account.ShowBalance();
                    break;
                case 4:
                    account.PersonInfo();
                    break;
                case 0:
                    Console.WriteLine("Accountdan cixildi.....");
                    break;
                default:
                    Console.WriteLine("Zehmet olmasa duzgun reqemlerden istifade edin!");
                    break;
            }
        }

    }
}
