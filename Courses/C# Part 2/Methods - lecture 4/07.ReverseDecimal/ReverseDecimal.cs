using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that reverses the digits of given decimal number. Example: 256  652

namespace Methods
{
    class ReverseDecimal
    {
        //using the input as string in order to reverse it
        static string Reverse(string inputdecimal)
        {
            string result = string.Empty;
            //check for negative sign and remove it from the original string
            if (inputdecimal[0].ToString() == "-")
            {
                result += inputdecimal[0].ToString();
                inputdecimal = inputdecimal.Remove(0, 1);
            }
            //first solution
            //char[] inputdecimalArray = inputdecimal.ToArray();
            //Array.Reverse(inputdecimalArray);
            //result += new String(inputdecimalArray);

            //second solution
            //reverse the integer
            for (int i = inputdecimal.Length - 1; i >= 0; i--)
            {
                result += inputdecimal[i].ToString();
            }

            return result;
        }
        //check if the input actually is a valid integer
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
        static void Restart(int mode)
        {
            if (mode == 0)
            {
                Console.WriteLine("Invalid input detected!");
                Console.WriteLine("Press any key to restart...");
            }
            else if (mode == 1)
            {
                Console.WriteLine("Press any key to restart...");
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        static void Main()
        {
            Console.WriteLine("Please enter an integer:");
            string input = Console.ReadLine();
            if (IsValidnumber(input))
            {
                Console.WriteLine("The original integer is {0}", input);
                Console.WriteLine("The reversed integer is {0}", Reverse(input));
                Restart(1);
            }
            else
            {
                Restart(0);
            }
        }
    }
}
