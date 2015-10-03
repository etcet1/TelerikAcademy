using System;

class TribonacciTriangle
{
    static void Main()
    {
        long firstNumber = long.Parse(Console.ReadLine());
        long secondNumber = long.Parse(Console.ReadLine());
        long thirdNumber = long.Parse(Console.ReadLine());
        int trinagleLines = int.Parse(Console.ReadLine());
        long nextNumber = 0;
        for (int i = 0; i < trinagleLines; i++)
        {
            if (i==0)
            {
                Console.Write(firstNumber + " ");
            }
            else if (i==1)
            {
                Console.Write(secondNumber + " " + thirdNumber);
            }
            else
            {
                for (int j = 0; j <= i; j++)
                {

                    nextNumber = thirdNumber + secondNumber + firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = nextNumber;
                    Console.Write(nextNumber + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
