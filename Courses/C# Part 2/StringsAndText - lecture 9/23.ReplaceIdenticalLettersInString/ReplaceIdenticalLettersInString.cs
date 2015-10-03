using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with
//a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

namespace StringsAndText
{
    class ReplaceIdenticalLettersInString
    {

        static void Main()
        {
            string inputText;
            StringBuilder filteredString = new StringBuilder();
            char previousChar;

            Console.WriteLine("Please enter your string:");

            inputText = Console.ReadLine();

            //using run-length encoding algorithm to find the unique letters
            previousChar = inputText[0];
            for (int i = 1; i < inputText.Length; i++)
            {

                if (previousChar != inputText[i])
                {
                    filteredString.Append(previousChar);
                }

                previousChar = inputText[i];

            }
            //append the last char to the string
            filteredString.Append(previousChar);

            Console.WriteLine(filteredString.ToString());
        }

    }
}
