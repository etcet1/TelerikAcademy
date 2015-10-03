using System;

/*
 * Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
 */

class BitsExchangeOfInteger
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer /value between 0 and {0}/:\n", uint.MaxValue);
        uint testInteger = uint.Parse(Console.ReadLine());
        uint resultInteger = testInteger;
        Console.WriteLine("Please the start bit position for the first bits group /value between 0 and 31:\n");
        int bitStartPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Please the start bit position for the second bits group /value between 0 and 31:\n");
        int bitEndPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the length of the bits group /e.g. 3 -> bits 3,4,5/:");
        int bitRange = int.Parse(Console.ReadLine());
        int bitGroupDistance; //calculation of the distance between bits
        if (bitStartPosition < bitEndPosition)
        {
            bitGroupDistance = bitEndPosition - bitStartPosition;
        }
        else
        {
            bitGroupDistance = bitStartPosition - bitEndPosition;
        }
        for (int bitPosition = bitStartPosition; bitPosition < bitStartPosition + bitRange; bitPosition++)
        {
            int bitPostionSecond = bitPosition + bitGroupDistance;  //calculation of the position of the second group bit 
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
        Console.WriteLine("The initial integer in binary representation is: \n{0}", Convert.ToString(testInteger, 2).PadLeft(32, '0'));
        Console.WriteLine("The binary representation of modifed number is: \n{0}", Convert.ToString(resultInteger, 2).PadLeft(32, '0'));
        Console.WriteLine("The integer after the bit exchange of bits is: \n{0}", resultInteger);
    }
}
