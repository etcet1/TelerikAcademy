using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid
//number or non-number text is entered, the method should throw an exception. Using this method write a program that enters
//10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace ExceptionHandling
{
    class ReadAndValidateNumbers
    {
        static int ReadNumber(int number, int startNumber, int endNumber)
        {
            if (number <= startNumber || number >= endNumber)
            {
                throw new ArgumentOutOfRangeException(
                    "The integer should be between " + startNumber + " and " + endNumber);
            }

            return number;
        }

        static void Main()
        {
            try
            {
                int startNumber = 1;
                int endNumber = 100;
                int inputNumber;
 
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Please enter an integer number > {0} and < {1}", startNumber, endNumber);
                    
                    inputNumber = int.Parse(Console.ReadLine());

                    startNumber = ReadNumber(inputNumber, startNumber, endNumber);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid integer number!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Please enter an integer number!");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}