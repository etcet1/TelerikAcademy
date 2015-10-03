using System;
using System.Collections.Generic;

//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the smallest 
//from the rest, move it at the second position, etc.

class SortingArray
{
    static void Main()
    {
        Console.WriteLine("Please enter the length of the array elements:");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] testArray = new int[arrayLength];
        Console.WriteLine("Now enter the values of the array:");
        for (int i = 0; i < testArray.GetLength(0); i++)
        {
            int number = new int();
            if (int.TryParse(Console.ReadLine(), out number))
            {
                testArray[i] = number;
            }
            else
            {
                Console.WriteLine("Invalid input detected.Press any key to try again.");
                Console.ReadKey();
                Console.Clear();
                Main();
            }
        }
        Console.WriteLine("The unsorted array is {0}", string.Join(",", testArray));
        int temp = new int();
        int minValueIndex = 0;
        for (int i = 0; i < testArray.GetLength(0); i++)
        {
            int minValue = int.MaxValue;
            for (int j = minValueIndex; j < testArray.GetLength(0); j++)
            {
                //if element is lower than minValue switch values of the two elements
                if (testArray[j] < minValue)
                {
                    temp = testArray[minValueIndex];
                    minValue = testArray[j];
                    testArray[minValueIndex] = testArray[j];
                    testArray[j] = temp;
                }
            }
            //switch to the nex array position as the current already contains the minimum value
            minValueIndex++;
        }
        Console.WriteLine("The sorted array is {0}", string.Join(",", testArray));
    }
}

