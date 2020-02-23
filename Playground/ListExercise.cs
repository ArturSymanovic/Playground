using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    class ListExercise
    {
        public static void Run()
        {
            Console.WriteLine("Please enter a list of minimum 5 comma separated whole numbers:");
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                var enteredList = Console.ReadLine();
                var array = enteredList.Split(',');
                if (array.Length < 5) 
                {
                    Console.WriteLine("Invalid List! Try again please!");
                    Console.WriteLine("Please enter a list of minimum 5 comma separated whole numbers:");
                    numbers.Clear();
                    continue;
                }
                var invalidNumberInList = false;
                foreach (var number in array)
                {
                    if (int.TryParse(number.Trim(), out int temp) == true)
                    {
                        numbers.Add(temp);
                    }
                    else
                    {
                        invalidNumberInList = true;
                    }
                }
                if (invalidNumberInList || numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List! Try again please!");
                    Console.WriteLine("Please enter a list of minimum 5 comma separated whole numbers:");
                    numbers.Clear();
                    continue;
                }
            }
            numbers.Sort();
            Console.WriteLine("Smallest Three Numbers:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
