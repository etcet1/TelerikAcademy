using System;

/*
 * We are given 5 integer numbers. Write a program that checks if the sum 
 * of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.
 */

class CheckSubsetSum
{
    static void Main()
    {

        int[] numberSet = new int[5];
        int numbersCount = 5;
        bool exists = false;

        // fill-in the array with the desired numbers 
        for (int i = 0; i < numbersCount; i++)
        {
            Console.WriteLine("Please enter a number:");
            numberSet[i] = int.Parse(Console.ReadLine());
        }

        //iterate over the array starting from the first member in the range and calculating of the sum with
        //the rest of the numbers
        for (int currentMember = 0; currentMember < numbersCount; currentMember++)
        {
            int subsetSum = 0;
            for (int subsetMember = currentMember; subsetMember < numbersCount; subsetMember++)
            {
                subsetSum = subsetSum + numberSet[subsetMember];

                if (subsetSum == 0)
                {
                    Console.Write("A subset which amounts to {0} is found: ", subsetSum);
                    exists = true;
                    for (int iterator = currentMember; iterator <= subsetMember; iterator++)
                    {
                        Console.Write("{0} ", numberSet[iterator]);
                    }
                    Console.WriteLine();
                }
            }
        }
        if (exists == false)
        {
            Console.WriteLine("No subset found.");
        }
    }
}

