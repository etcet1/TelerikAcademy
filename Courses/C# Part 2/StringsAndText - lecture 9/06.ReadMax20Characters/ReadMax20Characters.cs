using System;

//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 
//20, the rest of the characters should be filled with '*'. Print the result string into the console

namespace StringsAndText
{
    class ReadMax20Characters
    {
        const int NotTrimedChars = 20;

        static void Main()
        {
            string input;
            string reformatedInput;
            int trimLength;

            Console.WriteLine("Please enter your text string:");
            input = Console.ReadLine();

            //rebuilding the string
            //checks if NotTrimedChars is bigger than the input and if not sets input.length as limit for the substring
            //for better perfomance could be used StringBuilder class
            reformatedInput = input.Substring(0, NotTrimedChars > input.Length ? input.Length : NotTrimedChars);

            //calculating how many * sybols should be added if needed
            trimLength = NotTrimedChars - reformatedInput.Length;
            if (trimLength > 0)
            {
                reformatedInput += new string('*', trimLength);
            }

            Console.WriteLine("The reformatted string with characters:\n{0}", reformatedInput);
        }
    }
}
