using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date
//and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

namespace StringsAndText
{

    class ReadAndPrintDateBulgarian
    {

        static void Main()
        {
            DateTime firstDate = new DateTime();

            string dateFormat = "d.MM.yyyy HH:mm:ss";
            CultureInfo invarianCulture = CultureInfo.InvariantCulture;

            try
            {
                //parsing the dates using the specified format
                Console.WriteLine("Enter the date:");
                firstDate = DateTime.ParseExact(Console.ReadLine(), dateFormat, invarianCulture);
                firstDate = firstDate.AddHours(6.5);

                //calculating the absolute value of days between dates only /years not included/
                Console.WriteLine("{0} {1}", firstDate, firstDate.ToString("dddd", new CultureInfo("bg-BG")));
            }
            catch (FormatException)
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
