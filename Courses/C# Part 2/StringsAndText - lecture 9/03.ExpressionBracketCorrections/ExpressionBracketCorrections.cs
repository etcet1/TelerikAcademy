using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

namespace StringsAndText
{

    class ExpressionBracketCorrections
    {

        static void Main()
        {
            string inputText;
            int bracketCount = 0;
            bool isExpressionValid = true;

            Console.WriteLine("Please enter your string:");
            inputText = Console.ReadLine();

            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] == '(')
                {
                    bracketCount++;
                }
                if (inputText[i] == ')')
                {
                    bracketCount--;
                }
            }

            if (bracketCount != 0)
            {
                isExpressionValid = false;
            }

            Console.WriteLine("The expression is {0}.", isExpressionValid.ToString().ToLower());
        }

    }

}
