using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that return the maximal element in a portion of array of integers 
//starting at given index. Using it write another method that sorts an array in ascending / descending order.


namespace Methods
{
    class MaximalElementInPortionOfArray
    {
        static void PrintArray(int[] array)
        {
            Console.WriteLine("{"+string.Join(", ", array)+"}");
            Console.WriteLine();
        }
        static int MaximalElement(int[] testArray, int startIndex)
        {
            int maxElementIndex = startIndex;
            for (int i = startIndex; i < testArray.GetLength(0); i++)
            {
                if (testArray[i] > testArray[maxElementIndex])
                {
                    maxElementIndex = i;
                }
            }
            return maxElementIndex;
        }
        static int[] SortArrayDescending(int[] testArray)
        {
            int maxElementIndex = 0;
            for (int i = 0; i < testArray.GetLength(0); i++)
            {
                maxElementIndex = MaximalElement(testArray, i);
                int swap = testArray[maxElementIndex];
                testArray[maxElementIndex] = testArray[i];
                testArray[i] = swap;
            }
            return testArray;
        }
        static int[] SortArrayAscending(int[] testArray)
        {
            int[] testArraySorted = SortArrayDescending(testArray);
            testArraySorted = testArraySorted.Reverse().ToArray();
            return testArraySorted;
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
        static void Main()
        {
            //int[] arrayNumbers = { 5, 62, 37, 44, 77, 9, 11, 102, 13, 22, 36, 17 };
            int arraySize = new int();
            Console.WriteLine("Please enter the length of the array:");
            string input = Console.ReadLine();
            // check of the input data
            if (IsValidnumber(input))
            {
                arraySize = int.Parse(input);
               // int[] arrayNumbers = new int[arraySize];
                Console.WriteLine("Please enter the elements of the array:");
                for (int i = 0; i < arraySize; i++)
                {
                    input = Console.ReadLine();
                    if (IsValidnumber(input))
                    {
                        //arrayNumbers[i] = int.Parse(input);
                    }
                    else
                    {
                        Restart(0);
                    }
                }
                int[] arrayNumbers = { 5, 62, 37, 44, 77, 9, 11, 102, 13, 22, 36, 17 };
            Console.WriteLine("The array is:");
            PrintArray(arrayNumbers);
            Console.WriteLine("Please enter the start index of the portion of the array:");
            int portionIndex = new int();
            input = Console.ReadLine();
            //if the input is invalid the start index will remain at the defaul value, e.g. 0 
            //so the the iteration will start at the beginning of the array
            if (IsValidnumber(input))
            {
                portionIndex = int.Parse(input);
            }
                //Checking of the max element in the array portion
                int maxElement = MaximalElement(arrayNumbers, portionIndex);
                Console.WriteLine();
                Console.WriteLine("The maximal element in the array portion\n{{{0}}}\nis {1}", string.Join(", ", arrayNumbers.Skip(portionIndex)), arrayNumbers[maxElement]);
                Console.WriteLine();
                Console.WriteLine("The array in descending order is:");
                PrintArray(SortArrayDescending(arrayNumbers));
                Console.WriteLine();
                Console.WriteLine("The array in ascending order is:");
                PrintArray(SortArrayAscending(arrayNumbers));
                Restart(1);
            }
            else
            {
                Restart(0);
            }
        }
    }
}
