using System;
using System.Numerics;

/*
 * Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
 */

namespace NafactorialKfactorialCalculation
{
    class NafactorialKfactorialCalculation
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
                if (1 < numberN && numberN < numberK)
                {
                    BigInteger KminusN = numberK - numberN;
                    BigInteger factorialN = 1;
                    BigInteger factorialK = 1;
                    BigInteger factorialKminusN = 1;
                    for (int i = 1; i <= numberN; i++)
                    {
                        factorialN *= i;

                    }
                    for (int j = 1; j <= numberK; j++)
                    {
                        factorialK *= j;
                    }
                    for (int k = 1; k <= KminusN; k++)
                    {
                        factorialKminusN *= k;
                    }
                    BigInteger result = (factorialN * factorialK) / factorialKminusN;
                    Console.WriteLine("The result from the calculation N!*K! / (K-N)! of n! = {0} and\n k! = {1} and (n-k)! = {5} is {2}", factorialN, factorialK, result, factorialN, factorialK, factorialKminusN);
                }
                else
                {
                    Console.WriteLine("Number N must be between 1 and K (1<N<K)");
                }
            }
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Console.Clear();
            Main();
        }
    }
}
