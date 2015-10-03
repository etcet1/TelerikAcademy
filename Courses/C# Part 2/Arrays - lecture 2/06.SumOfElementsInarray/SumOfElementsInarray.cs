using System;

//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

class SumOfElementsInarray
{
    static void Main()
    {
        Console.WriteLine("Please enter the length of the array elements /N/:");
        int numberN = int.Parse(Console.ReadLine());
        int[] testArray = new int[numberN];
        int number = new int();
        int numberK = new int();
        Console.WriteLine("Now enter the values of the array:");
        for (int i = 0; i < testArray.GetLength(0); i++)
        {
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
        Console.WriteLine("Please enter the number /K/:");
        if (int.TryParse(Console.ReadLine(), out number))
        {
            numberK = number;
        }
        else
        {
            Console.WriteLine("Invalid input detected.Press any key to try again.");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
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
        //taking the last K elements as they are the biggest numbers and have maximal sum
        Console.WriteLine("The {0} numbers which have maximal sum are:",numberK);
        for (int i = testArray.GetLength(0)-1; i >= testArray.GetLength(0) - numberK; i--)
        {
            Console.WriteLine(testArray[i]);
        }
    }
}
