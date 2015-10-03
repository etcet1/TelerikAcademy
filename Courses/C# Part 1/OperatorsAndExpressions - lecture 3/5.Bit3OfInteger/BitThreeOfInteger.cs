using System;
/*
 *Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
 */

class BitThreeOfInteger
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer:");
        int testInteger = int.Parse(Console.ReadLine());
        int p = 3;               
        int mask = 1 << p;
        int resultMask = testInteger & mask;
        int bit = resultMask >> p;  
        bool resultOne = (bit==1) ? true : false;
        bool resultZero = (bit == 0) ? true : false;
        Console.WriteLine("The binary representation of the integer {0} is:\n{1}",testInteger, Convert.ToString(testInteger,2).PadLeft(32,'0'));
        Console.WriteLine("The value of bit 3 (counting from 0) of {0} is 1 - {1}", testInteger, resultOne);
        Console.WriteLine("The value of bit 3 (counting from 0) of {0} is 0 - {1}", testInteger, resultZero);
    }
}
