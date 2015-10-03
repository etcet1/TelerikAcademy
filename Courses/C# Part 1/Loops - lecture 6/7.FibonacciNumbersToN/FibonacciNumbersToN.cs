using System;
using System.Numerics;

/*Write a program that reads a number N and calculates the sum of the first N members
 * of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 * Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
 */

namespace FibonacciNumbersToN
{
    class FibonacciNumbersToN
    {
        static void Main()
        {
            //setting the intial variable in order to start the cycle Fn = Fn-1 + Fn-2 /Fibonacci/
            //using BigInteger as we might expect big numbers at the end of the sequence
            BigInteger firstEquasionMember = 1;
            BigInteger secondEquasionMember = 0;
            BigInteger nextNumber;
            BigInteger numberN = 0;
            BigInteger sum = 0;
            Console.WriteLine("Please enter a number N");
            string inputOne = Console.ReadLine();
            //printing the numbers from 0 to the specified limit using "for" cycle 
            //setting variable "j" in order to catch when the count of the sequence will reach number N
            if (!BigInteger.TryParse(inputOne, out numberN))
            {
                Console.WriteLine("Please enter valid number N");
            }
            else
            {
                for (int i = 1; i <= numberN; i++)
                {
                    //starting the output here in order to print also the initial "0" and "1" from the Fibonacci sequence   

                    sum += secondEquasionMember;
                    nextNumber = firstEquasionMember + secondEquasionMember;
                    //setting the initial values for the next iteration
                    secondEquasionMember = nextNumber - secondEquasionMember;
                    firstEquasionMember = nextNumber;
                }
                Console.WriteLine("The sum of the first {0} numbers from the sequence of Fibonacci is {1}", numberN, sum);
            }
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Console.Clear();
            Main();
        }
    }
}
