using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert decimal numbers to their hexadecimal representation.

namespace NumeralSystems
{
    class DecimalNumberToHexadecimal
    {
        static char HexadecimalSymbol(int symbol)
        {
            char hexSymbol = new char();
            switch (symbol)
            {
                case 0:
                    hexSymbol = Convert.ToChar(symbol.ToString());
                    break;
                case 1:
                    hexSymbol = Convert.ToChar(symbol.ToString());
                    break;
                case 2:
                    hexSymbol = Convert.ToChar(symbol.ToString());
                    break;
                case 3:
                    hexSymbol = Convert.ToChar(symbol.ToString());
                    break;
                case 4:
                    hexSymbol = Convert.ToChar(symbol.ToString());
                    break;
                case 5:
                    hexSymbol = Convert.ToChar(symbol.ToString());
                    break;
                case 6:
                    hexSymbol = Convert.ToChar(symbol.ToString());
                    break;
                case 7:
                    hexSymbol = Convert.ToChar(symbol.ToString());
                    break;
                case 8:
                    hexSymbol = Convert.ToChar(symbol.ToString());
                    break;
                case 9:
                    hexSymbol = Convert.ToChar(symbol.ToString());
                    break;
                case 10:
                    hexSymbol = 'A';
                    break;
                case 11:
                    hexSymbol = 'B';
                    break;
                case 12:
                    hexSymbol = 'C';
                    break;
                case 13:
                    hexSymbol = 'D';
                    break;
                case 14:
                    hexSymbol = 'E';
                    break;
                case 15:
                    hexSymbol = 'F';
                    break;
                default:
                    hexSymbol = 'Z';
                    break;
            }
            return hexSymbol;
        }
        static bool IsValidnumber(string input)
        {
            char[] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
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
            Console.WriteLine("Please enter an integer:");
            string input = Console.ReadLine();
            int decimalNumber = new int();
            if (IsValidnumber(input) == false)
            {
                Restart(0);
            }
            else
            {
                decimalNumber = int.Parse(input);
            }
            List<char> hexadecimalNumber = new List<char>();
            char temp = new char();
            while (decimalNumber > 0)
            {
                temp = HexadecimalSymbol(decimalNumber % 16);
                decimalNumber = decimalNumber / 16;
                if (temp == 'Z')
                {
                    Restart(0);
                }
                else
                {
                    hexadecimalNumber.Add(temp);
                }
            }
            hexadecimalNumber.Reverse();
            string hexadecimalString = string.Empty;
            foreach (var digit in hexadecimalNumber)
            {
                hexadecimalString += digit;
            }
            Console.WriteLine("The hexadecimal representation of the decimal integer {0} is:\n{1}", input, hexadecimalString);
            Restart(1);
        }
    }
}
