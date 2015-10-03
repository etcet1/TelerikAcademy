using System;

/* 1.Declare five variables choosing for each of them the most appropriate of the 
 * types byte, sbyte, short, ushort, int, uint, long, ulong 
 * to represent the following values: 52130, -115, 4825932, 97, -10000.
 */

class DeclareVariables
{
    static void Main()
    {
        sbyte firstValue=-115;
        byte secondValue = 97;
        ushort thirdValue=52130;
        short fourthValue=-10000;
        int fifthValue= 4825932;
        Console.WriteLine(firstValue);
        Console.WriteLine(secondValue);
        Console.WriteLine(thirdValue);
        Console.WriteLine(fourthValue);
        Console.WriteLine(fifthValue);
    }
}
