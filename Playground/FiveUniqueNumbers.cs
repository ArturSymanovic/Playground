using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    class FiveUniqueNumbers
    {
        public static void Run()
        {
            var numbers = new List<int>();
            Console.WriteLine("You will be asked to enter five unique numbers!");
            Console.WriteLine("Once entered the application will sort and display entered numbers ");
            while (numbers.Count !=5)
            {
                Console.WriteLine("Please enter a whole number");
                var number = Console.ReadLine();
                int parsedNumber;
                if (int.TryParse(number, out parsedNumber) == true)
                {
                    numbers.Add(parsedNumber);
                    continue;
                }
                Console.WriteLine("You have entered invalid number, please try again!");
            }
            numbers.Sort();
            Console.WriteLine("Sorted Numbers:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
