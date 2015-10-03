using System;

class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        int newday = 0;
        int newMonth = 0;
        int newYear = 0;
        bool leapYear = DateTime.IsLeapYear(year);

        if (day==31&&month==12)
        {
            newYear = year + 1;
            newMonth = 1;
            newday = 1;
        }else if (day==31||(day==30&&(month==4||month==6||month==9||month==11)))
        {
            newYear = year;
            newMonth=month+1;
            newday=1;
        }else if (day==28&&month==2&&!leapYear)
	    {
            newYear = year;
		    newMonth=month+1;
            newday=1;
	    }
        else if (day==29&&month==2&&leapYear)
	    {
            newYear = year;
		     newMonth=month+1;
            newday=1;
	    }else
	    {
            newYear=year;
            newMonth=month;
            newday=day+1;
	    }
        Console.WriteLine(newday + "." + newMonth + "." + newYear);
    }
}
