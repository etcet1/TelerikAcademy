using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

namespace ClasesAndObjects
{
    class GenerateAndPrint10Values
    {
        static void RandomNumberPrint(int minValue, int maxValue, int numberCount)
        {
            //new instance of the Random class
            Random randomNumber = new Random();

            //printing the output accoring to the limits and the count of the numbers wanted
            for (int i = 0; i <= numberCount; i++)
            {
                Console.WriteLine(randomNumber.Next(minValue, maxValue));
            }
        }
    
        static void Main()
        {
            Console.WriteLine("10 random numbers between 100 and 200:");
            //printing 10 numbers between 100 and 200
            RandomNumberPrint(100, 200, 10);
        }
    }
}
