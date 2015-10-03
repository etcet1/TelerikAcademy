using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that returns the index of the first element in array 
//that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

namespace Methods
{
    class IndexOfArrayNumberBiggerThanNeighbors
    {
        static int BiggerThanNeighborsExists(int[] arrayNumbers)
        {
            int numberPosition = -1;
            for (int i = 0; i < arrayNumbers.GetLength(0); i++)
            {
                //check the first element
                if (i == 0)
                {
                    if (arrayNumbers[i] > arrayNumbers[i + 1])
                    {
                        numberPosition = i;
                    }
                }
                //check the last elemnt
                else if (i == arrayNumbers.GetLength(0) - 1)
                {
                    if (arrayNumbers[i] > arrayNumbers[i - 1])
                    {
                        numberPosition = i;
                    }
                }
                //check the other elements
                else
                {
                    if (arrayNumbers[i] > arrayNumbers[i - 1] && arrayNumbers[i] > arrayNumbers[i + 1])
                    {
                        numberPosition = i;
                    }
                }
            }
            return numberPosition;
        }
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
            else if (mode == 2)
            {
                Console.WriteLine("An error occured.");
                Console.WriteLine("Press any key to restart...");
            }
            Console.ReadKey();
            Console.Clear();
            Main();
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
                int result = BiggerThanNeighborsExists(arrayNumbers);
                if (result >= 0 && result < arrayNumbers.GetLength(0))
                {
                    Console.WriteLine("The number {0} at position {1} is bigger than its neighbors in the array {{{2}}}.", arrayNumbers[result], result, string.Join(", ", arrayNumbers));
                    Restart(1);
                }
                else if (result == -1)
                {
                    Console.WriteLine("There is no number in the array that is bigger than its neighbors in the array {{{0}}}.", string.Join(", ", arrayNumbers));
                    Restart(1);
                }
                else
                {
                    Restart(2);
                }
            }
            else
            {
                Restart(0);
            }
        }
    }
}