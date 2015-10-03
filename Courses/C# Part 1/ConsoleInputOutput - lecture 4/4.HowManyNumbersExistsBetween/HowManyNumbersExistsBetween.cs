using System;

/*Write a program that reads two positive integer numbers and 
 * prints how many numbers p exist between them such that the reminder of the 
 * division by 5 is 0 (inclusive). Example: p(17,25) = 2.
 */ 

class HowManyNumbersExistsBetween
{
    static void Main()
    {
        string inputError = "Invalid numbers!Please try again";
        uint firstNumber;
        uint secondNumber;
        Console.WriteLine("Enter a number between 0 and {0}",uint.MaxValue);
        if (!(uint.TryParse(Console.ReadLine(), out firstNumber))) // e.g. (int.TryParse(Console.ReadLine(), out firstNumber) == false
        {
            Console.WriteLine(inputError);
            return;
        }
        Console.WriteLine("Enter a second number between 0 and {0}", uint.MaxValue);
        if (!(uint.TryParse(Console.ReadLine(), out secondNumber))) // e.g. (int.TryParse(Console.ReadLine(), out secondnumber) == false
        {
            Console.WriteLine(inputError);
            return;
        }
        int result = 0;
        for (uint i = firstNumber; i <=secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                result++;
            }
        }
        Console.WriteLine("The number p exist between {0} and {1} is {2} /p({0},{1})={2}/",firstNumber,secondNumber,result);
    }
}
