using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase>
//to uppercase. The tags cannot be nested. Example:
//We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//The expected result:
//We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

namespace StringsAndText
{
    class ChangeToUppercase
    {
        static void Main()
        {
            string input;
            string pattern = @"<upcase>\s*(.+?)\s*</upcase>";
          
            Console.WriteLine("Please enter your text string:");
            input = Console.ReadLine();

            Match result = Regex.Match(input, pattern);

            while (result.Success)
            {
                input = input.Replace(result.Groups[1].ToString(), result.Groups[1].ToString().ToUpper());
                result = result.NextMatch();
            }

            input = input.Replace("<upcase>", string.Empty);
            input = input.Replace("</upcase>", string.Empty);

            Console.WriteLine(input);
        }
    }
}
