using System;
using System.Numerics;

/* In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
 * Write a program to calculate the Nth Catalan number by given N.
 */

namespace CathalanNumberByGivenN
{
    class CathalanNumberByGivenN
    {
        // The Catalan numbers are calculated by the formula: Cn = (2n)! / ((n+1)!*n!) , for n>=0.
        static void Main()
        {
            int numberN;
            Console.WriteLine("Please enter a number");
            string inputOne = Console.ReadLine();
            if (!int.TryParse(inputOne, out numberN))
            {
                Console.WriteLine("Please enter valid number");
            }
            else
            {
                if (numberN >=0 )
	            {
                    BigInteger catalanN;
                    BigInteger factorialN = 1;
                    BigInteger factorial2N = 1;
                    BigInteger factorialNPlus1 = 1;

                    //The factorial calculation could be exported in method in order to 
                    //reduce the code /solution found in internet/,e.g 
                    //static BigInteger factorialCalc (BigInteger n)
                    //{
                    //    BigInteger calculatedfactorial = 1;
                    //    for (int i = 1; i <= n; i++)
                    //    {
                    //        calculatedfactorial *=i;
                    //    }
                    //    return calculatedfactorial;
                    //}

                    //Factorial 2 * N
                    for (int i = 1; i <= 2 * numberN; i++)
                    {
                        factorial2N *=i;
                    }
                    //Factorial n + 1
                    for (int j = 1; j <= numberN + 1; j++)
                    {
                        factorialNPlus1 *= j;
                    }
                    //Factorial n
                    for (int k = 1; k <= numberN; k++)
			        {
                        factorialN *=k;
                    }
                        catalanN = factorial2N / (factorialNPlus1 * factorialN);
                        Console.WriteLine("The catalan number at {0} is {1}", numberN, catalanN);
			    }
                else
	            {
                    Console.WriteLine("Please enter a number which is equal or bigger than 0.");
	            }
                
            }
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Console.Clear();
            Main();
        }
    }
}
