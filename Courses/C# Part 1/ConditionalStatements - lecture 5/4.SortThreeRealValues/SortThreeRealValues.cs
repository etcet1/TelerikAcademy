using System;

/*
 * Sort 3 real values in descending order using nested if statements.
 */

class SortThreeRealValues
{
    static void Main()
    {
        int firstNumber, secondNumber, thirdNumber;
        bool isFirstInt, isSecondInt, isThirdInt;
        Console.WriteLine("Please enter the first number");
        isFirstInt = int.TryParse(Console.ReadLine(), out firstNumber);
        Console.WriteLine("Please enter the second number");
        isSecondInt = int.TryParse(Console.ReadLine(), out secondNumber);
        Console.WriteLine("Please enter the third number");
        isThirdInt = int.TryParse(Console.ReadLine(), out thirdNumber);
        if (!isFirstInt || !isSecondInt || !isThirdInt)
        {
            Console.WriteLine("Invalid input detected.");
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Console.Clear();
            Main();
        }
        Console.WriteLine("\nNumbers sorted in descending order");
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine(firstNumber);
            if (secondNumber >= thirdNumber) //if the numbers are equal there is no matter how they will be printed
            {
                Console.WriteLine(secondNumber);
                Console.WriteLine(thirdNumber);
            }
            else if (thirdNumber > secondNumber)
            {
                Console.WriteLine(thirdNumber);
                Console.WriteLine(secondNumber);
            }
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine(secondNumber);
            if (firstNumber >= thirdNumber) //if the numbers are equal there is no matter how they will be printed
            {
                Console.WriteLine(firstNumber);
                Console.WriteLine(thirdNumber);
            }
            else if (thirdNumber > firstNumber)
            {
                Console.WriteLine(thirdNumber);
                Console.WriteLine(firstNumber);
            }
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            Console.WriteLine(thirdNumber);
            if (firstNumber >= secondNumber) //if the numbers are equal there is no matter how they will be printed
            {
                Console.WriteLine(firstNumber);
                Console.WriteLine(secondNumber);
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine(secondNumber);
                Console.WriteLine(firstNumber);
            }
        }
        else if (firstNumber == secondNumber && firstNumber == thirdNumber)
        {
            Console.WriteLine("The numbers are equal.");
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
        }
        Console.WriteLine("Press any key to restart");
        Console.ReadKey(true);
        Console.Clear();
        Main();
    }
}
