using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is working correctly.

namespace Methods
{
    class HowManyTimesNumberAppears
    {
        //check if the input actually is a valid integer
        static bool IsValidnumber(string consoleInput)
        {
            var temp = new int();
            if (int.TryParse(consoleInput, out temp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Restart(int mode)
        {
            if (mode == 0)
            {
                Console.WriteLine("Invalid input detected!");
                Console.WriteLine("Press any key to restart...");
            }
            else if (mode == 1)
            {
                Console.WriteLine("Press any key to restart...");
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        static void NumberAppearance(int[] numberArray, int testedNumber)
        {
            int numberCount = new int();
            for (int i = 0; i < numberArray.GetLength(0) - 1; i++)
            {
                if (numberArray[i] == testedNumber)
                {
                    numberCount++;
                }
            }
            if (numberCount > 0)
            {
                Console.WriteLine("The number {0} appears {1} times in the array {{{2}}}.", testedNumber, numberCount, string.Join(", ", numberArray));
            }
            else
            {
                Console.WriteLine("The number {0} doesn't appear in the array {{{1}}}.", testedNumber, string.Join(", ", numberArray));
            }
        }
        static void Main()
        {
            int arraySize = new int();
            Console.WriteLine("Please enter the length of the array:");
            string input = Console.ReadLine();
            // check of the input data
            if (IsValidnumber(input))
            {
                arraySize = int.Parse(input);
                int[] arrayNumbers = new int[arraySize];
                Console.WriteLine("Please enter the elements of the array:");
                for (int i = 0; i < arraySize; i++)
                {
                    input = Console.ReadLine();
                    if (IsValidnumber(input))
                    {
                        arrayNumbers[i] = int.Parse(input);
                    }
                    else
                    {
                        Restart(0);
                    }
                }
                Console.WriteLine("Please enter the number you are looking for:");
                input = Console.ReadLine();
                if (IsValidnumber(input))
                {
                    int numberWanted = int.Parse(input);
                    NumberAppearance(arrayNumbers, numberWanted);
                    Restart(1);
                }
                else
                {
                    Restart(0);
                }
            }
            else
            {
                Restart(0);
            }
        }
    }
}
