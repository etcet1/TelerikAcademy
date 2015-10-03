using System;

//Write a program that finds the maximal sequence of equal elements in an array.

class MaxSequenceEqualElements
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
        //int[] testArray = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int resultNumber = new int();
        int countNumber = new int();
        //setting the temp holder for the sequence count
        int temp = 1;
        for (int i = 0; i < testArray.GetLength(0)-1; i++)
        {
            int j = i;
            while (testArray[i] == testArray[j + 1] && j < testArray.GetLength(0))
            {
                temp++;
                j++;
            }
            if (temp>countNumber)
            {
                countNumber = temp;
                resultNumber = testArray[i];
            }
            //reset of the counter
            temp = 1;
        }
        Console.WriteLine("The maximal sequence of elements in the array {0} is {1} -> {2} times", string.Join(", ", testArray), resultNumber,countNumber);
    }
}

