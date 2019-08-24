using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Account:Person
    {
        private double balance;

        public void ScreenTheBalance()
        {
            Console.WriteLine($"You current balance is: {0}");
        }

        public Account()
        {
            balance = 0;
        }

        public void AddBalance(double amount)
        {
            balance += amount; 
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public double ShowTheBalance()
        {
            return balance;
        }
    }
}
