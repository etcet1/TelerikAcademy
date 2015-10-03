using System;

/*Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
 * Use the Euclidean algorithm (find it in Internet).
 */

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main()
        {
            int numberA = 0;
            int numberB = 0;
            Console.WriteLine("Please enter the first number A");
            string inputOne = Console.ReadLine();
            Console.WriteLine("Please enter the first number B");
            string inputTwo = Console.ReadLine();
            if (!int.TryParse(inputOne, out numberA))
            {
                Console.WriteLine("Please valid number A");
            }
            else if (!int.TryParse(inputTwo, out numberB))
            {
                Console.WriteLine("Please valid number B");
            }
            else
            {
                while (numberB != 0)
                {
                    //assigning temprorary holder needed for the iteration
                    // according to the Euclidean algorithm    
                    // numberA = numberB * q0 + r1
                    // numberB = r1q1 + r2
                    //...
                    int tmp = numberB;
                    numberB = numberA % numberB;
                    numberA = tmp;
                    if (numberA % numberB == 0)
                    {
                        break;
                    }
                }
                //the last result of numberB after the end of the iteration actually is the common divisor
                Console.WriteLine(numberB);
            }
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Console.Clear();
            Main();
        }
    }
}
