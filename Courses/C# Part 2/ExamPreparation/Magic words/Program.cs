using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_words
{
    class Program
    {
        static void PrintWords(List<string> words)
        {
            int maxWordLength=0;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length > maxWordLength)
                {
                    maxWordLength = words[i].Length;
                }
            }

            for (int i = 0; i < maxWordLength; i++)
            {
                for (int j = 0; j < words.Count; j++)
                {
                    string currentWord = words[j];

                    if (currentWord.Length > i)
                    {
                        int firstLetter = 0 + i;
                        result.Append(currentWord[firstLetter]);
                    }
                }
            }
            Console.WriteLine(result.ToString());
        }

        static void Main()
        {
            int rotations;
            int newPosition;
            List<string> words;

            rotations = int.Parse(Console.ReadLine());

            words = new List<string>(rotations);

            for (int i = 0; i < rotations; i++)
            {
                words.Add(Console.ReadLine().Trim());
            }


            for (int j = 0; j < rotations; j++)
            {
                string currWord = words[j];


                newPosition = currWord.Length % (rotations + 1);

                words[j] = null;
                words.Insert(newPosition, currWord);
                words.Remove(null);

            }

            PrintWords(words);

        }
    }
}
