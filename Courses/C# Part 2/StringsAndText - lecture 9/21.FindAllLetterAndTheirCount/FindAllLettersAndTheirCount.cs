using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and prints all different letters in the string along with
//information how many times each letter is found. 

namespace StringsAndText
{
    class FindAllLettersAndTheirCount
    {
        static void Main()
        {
            string inputText;
            Hashtable letters = new Hashtable();

            Console.WriteLine("Please enter your string:");
            inputText = Console.ReadLine();
            
            //iterating over the input and add only the unique letter to the hashtable
            for (int i = 0; i < inputText.Length; i++)
            {
                if (letters.ContainsKey(inputText[i]))
                {
                    letters[inputText[i]] = int.Parse(letters[inputText[i]].ToString()) + 1;
                }
                else
                {
                    letters.Add(inputText[i], 1);
                }
            }

            foreach (DictionaryEntry letter in letters)
			{
			 Console.WriteLine("{0} - {1}", letter.Key, letter.Value);
			}

        }
    }
}
