using System;

/*
 * Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
 */

class GreaterNumber
{
    static void Main()
    {
        string inputError = "Invalid numbers!Please try again";
        int firstNumber;
        int secondNumber;
        Console.WriteLine("Enter a number between {0} and {1}", int.MinValue, int.MaxValue);
        if (!(int.TryParse(Console.ReadLine(), out firstNumber))) // e.g. (int.TryParse(Console.ReadLine(), out firstNumber) == false
        {
            Console.WriteLine(inputError);
            return;
        }
        Console.WriteLine("Enter a second number between {0} and {1}", int.MinValue, int.MaxValue);
        if (!(int.TryParse(Console.ReadLine(), out secondNumber))) // e.g. (int.TryParse(Console.ReadLine(), out secondnumber) == false
        {
            Console.WriteLine(inputError);
            return;
        }
        if(firstNumber!=secondNumber)
        {
            Console.WriteLine("The greater number of {1} and {2} is {0}", Math.Max(firstNumber, secondNumber), firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("The numbers {0} and {1} are equal.", firstNumber, secondNumber);
        }

    }
}
