using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

namespace ClasesAndObjects
{
    class IsItAleapYear
    {
        static void IsItLeapYear(int year)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is leap year.", year);
            }
            else
            {
                Console.WriteLine("{0} is not leap year.", year);

            }
        }

        static void Main()
        {
            int year;

            Console.WriteLine("Which year you would like to check?");

            try
            {
                year = int.Parse(Console.ReadLine());
                IsItLeapYear(year);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid year!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The year must be between 1 and 9999!");
            }
        }
    }
}
