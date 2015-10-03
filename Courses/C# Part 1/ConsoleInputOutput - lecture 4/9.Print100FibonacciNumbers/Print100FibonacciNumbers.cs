using System;

/*Write a program to print the first 100 members of the sequence of Fibonacci:
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 */

class Print100FibonacciNumbers
{
        static void Main()
        {
            //setting the intial variable in order to start the cycle Fn = Fn-1 + Fn-2 /Fibonacci/
            //using ulong as we expect big numbers at the end of the sequence
            ulong firstEquasionMember = 1;
            ulong secondEquasionMember = 0;
            ulong nextNumber;
            //printing the numbers from 0 to the specified limit using "for" cycle 
            //setting variable "j" in order to catch when the count of the sequence will reach 100
            for (int j = 0; j <= 100; j++)
            {
                //starting the output here in order to print also the initial "0" and "1" from the Fibonacci sequence   
                Console.WriteLine(secondEquasionMember);
                nextNumber = firstEquasionMember + secondEquasionMember;
                //setting the initial values for the next iteration
                secondEquasionMember = nextNumber - secondEquasionMember;
                firstEquasionMember = nextNumber;
            }
        }
}
