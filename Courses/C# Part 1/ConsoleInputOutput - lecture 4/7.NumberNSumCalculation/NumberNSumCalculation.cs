using System;

/*
 * Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
 */

class NumberNSumCalculation
{
    static int firstNumber = 0;
    static int summaryNumbers = 0;
    static int previousSummary = 0; //Holding the previous generated result

    static void Main()
    {
        string inputError = "Invalid number!Please try again";
        Console.WriteLine("Enter a number between {0} and {1}", int.MinValue, int.MaxValue);
        if (!(int.TryParse(Console.ReadLine(), out firstNumber))) // e.g. (int.TryParse(Console.ReadLine(), out firstNumber) == false
        {
            Console.WriteLine(inputError);
            return;
        }
        previousSummary = summaryNumbers;
        summaryNumbers = summaryNumbers + firstNumber;
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("The sum of {0} and {1} is {2}", previousSummary, firstNumber, summaryNumbers);
        Console.ResetColor();
        ResetCalculations();
    }

    //Return the console to the initial state in order to continue with the calculation
    static void ResetCalculations()
    {
        firstNumber = new int();
        Console.WriteLine();
        Console.WriteLine("Press any key to continue with the calculation");
        Console.ReadKey(true);
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Main();
    }
}
