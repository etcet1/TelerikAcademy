using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:
//Hi!
//Expected output:
//\u0048\u0069\u0021

namespace StringsAndText
{
    class ConvertStringToUnicodeChars
    {

        static void Main()
        {
            string inputText;
            StringBuilder textAsUnicode = new StringBuilder();

            Console.WriteLine("Please enter your string:");

            inputText = Console.ReadLine();

            foreach (var character in inputText)
            {
                int charCode = (int)character;
                //format the ASCII code as Hex number using x4 formatting code
                textAsUnicode.AppendFormat("\\u{0:x4}",charCode);
            }

            Console.WriteLine("The string represented as Unicode is:\n{0}",textAsUnicode.ToString());
        }

    }
}
