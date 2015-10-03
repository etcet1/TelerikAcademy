using System;

/*
 * Write a program that reads 3 integer numbers from the console and prints their sum.
 */ 

class ReadThreeIntegersPrintSum
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        string inputError = "Invalid numbers!Please try again";
        int firstNumber;
        int secondNumber;
        if (!(int.TryParse(Console.ReadLine(), out firstNumber))) // e.g. (int.TryParse(Console.ReadLine(), out firstNumber) == false
        {
            Console.WriteLine(inputError);
            return;
        }
        Console.WriteLine("Please enter another number:");
        if (!(int.TryParse(Console.ReadLine(), out secondNumber))) // e.g. (int.TryParse(Console.ReadLine(), out firstNumber) == false
        {
            Console.WriteLine(inputError);
            return;
        }
        Console.WriteLine("The sum of the two integers is: {0}", firstNumber + secondNumber);
    }
}
