using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdNumber = BigInteger.Parse(Console.ReadLine());
        int unknownNumber = int.Parse(Console.ReadLine());
        if (unknownNumber == 1)
        {
            Console.WriteLine(firstNumber);
        }
        else if (unknownNumber == 2)
        {
            Console.WriteLine(secondNumber);
        }
        else if (unknownNumber == 3)
        {
            Console.WriteLine(thirdNumber);
        }
        else
        {
            BigInteger nextNumber = 0;
            for (int i = 4; i <= unknownNumber; i++)
            {
                nextNumber = thirdNumber + secondNumber + firstNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = nextNumber;
            }
            Console.WriteLine(nextNumber);
        }
    }
}
