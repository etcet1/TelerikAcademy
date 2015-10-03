using System;

/*
 * Write a program that prints all the numbers from 1 to N.
 */

namespace PrintNumbersFrom1ToN
{
    class PrintNumbersFrom1ToN
    {
        static void Main()
        {
            int testNumber;
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            if (int.TryParse(input, out testNumber))
            {
                for (int i = 1; i < testNumber; i++)
                {
                    Console.WriteLine("The number at each row is:{0}", i);
                }
                Console.WriteLine("Press any key to restart");
                Console.ReadKey(true);
                Console.Clear();
                Main();
            }
            else
            {
                Console.WriteLine("Please enter a number!");
                Console.WriteLine("Press any key to restart");
                Console.ReadKey(true);
                Console.Clear();
                Main();
            }
        }
    }
}
