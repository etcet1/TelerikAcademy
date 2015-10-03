using System;
using System.Text;

//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

namespace StringsAndText
{

    class ReadAndReverseString
    {
        static void Main()
        {
            string input;
            StringBuilder reversedString = new StringBuilder();

            Console.WriteLine("Please enter a string:");
            input = Console.ReadLine();

            //reversing the string and convert it to StringBuilder
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString.Append(input[i]);
            }

            Console.WriteLine("The reversed string representation is:\n{0}", reversedString.ToString());
        }
    }
}
