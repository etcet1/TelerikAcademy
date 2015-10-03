using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the
//standard date format for Canada.

namespace StringsAndText
{
    class ExtractDatesFromText
    {
        static void Main()
        {
            string inputText;
            string[] splitText;
            DateTime date;
            CultureInfo cultureCanada = new CultureInfo("en-CA");

            Console.WriteLine("Please enter your string:");
            inputText = Console.ReadLine();

            //spliting the string and searching for dates
            splitText = inputText.Split(new char[] { ' ', '\r', '\t', '\n', ',' }, StringSplitOptions.RemoveEmptyEntries);

            //removing '.' before and at the end if the date is at the beginnig or at the end of sentence
            for (int i = 0; i < splitText.Length; i++)
            {
                splitText[i] = splitText[i].Trim(new char[] { ' ', '.' });
            }

            for (int i = 0; i < splitText.Length; i++)
            {
                if (DateTime.TryParse(splitText[i], out date))
                {
                    //printing the date in the current cultureinfo
                    Console.WriteLine(date.ToString(cultureCanada));
                }
            }

        }
    }
}
