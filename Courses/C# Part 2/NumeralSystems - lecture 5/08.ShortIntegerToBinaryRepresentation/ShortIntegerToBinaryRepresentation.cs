using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

namespace NumeralSystems
{
    class ShortIntegerToBinaryRepresentation
    {
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

        static string ConvertToBinary(short integer)
        {
            string result = string.Empty;

            for (int i = 0; i < 16; i++)
            {
                int resultMask = integer & (1 << i);
                int bit = resultMask >> i;
                result = bit + result;
            }

            return result;
        }

        static void Main()
        {
            try
            {
                Console.WriteLine("Please enter a 16-bit integer /number between {0} and {1}/", short.MinValue, short.MaxValue);
                string input = Console.ReadLine();
                short result = short.Parse(input);
                Console.WriteLine(ConvertToBinary(result));
            }
            catch (FormatException)
            {
                Restart(0);
            }
        }
    }
}
