using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string identityCardSerialNumber;

        public void Read()
        {
            Console.Write("Enter First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter Identiy Card Serial Number: ");
            identityCardSerialNumber = Console.ReadLine();
        }

        public void Display()
        {
            Console.Write("Change First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Change Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Change Identiy Card Serial Number: ");
            identityCardSerialNumber = Console.ReadLine();

            Console.WriteLine("********************");

            Console.WriteLine("First Name is changed: {0}", firstName);
            Console.WriteLine("Last Name is changed: {0}", lastName);
            Console.WriteLine("Identiy Card Serial Number is changed: {0}", identityCardSerialNumber);
        }

        public void Displays()
        {
            Console.WriteLine("1. Check The Balance");
            Console.WriteLine("2. Increase The Balance");
            Console.WriteLine("3. Withdraw From The Balance");
            Console.WriteLine("4. Display Account");
            Console.WriteLine("0. Exit");
        }
    }
}
