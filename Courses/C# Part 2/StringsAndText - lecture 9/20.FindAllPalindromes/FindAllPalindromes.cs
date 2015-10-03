using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

namespace StringsAndText
{

    class FindAllPalindromes
    {
        static bool IsPalindrome(string word)
        {
            if (word.Length<=2)
            {
                return false;
            }
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            string inputText;
            string[] splitText;

            Console.WriteLine("Please enter your string:");
            inputText = Console.ReadLine();

            //spliting the string and searching for dates
            splitText = inputText.Split(new char[] { ' ', '\r', '\t', '\n', ',', ')','(', '.'}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splitText.Length; i++)
            {
                if (IsPalindrome(splitText[i]))
                {
                    Console.WriteLine(splitText[i]);
                }
            }
        }

    }

}
