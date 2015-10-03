using System;

class PrintYouAgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Please enter your birthday (e.g 01.01.1980):");
        Console.WriteLine();
        string[] format = new string[] { "dd.MM.yyyy"};
        string inputDate = Console.ReadLine();
        DateTime birthDay;
        if (DateTime.TryParseExact(inputDate, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out birthDay))
        {
            DateTime now = DateTime.Now;
            DateTime futureDate = now.AddYears(10);
            int age = (now.Year - birthDay.Year);
            if (now.Day < birthDay.Day && now.Month <= birthDay.Month)
            {
                age--;
            }
            int futureAge = (futureDate.Year - birthDay.Year);
            if (futureDate.Day < birthDay.Day && futureDate.Month <= birthDay.Month)
            {
                futureAge--;
            }
            Console.WriteLine("At the moment ({1}) your age is {0}", age, now);
            Console.WriteLine("After 10 years ({1}) you will be {0} years old", futureAge, futureDate);
        }
        else
        {
           Console.WriteLine("Invalid date");
        }
    }
}
