using System;
using System.Collections.Generic;

//Write a program that finds the maximal increasing sequence in an array. 
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.


class MaxIncreasingSequence
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
        //array used for testing
        //int[] testArray = {3, 2, 3, 4, 2, 2, 4};
        List<int> countNumber = new List<int>();
        List<int> resultNumber = new List<int>();
        for (int i = 0; i < testArray.GetLength(0); i++)
        {
            countNumber.Add(testArray[i]);
            for (int j = i; j < testArray.GetLength(0) - 1; j++)
            {
                if (testArray[j]+1==testArray[j+1])
                {
                   countNumber.Add(testArray[j+1]);
                }
                else
                {
                    break;
                }
            }
            if (countNumber.Count > resultNumber.Count)
            {
                resultNumber = new List<int>(countNumber);
                countNumber.Clear();
            }
            else
            {
                countNumber.Clear();
            }
        }
       Console.WriteLine("The maximal increasing sequence of elements in the array {0} is {1}", string.Join(", ", testArray), string.Join(", ", resultNumber));
    }
}
