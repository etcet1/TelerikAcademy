using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert hexadecimal numbers to binary numbers (directly).

namespace NumeralSystems
{
    class HexadecimalNumberToBinary
    {
        static string HexadecimalInteger(char symbol)
        {
            string hexInteger = string.Empty;
            switch (symbol)
            {
                case '0':
                    hexInteger = "0000";
                    break;
                case '1':
                    hexInteger = "0001";
                    break;
                case '2':
                    hexInteger = "0010";
                    break;
                case '3':
                    hexInteger = "0011";
                    break;
                case '4':
                    hexInteger = "0100";
                    break;
                case '5':
                    hexInteger = "0101";
                    break;
                case '6':
                    hexInteger = "0110";
                    break;
                case '7':
                    hexInteger = "0111";
                    break;
                case '8':
                    hexInteger ="1000";
                    break;
                case '9':
                    hexInteger = "1001";
                    break;
                //uppercase hex
                case 'A':
                    hexInteger = "1010";
                    break;
                case 'B':
                    hexInteger = "1011";
                    break;
                case 'C':
                    hexInteger = "1100";
                    break;
                case 'D':
                    hexInteger = "1101";
                    break;
                case 'E':
                    hexInteger = "1110";
                    break;
                case 'F':
                    hexInteger = "1111";
                    break;
                //lowercase hex
                case 'a':
                    hexInteger = "1010";
                    break;
                case 'b':
                    hexInteger = "1011";
                    break;
                case 'c':
                    hexInteger = "1100";
                    break;
                case 'd':
                    hexInteger = "1101";
                    break;
                case 'e':
                    hexInteger = "1110";
                    break;
                case 'f':
                    hexInteger = "1111";
                    break;
            }
            return hexInteger;
        }
        static bool IsValidnumber(string input)
        {
            char[] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool result = false;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (digits.Contains(input[i]))
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            if (result==true)
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
            Console.WriteLine("Please enter the hexadecimal number:");
            string input = Console.ReadLine();
            string hexadecimalNumber = string.Empty;
            //validate input - accepts bot lowercase and uppercase
            if (IsValidnumber(input) == false)
            {
                Restart(0);
            }
            else
            {
                hexadecimalNumber = input;
            }
            string temp = string.Empty;
            //hexdecimal to binary conversion 
            for (int i = 0, j = hexadecimalNumber.Length - 1; i < hexadecimalNumber.Length && j >= 0; i++, j--)
            {
                temp += HexadecimalInteger(hexadecimalNumber[i]);
            }
            Console.WriteLine("The binary representation of the hexadecimal number {0} is:\n{1}", input, temp);
            Restart(1);
        }
    }
}
