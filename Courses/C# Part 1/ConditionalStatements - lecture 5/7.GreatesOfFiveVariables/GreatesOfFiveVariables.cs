using System;

/*
 * Write a program that finds the greatest of given 5 variables.
 */

class GreatesOfFiveVariables
{
    static void Main()
    {
        int firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber;
        bool isFirstInt, isSecondInt, isThirdInt, isFourthInt, isFifthInt;
        //input data
        Console.WriteLine("Please enter the first number");
        isFirstInt = int.TryParse(Console.ReadLine(), out firstNumber);
        Console.WriteLine("Please enter the second number");
        isSecondInt = int.TryParse(Console.ReadLine(), out secondNumber);
        Console.WriteLine("Please enter the third number");
        isThirdInt = int.TryParse(Console.ReadLine(), out thirdNumber);
        Console.WriteLine("Please enter the fourth number");
        isFourthInt = int.TryParse(Console.ReadLine(), out fourthNumber);
        Console.WriteLine("Please enter the fifth number");
        isFifthInt = int.TryParse(Console.ReadLine(), out fifthNumber);
        if (!isFirstInt || !isSecondInt || !isThirdInt || !isFourthInt || !isFifthInt)
        {
            Console.WriteLine("Invalid input detected.");
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Console.Clear();
            Main();
        }
        /* first solution using if-else statements*/
        if (firstNumber > secondNumber && firstNumber > thirdNumber && firstNumber > fourthNumber && firstNumber > fifthNumber)
        {
            Console.WriteLine("\nThe greatest number is {0}", firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber && secondNumber > fourthNumber && secondNumber > fifthNumber)
        {
            Console.WriteLine("\nThe greatest number is {0}", secondNumber);
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber && thirdNumber > fourthNumber && thirdNumber > fifthNumber)
        {
            Console.WriteLine("\nThe greatest number is {0}", thirdNumber);
        }
        else if (fourthNumber > firstNumber && fourthNumber > secondNumber && fourthNumber > thirdNumber && fourthNumber > fifthNumber)
        {
            Console.WriteLine("\nThe greatest number is {0}", fourthNumber);
        }
        else if (fifthNumber > firstNumber && fifthNumber > secondNumber && fifthNumber > thirdNumber && fifthNumber > fourthNumber)
        {
            Console.WriteLine("\nThe greatest number is {0}", fifthNumber);
        }else
	    {
		    Console.WriteLine("\nAt least two numbers are equal and have the same greatest value.");
	    }
        /* second shorter solution*/
        /*int greatestNumber = Math.Max(firstNumber,Math.Max(Math.Max(secondNumber, thirdNumber), Math.Max(fourthNumber,fifthNumber)));
        *Console.WriteLine("\nThe greatest number is {0}", greatestNumber);
        */
        Console.WriteLine("Press any key to restart");
        Console.ReadKey(true);
        Console.Clear();
        Main();
    }
}
