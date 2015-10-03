using System;

/*
 * Write a boolean expression that returns if the bit at position p (counting from 0) in
 * a given integer number v has value of 1. Example: v=5; p=1  false.
 */

class BitpositionInIntegerCheckIfOne
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer:");
        int testInteger = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the desired bit position:");
        int bitPosition = int.Parse(Console.ReadLine());
        int mask = 1 << bitPosition;
        int resultMask = testInteger & mask;
        int bit = resultMask >> bitPosition;
        bool resultCheck = (bit == 1) ? true : false;

        Console.WriteLine("\nThe binary representation of the integer {0} is:\n{1}", testInteger, Convert.ToString(testInteger, 2).PadLeft(32, '0'));
        Console.WriteLine("\nThe value of bit {2} (counting from 0) of the integer {0} is 1 - {1}", testInteger, resultCheck, bitPosition);
    }
}
