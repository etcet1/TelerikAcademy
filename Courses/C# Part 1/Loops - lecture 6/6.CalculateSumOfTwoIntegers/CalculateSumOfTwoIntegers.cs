using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that, for a given two integer numbers N and X, 
 * calculates the sumS = 1 + 1!/X + 2!/X2 + … +  * N!/XN
 */

namespace CalculateSumOfTwoIntegers
{
    class CalculateSumOfTwoIntegers
    {
        static void Main()
        {
            //using double as we divide??
            double numberN = 0;
            double numberX = 0;
            Console.WriteLine("Please enter the first number N");
            string inputOne = Console.ReadLine();
            Console.WriteLine("Please enter the first number X");
            string inputTwo = Console.ReadLine();
            if (!double.TryParse(inputOne, out numberN))
            {
                Console.WriteLine("Please valid number N");
            }
            else if (!double.TryParse(inputTwo, out numberX))
            {
                Console.WriteLine("Please valid number X");
            }
            else
            {   
                //initial value of sum
                double sum = 1;
                double factorialN = 1;
                for (int i = 1; i <= numberN; i++)
                {
                    factorialN *= i;
                    sum += factorialN/(numberX * i);
                }
                Console.WriteLine("The result from the sum S = 1 + 1!/X + 2!/X2 + … +  * N!/XN is {0}", sum);
            }
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Console.Clear();
            Main();
        }
    }
}
