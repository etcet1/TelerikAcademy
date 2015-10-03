using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given a string containing a list of forbidden words and a text containing some of these words. Write a program
//that replaces the forbidden words with asterisks. Example:
//Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as
//a dynamic language in CLR.
//    Words: "PHP, CLR, Microsoft"
//        The expected result:
//********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as
//a dynamic language in ***.

namespace StringsAndText
{
    class ReplaceForbiddenWords
    {

        static void Main()
        {
            string inputText;
            List<string> forbiddenWords = new List<string>{"PHP","CLR","Microsoft"};
            const char Replacement = '*';

            Console.WriteLine("Please enter your text:");

            inputText = Console.ReadLine();

            StringBuilder reformattedString = new StringBuilder(inputText);

            for (int i = 0; i < forbiddenWords.Count; i++)
			{
                //check for uppercase
                reformattedString.Replace(forbiddenWords[i], new string(Replacement, forbiddenWords[i].Length));
                //check for lowercase
                reformattedString.Replace(forbiddenWords[i].ToLower(), new string(Replacement, forbiddenWords[i].Length));  
			}

            Console.WriteLine("The formatted text is:\n{0}",reformattedString.ToString());
        }

    }
}
