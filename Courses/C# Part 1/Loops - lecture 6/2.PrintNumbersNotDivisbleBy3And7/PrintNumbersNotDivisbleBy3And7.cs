using System;

/*
 * Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
 */

namespace PrintNumbersNotDivisbleBy3And7
{
    class PrintNumbersNotDivisbleBy3And7
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
                    if (i % 3 != 0 && i % 7 !=0)
                    {
                        Console.WriteLine("A number which is not divisible by 3 and 7 is {0}", i);
                    }
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
