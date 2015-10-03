using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or 
//negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

namespace ExceptionHandling
{
    class CatchInvalidNumber
    {
        static void Main()
        {
            double number;
            double squareNumber;

            try
            {
                number = int.Parse(Console.ReadLine());
                squareNumber = Math.Sqrt(number);

                Console.WriteLine("Please enter an integer:");

                if (number < 0)
                {
                    throw new FormatException();
                }

                Console.WriteLine("The square root from the integer {0} is {1}.", (int)number, (int)squareNumber);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
