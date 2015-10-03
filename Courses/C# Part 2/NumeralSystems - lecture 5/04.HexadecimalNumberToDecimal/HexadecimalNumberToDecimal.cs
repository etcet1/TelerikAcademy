using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert hexadecimal numbers to their decimal representation.

namespace NumeralSystems
{
    class HexadecimalNumberToDecimal
    {
        static int HexadecimalInteger(char symbol)
        {
            int hexInteger = new int();
            switch (symbol)
            {
                case '0':
                    hexInteger = 0;
                    break;
                case '1':
                    hexInteger = 1;
                    break;
                case '2':
                    hexInteger = 2;
                    break;
                case '3':
                    hexInteger = 3;
                    break;
                case '4':
                    hexInteger = 4;
                    break;
                case '5':
                    hexInteger = 5;
                    break;
                case '6':
                    hexInteger = 6;
                    break;
                case '7':
                    hexInteger = 7;
                    break;
                case '8':
                    hexInteger = 8;
                    break;
                case '9':
                    hexInteger = 9;
                    break;
                //uppercase hex
                case 'A':
                    hexInteger = 10;
                    break;
                case 'B':
                    hexInteger = 11;
                    break;
                case 'C':
                    hexInteger = 12;
                    break;
                case 'D':
                    hexInteger = 13;
                    break;
                case 'E':
                    hexInteger = 14;
                    break;
                case 'F':
                    hexInteger = 15;
                    break;
                //lowercase hex
                case 'a':
                    hexInteger = 10;
                    break;
                case 'b':
                    hexInteger = 11;
                    break;
                case 'c':
                    hexInteger = 12;
                    break;
                case 'd':
                    hexInteger = 13;
                    break;
                case 'e':
                    hexInteger = 14;
                    break;
                case 'f':
                    hexInteger = 15;
                    break;
                default:
                    hexInteger = -1;
                    break;
            }
            return hexInteger;
        }
        //own mehod for power calculation faster than Math.Pow
        static int MathPow(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
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
            int temp = new int();
            //hexdecimal to decimal conversion 
            for (int i = 0, j = hexadecimalNumber.Length - 1; i < hexadecimalNumber.Length && j >= 0; i++, j--)
            {
                temp += HexadecimalInteger(hexadecimalNumber[i]) * MathPow(16, j);
            }
            Console.WriteLine("The decimal representations of the hexadecimal number {0} is:\n{1}", input, temp);
            Restart(1);
        }
    }
}
