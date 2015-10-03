using System;
using System.Collections.Generic;
//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).


class SortWithQuickSortAlgorithm
{
    static void Main()
    {
        Console.WriteLine("Please enter the length of the array elements:");
        int arrayLength = int.Parse(Console.ReadLine());
        List<int> testArray = new List<int>();
        Console.WriteLine("Now enter the values of the array:");
        for (int i = 0; i <= arrayLength; i++)
        {
            int number = new int();
            if (int.TryParse(Console.ReadLine(), out number))
            {
                testArray.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input detected.Press any key to try again.");
                Console.ReadKey();
                Console.Clear();
                Main();
            }
        }
        List<int> sortedArray = QuickSort(testArray);
        foreach (var item in sortedArray)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }

    static List<int> QuickSort(List<int> array)
    {
        if (array.Count <= 1)
        {
            return array;
        }
        int pivotIndex = (array.Count/2)-1;
        int pivotNumber = array[pivotIndex];
        array.RemoveAt(pivotIndex);
        List<int> less=new List<int>();
        List<int> greater=new List<int>();
        foreach (var number in array)
	    {
		    if (number<=pivotNumber)
	        {
		        less.Add(number);
	        }else
	        {
                greater.Add(number);
	        }
	    }
        List<int> sortedArray = new List<int>();
        sortedArray.AddRange(QuickSort(less));
        sortedArray.Add(pivotNumber);
        sortedArray.AddRange(QuickSort(greater));
        return sortedArray;
    }
}
