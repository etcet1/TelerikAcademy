using System;

//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements 
//from the set [1..N]. Example:
//    N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}


class CombinationsOfKDistinctElements
{
    static void Main()
    {
        Console.WriteLine("Enter the number /N/:");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number /K/:");
        int numberK = int.Parse(Console.ReadLine());
        int[] testArray = new int[numberK];
        //initializing the recursion
        CalculateVariations(testArray, 0, numberN);
    }
    private static void CalculateVariations(int[] tempArray, int tempK, int tempN)
    {
        if (tempK != tempArray.GetLength(0))
        {
            for (int i = 1; i <= tempN; i++)
            {
                tempArray[tempK] = i;
                CalculateVariations(tempArray, tempK + 1, tempN);
            }
        }
        else
        {
            Console.Write("{ ");
            for (int i = 0; i < tempArray.GetLength(0); i++)
            {
                Console.Write(tempArray[i] + " ");
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
}
