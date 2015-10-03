using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2004
//Distance: 4 days

namespace StringsAndText
{
    class CalculateNumberOfDays
    {

        static void Main()
        {
            DateTime firstDate = new DateTime();
            DateTime secondDate = new DateTime();
            string dateFormat = "d.MM.yyyy"; 
            CultureInfo invarianCulture = CultureInfo.InvariantCulture;

            try
            {
                //parsing the dates using the specified format
                Console.WriteLine("Enter the first date:");
                firstDate = DateTime.ParseExact(Console.ReadLine(), dateFormat, invarianCulture);

                Console.WriteLine("Enter the second date:");
                secondDate = DateTime.ParseExact(Console.ReadLine(), dateFormat, invarianCulture);

                //calculating the absolute value of days between dates only /years not included/
                Console.WriteLine("Distance: {0}", Math.Abs(firstDate.DayOfYear - secondDate.DayOfYear));
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid date or date format!");
            }
            catch
            {
                Console.WriteLine("An error occurred.");
            }

        }

    }
}
