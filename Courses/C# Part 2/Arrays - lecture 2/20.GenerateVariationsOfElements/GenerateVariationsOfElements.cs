using System;

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
//    N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}


class GenerateVariationsOfElements
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
