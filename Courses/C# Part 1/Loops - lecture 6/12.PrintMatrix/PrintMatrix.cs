using System;

/*
 * Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix.
 */

namespace PrintMatrix
{
    class PrintMatrix
    {
        static void Main()
        {
            int numberN;
            Console.WriteLine("Please enter a number");
            string inputOne = Console.ReadLine();
            if (!int.TryParse(inputOne, out numberN))
            {
                Console.WriteLine("Please enter valid number");
            }
            else
            {   
                //using almost the same structure from the triangle printing demo
                for (int row = 1; row <= numberN; row++)
                {
                    for (int column = row; column <= row + (numberN - 1); column++)
                    {
                        Console.Write("{0} ", column);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Console.Clear();
            Main();
        }
    }
}
