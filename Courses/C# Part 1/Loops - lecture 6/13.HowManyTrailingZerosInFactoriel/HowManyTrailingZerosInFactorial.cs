using System;

/** Write a program that calculates for given N how many trailing zeros present at the end of the number N!.
 * Examples:
 * N = 10  N! = 3628800  2
 * N = 20  N! = 2432902008176640000  4
 * Does your program work for N = 50 000?
 * Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!
 */

namespace HowManyTrailingZerosInFactorial
{
    class HowManyTrailingZerosInFactorial
    {
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
                // according to the hint we could calculate the appearance of numbers which are 
                // prime divisors of value 5,e.g. the count of zeros is n/5 + n/25 + n/125 + …
                int zeros = 0;
                for (int i = 5; i <= numberN; i*=5)
                {
                        zeros += numberN / i;
                }
                Console.WriteLine("The number of zeros in factorial {1}! is {0}", zeros, numberN);
            }
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Console.Clear();
            Main();
        }
    }
}
