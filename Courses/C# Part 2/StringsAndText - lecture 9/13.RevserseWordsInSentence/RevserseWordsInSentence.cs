using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reverses the words in given sentence.
//    Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".


namespace StringsAndText
{
    class RevserseWordsInSentence
    {

        static void Main()
        {
            string inputText;
            string[] reversedWords;
            string[] punctuation;
            StringBuilder reversedSentence = new StringBuilder();

            Console.WriteLine("Please enter your string:");

            inputText = Console.ReadLine();

            reversedWords = inputText.Split(new char[]{' ', ',', '!', '?', '.'},StringSplitOptions.RemoveEmptyEntries);

            punctuation = inputText.Split(reversedWords.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(reversedWords);

            for (int i = 0; i < reversedWords.Length; i++)
            {
                reversedSentence.Append(reversedWords[i] + punctuation[i]);
            }

            Console.WriteLine(reversedSentence.ToString());
        }

    }
}
