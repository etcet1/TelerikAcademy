using System;

class QuadronacciRectangle
{
    static void Main()
    {
        long firstNumber = long.Parse(Console.ReadLine());
        long secondNumber = long.Parse(Console.ReadLine());
        long thirdNumber = long.Parse(Console.ReadLine());
        long fourthNumber = long.Parse(Console.ReadLine());
        int quadrRow = int.Parse(Console.ReadLine());
        int quadrCol = int.Parse(Console.ReadLine());
        long nextNumber = 0;
        for (int i = 1; i <= quadrRow; i++)
        {

                for (int j = 1; j <= quadrCol; j++)
                {
                    if (j==1&&i==1)
                    {
                        Console.Write(firstNumber + " ");
                        Console.Write(secondNumber + " ");
                        Console.Write(thirdNumber + " ");
                        Console.Write(fourthNumber + " ");

                        j = 4;
                        while (j < quadrCol)
                        {
                            nextNumber = fourthNumber + thirdNumber + secondNumber + firstNumber;
                            firstNumber = secondNumber;
                            secondNumber = thirdNumber;
                            thirdNumber = fourthNumber;
                            fourthNumber = nextNumber;
                            Console.Write(nextNumber + " ");
                            j++;
                        }
                    }
                    else if (i!=1)
                    {

                            nextNumber = fourthNumber + thirdNumber + secondNumber + firstNumber;
                            firstNumber = secondNumber;
                            secondNumber = thirdNumber;
                            thirdNumber = fourthNumber;
                            fourthNumber = nextNumber;
                            Console.Write(nextNumber + " ");
                    }

                }
                Console.WriteLine();
        }
    }
}
