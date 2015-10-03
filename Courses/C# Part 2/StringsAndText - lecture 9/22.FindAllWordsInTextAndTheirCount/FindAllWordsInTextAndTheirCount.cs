using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and lists all different words in the string along with information
//how many times each word is found.

namespace StringsAndText
{
    class FindAllWordsInTextAndTheirCount
    {

        static bool IsLettersOnly(string word)
        {
          foreach (char charFromString in word)
          {
              if (!char.IsLetter(charFromString))
              return false;
          }

          return true;
        }

        static void Main()
        {
            string inputText;
            Hashtable words = new Hashtable();

            Console.WriteLine("Please enter your string:");
            inputText = Console.ReadLine();

            string[] wordsFromInput = inputText.Split(new char[] { ' ', '.', ',',';',':','\t','\n','(',')','[',']'}, StringSplitOptions.RemoveEmptyEntries);

            //iterating over the array with words and add only the unique word to the hashtable
            for (int i = 0; i < wordsFromInput.Length; i++)
            {
                //check if this is actually a word with letters
                if (IsLettersOnly(wordsFromInput[i]))
                {
                    if (words.ContainsKey(wordsFromInput[i]))
                    {
                        words[wordsFromInput[i]] = int.Parse(words[wordsFromInput[i]].ToString()) + 1;
                    }
                    else
                    {
                        words.Add(wordsFromInput[i], 1);
                    }
                }

            }

            Console.WriteLine("\nThe words in the string are as follows:\n");
            foreach (DictionaryEntry word in words)
            {
                Console.WriteLine("{0} - {1}", word.Key, word.Value);
            }

        }

    }
}
