using System;

//Write a program that finds in given array of integers a sequence of given sum S (if present). 
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

class SequenceOfGivenSum
{
    static void Main()
    {
        Console.WriteLine("Please enter the length of the array elements:");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] testArray = new int[arrayLength];
        int number = new int();
        int sum = new int();
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
        Console.WriteLine("Please enter the sum /S/:");
        if (int.TryParse(Console.ReadLine(), out number))
        {
            sum = number;
        }
        else
        {
            Console.WriteLine("Invalid input detected.Press any key to try again.");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        //array used for testing
        //int[] testArray = { 4, 3, 1, 4, 2, 5, 8 };
        int tempSum = new int();
        int startPos = new int();
        int endPos = new int();
        bool found = false;
        for (int i = 0; i < testArray.GetLength(0); i++)
        {
            tempSum = 0;
            startPos = i;
            for (int j = i; j < testArray.GetLength(0); j++)
            {
                tempSum += testArray[j];
                if (tempSum==sum)
                {
                    endPos = j;
                    found = true;
                    break;
                }
            }
            if (found==true)
            {
                break;   
            }
        }
        if (found==true)
        {
            Console.WriteLine("Sequence with sum {0} found.",sum);
            string sequence = string.Empty;
            sequence += "{";
            for (int i = startPos; i <= endPos; i++)
            {
                sequence+=testArray[i].ToString()+" ";
            }
            sequence += "}";
            Console.WriteLine(sequence);
        }
        else
        {
            Console.WriteLine("Sequence with sum {0} not found.", sum);
        }
    }
}
