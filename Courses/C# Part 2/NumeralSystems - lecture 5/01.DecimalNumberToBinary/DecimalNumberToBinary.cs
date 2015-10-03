using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert decimal numbers to their binary representation.

namespace NumeralSystems
{
    class DecimalNumberToBinary
    {

        static string ConvertToBinary(int integer)
        {
            string result = string.Empty;

            for (int i = 0; i < 32; i++)
            {
                int resultMask = integer & (1 << i);
                int bit = resultMask >> i;
                result = bit + result;
            }

            return result;
        }

        static void Main()
        {
            string binaryString = string.Empty;
            int decimalNumber = new int();
            string input;

            Console.WriteLine("Please enter an integer:");
            input = Console.ReadLine();

            try
            {
                decimalNumber = int.Parse(input);

                //convert integer to binary and print the result
                binaryString = ConvertToBinary(decimalNumber);
                Console.WriteLine("The binary representations of the integer {0} is:\n{1}", input, binaryString);

            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid number!");
            }

        }
    }
}
