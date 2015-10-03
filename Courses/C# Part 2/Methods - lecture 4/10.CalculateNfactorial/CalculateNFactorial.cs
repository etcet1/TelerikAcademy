using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

namespace Methods
{
    /* A solution based on including in the project references of the class System.Numerics.dll from the .Net framework
     * and adding it with "using System.Numerics;", which works with BigInteger numbers /no limit of the length 
     * of the number/
     * Another solution is use each number from the sequence 1*2*3....*n as array of digits and multiply each number
     * with the previous one with the help of similar solution as this one in task 08
     */
    class CalculateNFactorial
    {
        static BigInteger CalculateFactorial(int number)
        {
            BigInteger result = new BigInteger(1);
            for (int i = 2; i <= number; ++i)
            {
                result = i * result;
            }

            return result;
        } 
        static void Main()
        {
            Console.WriteLine("Please enter a number between 1 and 100:");

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The {0}! factorial is:",number);
            BigInteger result = CalculateFactorial(number);
            Console.WriteLine(result.ToString());
        }
    }
}
