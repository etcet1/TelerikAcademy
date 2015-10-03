using System;

//Write a program that finds the sequence of maximal sum in given array. Example:
//    {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//    Can you do it with only one loop (with single scan through the elements of the array)?


class SequenceOfMaximalSum
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
        int maxSum = 0;
        int tempSum = 0;
        int startPos = 0;
        int endPos = 0;
        for (int i = 0; i < testArray.GetLength(0); i++)
        {
            int temp = i;
            for (int j = i; j < testArray.GetLength(0); j++)
            {
                tempSum += testArray[j];
                if (tempSum>maxSum)
                {
                    startPos = temp;
                    maxSum = tempSum;
                    endPos = j;
                }
            }
            tempSum = 0;
        }
        Console.WriteLine("The max sum is {0} and the sequence is:", maxSum);
        for (int i = startPos; i <= endPos; i++)
        {
            Console.Write(" " + testArray[i]);
        }
        Console.WriteLine();
    }
}
