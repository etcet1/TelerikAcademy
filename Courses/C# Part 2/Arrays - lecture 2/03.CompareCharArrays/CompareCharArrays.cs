using System;

//Write a program that compares two char arrays lexicographically (letter by letter).

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Please enter the first string, which will be convered to char array:");
        string firstInput = Console.ReadLine();
        char[] firstCharArray = firstInput.ToCharArray();
        Console.WriteLine("Please enter the second string, which will be convered to char array:");
        string secondInput = Console.ReadLine();
        char[] secondCharArray = secondInput.ToCharArray();
        if (firstCharArray.GetLength(0) <= secondCharArray.GetLength(0))
        {
            Console.WriteLine("The comparisson will be run for the length of first string as it is shorter or equal - {0} elements", firstCharArray.GetLength(0));
            for (int k = 0; k < firstCharArray.GetLength(0); k++)
            {
                if (firstCharArray[k] == secondCharArray[k])
                {
                    Console.WriteLine("The values of element {0} of both arrays are equal,e.g. {1} = {2}", k, firstCharArray[k], secondCharArray[k]);
                }
                else
                {
                    Console.WriteLine("The values of element {0} of both arrays are not equal,e.g. {1} != {2}", k, firstCharArray[k], secondCharArray[k]);

                }
            }
        }
        else
        {
            Console.WriteLine("The comparisson will be run for the length of second string as it is shorter - {0} elements", secondCharArray.GetLength(0));
            for (int k = 0; k < secondCharArray.GetLength(0); k++)
            {
                if (firstCharArray[k] == secondCharArray[k])
                {
                    Console.WriteLine("The values of element {0} of both arrays are equal,e.g. {1} = {2}", k, firstCharArray[k], secondCharArray[k]);
                }
                else
                {
                    Console.WriteLine("The values of element {0} of both arrays are not equal,e.g. {1} != {2}", k, firstCharArray[k], secondCharArray[k]);

                }
            }
        }
    }
}
