using System;

/*
 * Write a program that reads an integer number n from the console and
 * prints all the numbers in the interval [1..n], each on a single line.
 */

class PrintNumberInterval
{
    static void Main()
    {
        int firstNumber;
        string inputError = "Invalid number!Please try again";
        Console.WriteLine("Enter a number between {0} and {1}", int.MinValue, int.MaxValue);
        if (!(int.TryParse(Console.ReadLine(), out firstNumber))) 
        {
            Console.WriteLine(inputError);
            return;
        }
        Console.WriteLine("Printing numbers from 1 to {0}:",firstNumber);
        //Printing the numbers from 1 to the specified number using "for" cycle 
        for (int i = 1; i <= firstNumber; i++)
        {
            Console.WriteLine(i);
        }
    }
}
