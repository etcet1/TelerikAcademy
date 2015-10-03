using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A dictionary is stored as a sequence of text lines containing words and their explanations. Write a program that
//enters a word and translates it by using the dictionary. Sample dictionary:
//.NET – platform for applications from Microsoft
//CLR – managed execution environment for .NET
//namespace – hierarchical organization of classes


namespace StringsAndText
{
    class WordMeaningTranslator
    {
        static void Main()
        {
            string inputText;
            Dictionary<string, string> wordsDictionary = new Dictionary<string, string> { 
            {".net", "platform for applications from Microsoft"},
            {"clr" , "managed execution environment for .NET"},
            {"namespace" , "hierarchical organization of classes"}            
            };

            Console.WriteLine("Please enter your string:");

            try
            {
                
                inputText = Console.ReadLine();

                //converting to lower in order to work with our dictionary in any cases
                Console.WriteLine("{0} means {1}.", inputText, wordsDictionary[inputText.ToLower()]);
            }
            catch(KeyNotFoundException)
            {
                Console.WriteLine("This string could not be found in the dictionary.");
            }
            catch
            {
                Console.WriteLine("An error occurred.");
            }
        }
    }
}
