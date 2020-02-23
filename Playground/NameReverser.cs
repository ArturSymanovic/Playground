using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    class NameReverser
    {
        public static void Run()
        {
            Console.WriteLine("Please enter your name (type \"exit\" to finish):");
            var name = Console.ReadLine();
            while (name.Length <= 0)
            {
                Console.WriteLine("You did not enter a name! Try again!");
                name = Console.ReadLine();
            }
            if (name.ToLower() == "exit") return;
            char[] array = new char[name.Length];
            for (int i = 0; i < name.Length; i++)
            {
                array[i] = name[(name.Length - 1) - i];
            }
            var reversedName = new string(array);
            Console.WriteLine(string.Format("The reversed name of {0} is {1}", name, reversedName));
        }
    }
}
