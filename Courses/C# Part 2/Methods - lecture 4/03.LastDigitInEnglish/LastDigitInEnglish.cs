using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".


namespace Methods
{
    class LastDigitInEnglish
    {
        static string GetWord(char digit)
        {
            string word = string.Empty;
            switch (digit)
            {
                case '0':
                    word = "zero";
                    break;
                case '1':
                    word = "one";
                    break;
                case '2':
                    word = "two";
                    break;
                case '3':
                    word = "three";
                    break;
                case '4':
                    word = "four";
                    break;
                case '5':
                    word = "five";
                    break;
                case '6':
                    word = "six";
                    break;
                case '7':
                    word = "seven";
                    break;
                case '8':
                    word = "eight";
                    break;
                case '9':
                    word = "nine";
                    break;
                default:
                    word = "Not a number!";
                    break;
            }
            return word;
        }
        static void Restart(int mode)
        {
            if (mode == 0)
            {
                Console.WriteLine("Invalid input detected!");
            }
            else if (mode == 1)
            {
                Console.WriteLine("The program ended:)!");
            }
            Console.WriteLine("Press any key to restart...");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        static bool IsValidnumber(string consoleInput)
        {
            var temp = new int();
            if (int.TryParse(consoleInput, out temp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            string input = string.Empty;
            Console.WriteLine("Enter your number:");
            input = Console.ReadLine();
            if (IsValidnumber(input))
            {
                //get the last digit from the input and set the result
                string result = GetWord(input[input.Length - 1]);
                Console.WriteLine("The last digit in the number {0} is {1}.", input, result);
                Restart(1);
            }
            else
            {
                Restart(0);
            }

        }
    }
}
