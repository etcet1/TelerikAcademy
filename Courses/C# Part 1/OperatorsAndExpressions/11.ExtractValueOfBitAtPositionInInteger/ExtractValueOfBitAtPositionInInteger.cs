using System;

/*
 * Write an expression that extracts from a given integer i the value of a given bit number b.
 * Example: i=5; b=2  value=1.
 */

class ExtractValueOfBitAtPositionInInteger
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer:");
        int testInteger = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the desired bit number:");
        int bitPosition = int.Parse(Console.ReadLine());

        int mask = 1 << bitPosition;
        int resultMask = testInteger & mask;
        int bit = resultMask >> bitPosition;
        Console.WriteLine("\nThe binary representation of the integer {0} is:\n{1}", testInteger, Convert.ToString(testInteger, 2).PadLeft(32, '0'));
        Console.WriteLine("\nThe value of bit {2} (counting from 0) of the integer {0} is {1}", testInteger, bit, bitPosition);

    }
}
