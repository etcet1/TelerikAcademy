using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and 
//in scientific notation. Format the output aligned right in 15 symbols.

namespace StringsAndText
{
    class PrintNumberInManyFormats
    {
        static void Main()
        {

            int number;

            Console.WriteLine("Please enter your number:");

            try
            {
                number = int.Parse(Console.ReadLine());

                Console.WriteLine("Decimal:\n {0,15:D}", number);
                Console.WriteLine("Hexadecimal:\n {0,15:x}", number);
                Console.WriteLine("Percentage:\n {0,15:p}", number);
                Console.WriteLine("Decimal:\n {0,15:e}", number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch
            {
                Console.WriteLine("An error occurred.Please try again.");
            }

        }
    }
}
