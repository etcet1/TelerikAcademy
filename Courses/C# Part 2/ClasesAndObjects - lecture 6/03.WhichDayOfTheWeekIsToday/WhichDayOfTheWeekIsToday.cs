using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints to the console which day of the week is today. Use System.DateTime.

namespace ClasesAndObjects
{
    class WhichDayOfTheWeekIsToday
    {
        static void Main()
        {
            //creating new instance of the DateTime class for the current date
            DateTime today = DateTime.Now;

            //printing the current day of the week and the short represenation of the current date
            Console.WriteLine("Today /{0}/ is {1}.", today.ToShortDateString(), today.DayOfWeek);
        }
    }
}
