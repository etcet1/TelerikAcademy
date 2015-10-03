using System;

class SevenLandNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int result = 0;
        int numberlength = number.ToString().Length;
        if (numberlength==3)
        {
            int svevenlandnum = (number % 100) % 10;
            if ((number / 100)==6 && (number % 100)==66)
            {
                result = 1000;
            }else if ((number % 100)==66)
            {
                result = ((number/100)+1)*100;
            }
            else if (svevenlandnum <= 5)
            {
                
                result = ++number;
            }
            else
            {
                result = number + 4;
            }
        }
        if (numberlength == 2)
        {
            int svevenlandnum = number % 10;
            if ((number/10)==6 && svevenlandnum ==6)
            {
                result = 100;
            }
            else if (svevenlandnum <= 5)
            {
                result = ++number;
            }
            else
            {
                result = number + 4;
            }
        }
        if (numberlength == 1)
        {
            int svevenlandnum = number;
            if (svevenlandnum <= 5)
            {
                result = ++number;
            }
            else
            {
                result = number + 4;
            }
        }
        Console.WriteLine(result);
    }
}
