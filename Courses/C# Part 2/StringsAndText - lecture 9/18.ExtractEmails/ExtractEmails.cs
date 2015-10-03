using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Write a program for extracting all email addresses from given text. All substrings that match the format
//<identifier>@<host>…<domain> should be recognized as emails.

namespace StringsAndText
{

    class ExtractEmails
    {

        static void Main()
        {
            string inputText;
            //regex found in internet - good site for regular expressions http://regex101.com/
            string regex = @"[\w.,\-]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}";

            Console.WriteLine("Please enter your string:");
            inputText = Console.ReadLine();

            foreach (var mail in Regex.Matches(inputText, regex))
            {
                //trims '.' if ithe email is at the end of a centence
                Console.WriteLine(mail.ToString().TrimEnd('.'));
            }
        }

    }

}
