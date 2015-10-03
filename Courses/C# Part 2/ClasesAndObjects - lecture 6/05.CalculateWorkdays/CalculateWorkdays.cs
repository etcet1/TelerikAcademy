using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that calculates the number of workdays between today and given date, passed as parameter. Consider that 
//workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

namespace ClasesAndObjects
{

    class CalculateWorkdays
    {
        static List<DateTime> ExcluidedDates()
        {
            //creating hardcoded list with exluded dates
            List<DateTime> excludedDates = new List<DateTime>();

            //adding the excluded dates
            //2013
            excludedDates.Add(new DateTime(2013, 01, 01));
            excludedDates.Add(new DateTime(2013, 12, 31));
            //2014
            excludedDates.Add(new DateTime(2014, 01, 01));
            excludedDates.Add(new DateTime(2014, 03, 03));
            excludedDates.Add(new DateTime(2014, 05, 24));
            excludedDates.Add(new DateTime(2014, 09, 06));
            excludedDates.Add(new DateTime(2014, 12, 25));
            excludedDates.Add(new DateTime(2014, 12, 31));

            return excludedDates;
        }

        static int WorkDaysCalculation(DateTime firstDate, DateTime sedcondDate)
        {
            int dateDifference = new int();
            List<DateTime> excludedDates = ExcluidedDates();

            for (DateTime dateIndex = firstDate; dateIndex < sedcondDate; dateIndex = dateIndex.AddDays(1))
            {
                //check id the current dates is working day and if it is a excluded datey
                if (dateIndex.DayOfWeek != DayOfWeek.Saturday && dateIndex.DayOfWeek != DayOfWeek.Sunday)
                {
                    bool excluded = false;
                    for (int i = 0; i < excludedDates.Count; i++)
                    {
                        if (dateIndex.Date.CompareTo(excludedDates[i].Date) == 0)
                        {
                            excluded = true;
                            break;
                        }
                    }
                    //if the date is working day and iti is not excluded add it to the total count
                    if (!excluded)
                    {
                        dateDifference++;
                    }
                }
            }

            return dateDifference;
        }

        static void Main()
        {
            DateTime today = DateTime.Now;
            DateTime otherDate = new DateTime();
            string[] dateFormat = new string[] { "dd.MM.yyyy" };
            int workDays;

            Console.WriteLine("Please enter the date /dd.MM.yyyy/:");

            try
            {
                otherDate = DateTime.ParseExact(Console.ReadLine(), dateFormat, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);

                //check which date is bigger and invert the calculation in order to receive the right result 
                if (today.Date<otherDate.Date)
                {
                    workDays = WorkDaysCalculation(today, otherDate);
                    Console.WriteLine("The working days between {0} and {1} are {2}.", today.ToShortDateString(), otherDate.ToShortDateString(), workDays);
                }
                else
                {
                    workDays = WorkDaysCalculation(otherDate, today);
                    Console.WriteLine("The working days between {0} and {1} are {2}.", otherDate.ToShortDateString(), today.ToShortDateString(), workDays);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid date format!");
            }
        }
    }
}
