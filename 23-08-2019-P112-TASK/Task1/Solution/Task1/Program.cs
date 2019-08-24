using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add the numbers: ");
            string[] str = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                numbers[i] = int.Parse(str[i]);
            }

            Console.WriteLine("The largest number is: ");
            Console.WriteLine(numbers.Max());
            Console.WriteLine("The smallest number is: ");
            Console.WriteLine(numbers.Min());
            Console.WriteLine("The sum is: ");
            Console.WriteLine(numbers.Sum());
            Console.WriteLine("The reverse of these numbers: ");
            Array.Reverse(numbers);
            foreach (int i in numbers)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
