using System;

/*Write a boolean expression that checks for given integer if it can be divided (without remainder)
 * by 7 and 5 in the same time.
 */

class BooleanExpressionIntegerDividedBy7And5  
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer:");
        int divisibleInteger = int.Parse(Console.ReadLine());
        int test7 = divisibleInteger % 7;
        int test5 = divisibleInteger % 5;
        bool divisible = (test5 != 0 && test7 != 0) ? false : true;
        Console.WriteLine("{0} could be divided both by 5 and 7 - {1}", divisibleInteger, divisible);

        //Second solution example with less code
        bool divisibleVariant = ((divisibleInteger % 5) != 0 && (divisibleInteger % 7) != 0) ? false : true;
        Console.WriteLine("{0} could be divided both by 5 and 7 - {1}", divisibleInteger, divisibleVariant);
    }
}
