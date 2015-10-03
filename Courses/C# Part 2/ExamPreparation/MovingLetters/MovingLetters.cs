using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingLetters
{
    class MovingLetters
    {

        static string MoveLetters(StringBuilder strangeListofWords)
        {
            for (int i = 0; i < strangeListofWords.Length; i++)
            {
                char currSymb = strangeListofWords[i];

                int transition = char.ToLower(currSymb) - 'a' + 1;

                int nextPos = (transition + i) % strangeListofWords.Length;
                strangeListofWords.Remove(i, 1);
                strangeListofWords.Insert(nextPos, currSymb);
            }
            return strangeListofWords.ToString();
        }

        static void Main()
        {
            string letters = Console.ReadLine();
            string encodedResult;

            StringBuilder strange = new StringBuilder();

            string[] words = letters.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int maxWordLength = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxWordLength)
                {
                    maxWordLength = words[i].Length;
                }
            }

            for (int i = 0; i < maxWordLength; i++)
            {
                //for (int j = 0; j < words.Length; j++)
                //{
                //   string currentWord = words[j];
                //   if (words[j].Length > 0)
                //   {
                //   int lastletter = currentWord.Length - 1;
                //   strange.Append(currentWord[lastletter]);

                //   words[j] = words[j].Substring(0, currentWord.Length - 1);
                //   }
                //}
                for (int j = 0; j < words.Length; j++)
                {
                    string currentWord = words[j];

                    if (currentWord.Length > i)
                    {
                        int lastletter = currentWord.Length - 1 - i;
                        strange.Append(currentWord[lastletter]);

                        //words[j] = words[j].Substring(0, currentWord.Length - 1);
                    }
                }
            }


            encodedResult = MoveLetters(strange);
            Console.WriteLine(encodedResult);
        }
    }
}
