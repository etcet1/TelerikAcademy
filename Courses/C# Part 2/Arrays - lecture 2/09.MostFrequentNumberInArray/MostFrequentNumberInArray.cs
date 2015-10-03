using System;

//Write a program that finds the most frequent number in an array. Example:
//    {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)


class MostFrequentNumberInArray
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
        //int[] testArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3, 5, 5, 5, 5, 5, 5, 1, 1, 1, 1, 1, 1, 1 };
        int count = new int();
        int numberInArray = new int();
        int temp = new int();
        for (int i = 0; i < testArray.GetLength(0); i++)
        {
            temp = 0;
            for (int j = 0; j < testArray.GetLength(0); j++)
            {
                if (testArray[i] == testArray[j])
                {
                    temp++;
                }
            }
            if (temp > count)
            {
                count = temp;
                numberInArray = testArray[i];
            }
        }
        Console.WriteLine("The most frequent number is {0} -> {1} times", numberInArray, count);
    }
}

