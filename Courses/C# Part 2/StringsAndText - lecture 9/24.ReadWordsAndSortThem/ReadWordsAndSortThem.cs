using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

namespace StringsAndText
{
    class ReadWordsAndSortThem
    {
        static void Main()
        {
            string inputText;
            string[] wordsFromInput;

            Console.WriteLine("Please enter your string:");
            inputText = Console.ReadLine();

            wordsFromInput = inputText.Split(new char[] { ' ', '.', ',', ';', ':', '\t', '\n', '(', ')', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

            //sort the array
            Array.Sort(wordsFromInput);

            Console.WriteLine("\nThe words in the string are as follows:\n");
            foreach (string word in wordsFromInput)
            {
                Console.WriteLine("{0}", word);
            }
        }
    }
}
