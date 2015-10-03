using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndText
{
    class ExtractSentencesFromText
    {
        
        static void Main()
        {
            string inputText;


            Console.WriteLine("Please enter your text:");

            inputText = Console.ReadLine();

            string[] centences = inputText.Split('.');

            foreach (var centence in centences)
            {
                if (centence.IndexOf(" in ")!=-1)
                {
                    Console.WriteLine(centence.Trim()+".");
                }
            }
        }

    }
}
