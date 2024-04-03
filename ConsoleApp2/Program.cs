



#region Task - 1
//using ConsoleApp2.Models;

//Square square = new Square(10);
//square.CalculateArea();

#endregion


#region Task - 2
//using ConsoleApp2.Models;
//using ConsoleApp2.Task_2;
//using System.Xml.Linq;

//int number;
//do
//{
//    Console.Write("1)Account yaradin 0)Quit -------> ");
//    number = int.Parse(Console.ReadLine());

//    int number1;
//    if (number == 1)
//    {
//        CurrentAccount currentAccount = new CurrentAccount();
//        SavingAccount savingAccount = new SavingAccount();
//        do
//        {
//            Console.Write("1)Deposite 2)Withdraw 3)Account info 4)New Acc 5)Accountlariniz -------> ");
//            number1 = int.Parse(Console.ReadLine());


//            switch (number1)
//            {
//                case 1:
//                    Console.Write("Deposide miqdari : ");
//                    double deposite = int.Parse(Console.ReadLine());
//                    currentAccount.Deposite(deposite);
//                    break;

//                case 2:
//                    Console.Write("Withdraw miqdari : ");
//                    double withdraw = int.Parse(Console.ReadLine());
//                    currentAccount.Withdraw(withdraw);
//                    break;
//                case 3:
//                    currentAccount.ShowAccountDetails();
//                    break;
//                case 4:
//                    Array.Resize(ref savingAccount.Accounts, savingAccount.Accounts.Length + 1);
//                    savingAccount.Accounts[savingAccount.Accounts.Length - 1] = currentAccount;

//                    currentAccount = new CurrentAccount();
//                    Array.Resize(ref savingAccount.Accounts, savingAccount.Accounts.Length + 1);
//                    savingAccount.Accounts[savingAccount.Accounts.Length - 1] = currentAccount;
//                    break;

//                case 5:
//                    Console.WriteLine(savingAccount.Accounts.Length);
//                    for (int i = 0; i < savingAccount.Accounts.Length; i++)
//                    {
//                        savingAccount.Accounts[i].ShowAccountDetails();
//                        Console.WriteLine("-------------------------");
//                    }

//                    break;

//                default:
//                    Console.WriteLine("Duzgun reqemlerden istifade edin");
//                    break;
//            }


//        } while (number1 != 0);


//    }


//} while (number != 0);








#endregion


#region Task - 3

//using ConsoleApp2.Task_3;

//PartTimeEmployee partTimeEmployee = new PartTimeEmployee("ALi" , 500);
//Console.WriteLine("Id : " + partTimeEmployee.EmployeeId);
//Console.WriteLine("Salary : " + partTimeEmployee.CalculateSalary()) ;

#endregion


#region Task - 4
//using ConsoleApp2.Task_4;

//Book book = new Book();
//book.Title = "Test";
//book.AvailableCopies = 100;
//book.CheckOut();
//book.Return();

#endregion