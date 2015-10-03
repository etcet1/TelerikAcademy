using System;
using System.Numerics;

/*
 * Write a program that calculates N!/K! for given N and K (1<K<N).
 */


namespace NFactorialDividedByKFactorial
{
    class NFactorialDividedByKFactorial
    {
        static void Main()
        {   
            //using Biginteger from System.Numerics as we expect to receive big results
            BigInteger numberN = 0;
            BigInteger numberK = 0;
            Console.WriteLine("Please enter the first number N");
            string inputOne = Console.ReadLine();
            Console.WriteLine("Please enter the first number K");
            string inputTwo = Console.ReadLine();
            if (!BigInteger.TryParse(inputOne,out numberN))
            {
                Console.WriteLine("Please valid number N");
            }
            else if (!BigInteger.TryParse(inputTwo,out numberK))
            {
                Console.WriteLine("Please valid number K");
            }
            else
            {
                if (1 < numberK && numberK < numberN)
                {
                    BigInteger factorialN = 1;
                    BigInteger factorialK = 1;
                    for (int i = 1; i <= numberN; i++)
                    {
                        factorialN *= i;
                        
                    }
                    for (int j = 1; j <= numberK; j++)
                    {
                        factorialK *= j;
                    }
                    BigInteger result = factorialN / factorialK;
                    Console.WriteLine("The result from the division of n! = {0} and k! = {1} is {2}", factorialN, factorialK, result);
                }
                else
                {
                    Console.WriteLine("Number K must be between 1 and N (1<K<N)");
                }
            }
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Console.Clear();
            Main();
        }
    }
}
