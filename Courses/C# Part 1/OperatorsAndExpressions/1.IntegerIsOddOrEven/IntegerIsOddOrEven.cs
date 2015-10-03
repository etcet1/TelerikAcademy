using System;

/*
 *Write an expression that checks if given integer is odd or even.
 */

class IntegerIsOddOrEven
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer:");
        int testInteger = int.Parse(Console.ReadLine());
        string oddOrEven = (testInteger % 2) == 0 ? "even" : "odd";
        Console.WriteLine("The integer {0} is {1} number",testInteger,oddOrEven);
    }
}
