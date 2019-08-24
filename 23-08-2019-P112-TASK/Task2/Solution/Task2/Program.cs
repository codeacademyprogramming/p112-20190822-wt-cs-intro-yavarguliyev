using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Read();

            Console.WriteLine();

            person.Displays();

            Console.WriteLine();

            Account account = new Account();

            double amount;
            int selection;
            string selectionString;
            Console.WriteLine("Enter Selection: ");
            selectionString = Console.ReadLine();
            selection = int.Parse(selectionString);

            switch (selection)
            {
                case 1:
                    account.ScreenTheBalance();
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Enter Amount to Pay: ");
                    amount = double.Parse(Console.ReadLine());
                    account.AddBalance(amount);
                    Console.WriteLine("Account Balance: {0}", account.ShowTheBalance());
                    break;
                case 3:
                    Console.Write("Enter Amount to Withdraw: ");
                    amount = double.Parse(Console.ReadLine());
                    account.Withdraw(amount);
                    Console.WriteLine("Account Balance: {0}", account.ShowTheBalance());
                    break;
                case 4:
                    Console.Write("Account Details: ");
                    Console.WriteLine();
                    Console.WriteLine("********************");
                    Console.WriteLine("*Person Details*");
                    Console.WriteLine();
                    Console.WriteLine("********************");
                    person.Display();
                    Console.WriteLine("********************");
                    Console.ReadKey();
                    Console.WriteLine("*Account Details*");
                    Console.WriteLine();
                    Console.WriteLine("********************");
                    Console.WriteLine("Balance before Payment: {0}", account.ShowTheBalance());
                    account.AddBalance(0);
                    Console.WriteLine();
                    Console.WriteLine("********************");
                    Console.WriteLine("Balance after Withdrawal: {0}", account.ShowTheBalance());
                    account.Withdraw(0);
                    Console.ReadKey();
                    break;

                case 0:
                    Console.Write("...Exiting");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            } while (selection != 0)

                Console.ReadLine();
        }
    }
}
