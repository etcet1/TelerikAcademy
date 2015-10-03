using System;

//Write a program that finds the index of given element in a sorted array of integers by using 
//the binary search algorithm (find it in Wikipedia).

class FindIndexOfGivenElement
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
        Console.WriteLine("Now enter the number which we are looking for from the array:");
        int numberSearch = int.Parse(Console.ReadLine());
        int numberIndex = new int();
        Array.Sort(testArray);
        numberIndex = Array.BinarySearch(testArray, numberSearch);
        if (numberIndex > 0)
        {
            Console.WriteLine("The first appearance of number {0} in the sorted array {1} is at position {2}", numberSearch, string.Join(", ", testArray), numberIndex);
        }
        else
        {
            Console.WriteLine("The number {0} cannot be found in the sorted array {1}", numberSearch, string.Join(", ", testArray));

        }
    }
}