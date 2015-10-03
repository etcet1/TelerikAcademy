using System;

/* 11.Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
 */

class ExchangeTwoIntegers
{
    static void Main()
    {
        int fisrtValue = 5;
        int secondValue = 10;
        Console.WriteLine("The initial value of \"a\" is {0} and the value of \"b\" is {1}", fisrtValue, secondValue);
        /*The solution is to sum both variables and after that subtract each one with its own value
         * in order to exchange the values.
         * A second shorter solution (modificaion of piece of code found in Internet):
         * a += b = (a -= b) + b;
         */
        fisrtValue = fisrtValue + secondValue;
        secondValue = fisrtValue - secondValue;
        fisrtValue = fisrtValue - secondValue;
        Console.WriteLine("The exchanged values of \"a\" and \"b\" now are {0} and {1}", fisrtValue, secondValue);
    }
}
