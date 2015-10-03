using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML 
//tags. Example:
//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skillful .NET software engineers.</p></body>
//</html>

namespace StringsAndText
{
    class ExtractTextFromHtml
    {
        static void Main()
        {
            string inputText;
            char[] filteredString;
            int arrayIndex;
            bool insideTag = false;

            Console.WriteLine("Please enter your string:");
            inputText = Console.ReadLine();

            inputText=@"<html><head><title>News</title></head><body><p><a href=http://academy.telerik.com>Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";



            filteredString = new char[inputText.Length];
            arrayIndex = 0;

            for (int i = 0; i < inputText.Length; i++)
            {
                char character = inputText[i];
                if (character == '<')
                {
                    insideTag = true;
                    continue;
                }
                if (character == '>')
                {
                    insideTag = false;
                    continue;
                }
                if (!insideTag)
                {
                    filteredString[arrayIndex] = character;
                    arrayIndex++;
                }
            }
            
            Console.WriteLine(string.Join(string.Empty,filteredString));
           
        }
    }
}
