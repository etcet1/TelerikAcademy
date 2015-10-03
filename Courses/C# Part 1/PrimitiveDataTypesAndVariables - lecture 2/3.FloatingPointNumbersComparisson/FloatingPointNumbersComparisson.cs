using System;

/* 3.Write a program that safely compares floating-point numbers with precision of 0.000001.
 * Examples:(5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true
*/

class FloatingPointNumbersComparisson
{
    static void Main()
    {
        /* The submitted values should be declared as float in order to work with accuracy precision of 0.000001.
         * The boolean result tests if the numbers are equal in the accuracy of the float type.
         * If we use the type double the numbers 5.00000001 and 5.00000003 will not be considered equal.
         */
        Console.WriteLine("Enter one floating point number:");
        float firstOperand = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Enter another floating point number:");
        float secondOperand = float.Parse(Console.ReadLine());
        bool result = (firstOperand == secondOperand);
        Console.WriteLine(result);
    }
}
