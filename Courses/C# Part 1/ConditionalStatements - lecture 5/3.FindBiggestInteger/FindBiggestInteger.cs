using System;

/*
 * Write a program that finds the biggest of three integers using nested if statements.
 */

class FindBiggestInteger
{
    static void Main()
    {
        int firstNumber;
        int secondNumber;
        int thirdNumber;
        bool isFirstInt, isSecondInt, isThirdInt;
        Console.WriteLine("Please enter the first number");
        isFirstInt = int.TryParse(Console.ReadLine(), out firstNumber);
        Console.WriteLine("Please enter the second number");
        isSecondInt = int.TryParse(Console.ReadLine(), out secondNumber);
        Console.WriteLine("Please enter the third number");
        isThirdInt = int.TryParse(Console.ReadLine(), out thirdNumber);
        if (!isFirstInt||!isSecondInt||!isThirdInt)
        {
             Console.WriteLine("Invalid input detected.");
             Console.WriteLine("Press any key to restart");
             Console.ReadKey(true);
             Console.Clear();
             Main();
        }
        if(firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("The first number {0} is the biggest one.", firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("The second number {0} is the biggest one.", secondNumber);
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            Console.WriteLine("The third number {0} is the biggest one.", thirdNumber);
        }
        else if (firstNumber==secondNumber || secondNumber==thirdNumber || firstNumber == thirdNumber)
        {
            Console.WriteLine("At least two of the numbers are equal.");
        }
        Console.WriteLine("Press any key to restart");
        Console.ReadKey(true);
        Console.Clear();
        Main();
    }
}
