using System;

//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 


class FindLargestNumberInArray
{
    static void Main()
    {
        // Read the N and K numbers
        int numberN = new int();
        int numberK = new int();
        //temporary int holder
        int temp = new int();
        Console.WriteLine("Please enter the number N of the integers:");
        if (!int.TryParse(Console.ReadLine(), out temp))
        {
            Console.WriteLine("Invalid number!");
            Console.WriteLine("Press any key to restart...");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        else
        {
            numberN = temp;
        }
        // Allocate the array
        int[] integerArray = new int[numberN];
        //int[] integerArray = { 1, 4, 9, 23, 5, 10, 11, 13, 97, 45, 31 };
        Console.WriteLine("Please enter the integers:");
        for (int i = 0; i < integerArray.GetLength(0); i++)
        {
            if (!int.TryParse(Console.ReadLine(), out temp))
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine("Press any key to restart...");
                Console.ReadKey();
                Console.Clear();
                Main();
            }
            else
            {
                integerArray[i] = temp;
            }
        }
        Console.WriteLine("Please enter the wanted number K:");
        if (!int.TryParse(Console.ReadLine(), out temp))
        {
            Console.WriteLine("Invalid number!");
            Console.WriteLine("Press any key to restart...");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        else
        {
            numberK = temp;
        }
        //sorting the array - needed for the Binary.Search
        Array.Sort(integerArray);
        int foundNumberPosition = new int();
        int foundNumber = new int();
        bool found = false;
        //searching for the closest number which is <= numberK and bigger than the first element 
        //of the array after the sorting
        for (int i = numberK; i >= integerArray[0]; i--)
        {
            Console.WriteLine(Array.BinarySearch(integerArray, i));
            if (Array.BinarySearch(integerArray, i) < 0)
            {
                continue;
            }
            else
            {
                found = true;
                foundNumberPosition = Array.BinarySearch(integerArray, i);
                foundNumber=integerArray[foundNumberPosition];
                break;
            }
        }
        Console.WriteLine("The sorted array is: {{{0}}}",string.Join(", ",integerArray));
        if (found)
        {
            Console.WriteLine("The best matching number which is smaller or equal to {0} is {1}", numberK, foundNumber);
        }
        else
        {
            Console.WriteLine("There is no matching number which is smaller or equal to {0}.", numberK, foundNumber);
        }
    }
}
