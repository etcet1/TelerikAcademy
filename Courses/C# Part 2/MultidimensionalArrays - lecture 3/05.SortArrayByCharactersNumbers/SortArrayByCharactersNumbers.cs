using System;
using System.Collections;
//these needed for the second solution
using System.Collections.Generic;
using System.Linq;

//You are given an array of strings. Write a method that sorts the array by the length of its elements
//(the number of characters composing them).

class SortArrayByCharactersNumbers
{
    static void Main()
    {
        int stringArrayLength = new int();
        int temp = new int();
        Console.WriteLine("Please enter the length of the string array:");
        if (!int.TryParse(Console.ReadLine(), out temp))
        {
            Console.WriteLine("Invalid number!");
            Console.WriteLine("Press any key to restart...");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        else
        {
            stringArrayLength = temp;
        }
        // Allocate the array
        string[] stringArray = new string[stringArrayLength];
        Console.WriteLine("Please enter each string:");
        for (int i = 0; i < stringArray.GetLength(0); i++)
        {
            stringArray[i] = Console.ReadLine();
        }
        Console.WriteLine("\nThe unsorted array is {0}\n", string.Join(",", stringArray));
        string tempString = string.Empty;
        int minValueIndex = 0;
        // first solution sorting with iteration over the elements
        for (int i = 0; i < stringArray.GetLength(0); i++)
        {
            int minValue = int.MaxValue;
            for (int j = minValueIndex; j < stringArray.GetLength(0); j++)
            {
                //if element is lower than minValue switch values of the two elements
                if (stringArray[j].Length < minValue)
                {
                    tempString = stringArray[minValueIndex];
                    minValue = stringArray[j].Length;
                    stringArray[minValueIndex] = stringArray[j];
                    stringArray[j] = tempString;
                }
            }
            //switch to the nex array position as the current already contains the minimum value
            minValueIndex++;
        }
        Console.WriteLine("The result of the first solution:");
        Console.WriteLine("The sorted array is {0}\n", string.Join(",", stringArray));

        //second solution - using IEnumerable - according to examples found in Internet
        Console.WriteLine("The result of the second solution:");
        //sorting by length of the string using IEnumerable and casting the result to List
        stringArray = stringArray.OrderBy(x => x.Length).ToArray();
        Console.WriteLine("The sorted array is {0}\n", string.Join(", ", stringArray));
        Console.WriteLine("Press any key to restart...");
        Console.ReadKey();
        Console.Clear();
        Main();
    }
}

