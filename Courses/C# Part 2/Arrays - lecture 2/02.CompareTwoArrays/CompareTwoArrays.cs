using System;

//Write a program that reads two arrays from the console and compares them element by element.

class CompareTwoArrays
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the first array:");
        int firstArrayLength = int.Parse(Console.ReadLine());
        int[] firstArray = new int[firstArrayLength];
        int temp = new int();
        Console.WriteLine("Now enter the values of the first array:");
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            if (int.TryParse(Console.ReadLine(), out temp))
            {
                firstArray[i] = temp;
            }
            else
            {
                Console.WriteLine("Invalid input detected.Press any key to try again.");
                Console.ReadKey();
                Console.Clear();
                Main();
            }
        }
        Console.WriteLine("Enter the length of the second array:");
        int secondArrayLength = int.Parse(Console.ReadLine());
        int[] secondArray = new int[secondArrayLength];
        Console.WriteLine("Now wnter the values of the second array:");
        for (int i = 0; i < secondArray.GetLength(0); i++)
        {
            if (int.TryParse(Console.ReadLine(), out temp))
            {
                secondArray[i] = temp;
            }
            else
            {
                Console.WriteLine("Invalid input detected.Press any key to try again.");
                Console.ReadKey();
                Console.Clear();
                Main();
            }
        }
        if (firstArray.GetLength(0) <= secondArray.GetLength(0))
        {
            Console.WriteLine("The comparisson will be run for the length of second array - {0} elements", secondArray.GetLength(0));
            for (int k = 0; k < firstArray.GetLength(0); k++)
            {
                if (firstArray[k]==secondArray[k])
                {
                    Console.WriteLine("The values of element {0} of both arrays are equal,e.g. {1} = {2}",k,firstArray[k],secondArray[k]);
                }
                else
                {
                    Console.WriteLine("The values of element {0} of both arrays are not equal,e.g. {1} != {2}", k, firstArray[k], secondArray[k]);

                }
            }
        }
        else
        {
            Console.WriteLine("The comparisson will be run for the length of first array - {0} elements", firstArray.GetLength(0));
            for (int k = 0; k < secondArray.Length; k++)
            {
                if (firstArray[k] == secondArray[k])
                {
                    Console.WriteLine("The values of element {0} of both arrays are equal,e.g. {1} = {2}", k, firstArray[k], secondArray[k]);
                }
                else
                {
                    Console.WriteLine("The values of element {0} of both arrays are not equal,e.g. {1} != {2}", k, firstArray[k], secondArray[k]);

                }
            }
        }
    }
}

