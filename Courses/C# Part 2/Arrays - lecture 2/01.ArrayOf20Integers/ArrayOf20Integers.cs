using System;

//Write a program that allocates array of 20 integers and 
//initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

    class ArrayOf20Integers
    {
        static void Main()
        {
            Console.WriteLine("Please enter 20 integers:");
            int[] twentyArray = new int[20];
            int temp = new int();
            for (int i = 0; i < twentyArray.GetLength(0); i++)
            {
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    twentyArray[i] = temp;
                }
                else
                {
                    Console.WriteLine("Invalid input detected.Press any key to try again.");
                    Console.ReadKey();
                    Console.Clear();
                    Main();
                }
            }
            Console.WriteLine("The initial array is {0}", string.Join(", ",twentyArray));
            for (int i = 0; i < twentyArray.Length; i++)
            {
                twentyArray[i] = twentyArray[i] * 5;
            }
            Console.WriteLine("The array with values multiplied by 5 is {0}", string.Join(", ", twentyArray));
        }
    }
