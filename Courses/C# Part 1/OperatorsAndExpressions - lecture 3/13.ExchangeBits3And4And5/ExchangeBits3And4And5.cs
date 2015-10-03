using System;

/*
 * Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
 */

class ExchangeBits3And4And5
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer /value between 0 and {0}/:", uint.MaxValue);
        uint testInteger = uint.Parse(Console.ReadLine());
        uint resultInteger = testInteger;
        int bitStartPosition = 3;
        int bitEndPosition = 5;

        for (int bitPosition = bitStartPosition; bitPosition <= bitEndPosition; bitPosition++)
        {
            int bitPostionSecond = bitPosition + 21;  //calculation of bits with position 24, 25, 26

            //getting the value of the two bits at the positions being exchanged
            uint mask1 = (uint)(1 << bitPosition);
            uint firstBitAndMask1 = (resultInteger & mask1);
            uint firstBit = firstBitAndMask1 >> bitPosition;
            uint mask2 = (uint)(1 << bitPostionSecond);
            uint secondBitAndMask2 = (resultInteger & mask2);
            uint secondBit = secondBitAndMask2 >> bitPostionSecond;

            //first bit goes to its new postion
            if (firstBit == 0)
            {
                uint newpositionmask = ~(uint)(1 << bitPostionSecond);
                resultInteger = (resultInteger & newpositionmask);
            }
            else
            {
                uint newpositionmask = (uint)(1 << bitPostionSecond);
                resultInteger = (resultInteger | newpositionmask);
            }
            //second bit goes to its new position
            if (secondBit == 0)
            {
                uint newpositionmask2 = ~(uint)(1 << bitPosition);
                resultInteger = (resultInteger & newpositionmask2);
            }
            else
            {
                uint newpositionmask2 = (uint)(1 << bitPosition);
                resultInteger = (resultInteger | newpositionmask2);
            }

        }
        Console.WriteLine("The initial integer in binary representation is: \n{0}", Convert.ToString(testInteger, 2));
        Console.WriteLine("Binary representation of modifed number is: \n{0}", Convert.ToString(resultInteger, 2));
        Console.WriteLine("The integer after the bit exchange of bits 3, 4, 5 and 24, 25, 26 is: \n{0}", resultInteger);
    }
}
