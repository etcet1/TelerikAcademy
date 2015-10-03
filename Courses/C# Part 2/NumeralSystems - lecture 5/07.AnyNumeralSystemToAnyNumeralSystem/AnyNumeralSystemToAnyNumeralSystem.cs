using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

namespace NumeralSystems
{
    class AnyNumeralSystemToAnyNumeralSystem
    {
        static int ConvertToDecimalSystem(char symbol)
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
                //uppercase
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
                //lowercase
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

        static char ConvertToNewNumeralSystem(int symbol)
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

        //own mehod for power calculation
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
            if (result == true)
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
            string input;
            string oldNumeralSystemNumber = string.Empty;
            int oldNumeralSystem = new int();
            int decimalNumber = new int();
            int newNumeralSystem = new int();
            List<char> newNumeralSystemNumber = new List<char>();

            Console.WriteLine("Please enter the number:");
            input = Console.ReadLine();
          
            //validate input - accepts both lowercase and uppercase
            if (IsValidnumber(input) == false)
            {
                Restart(0);
            }
            else
            {
                oldNumeralSystemNumber = input;
            }

            Console.WriteLine("Please enter the input numeral system with base between 2 and 16:");
            input = Console.ReadLine();
           
            //validate input
            if (IsValidnumber(input) == false)
            {
                Restart(0);
            }
            else
            {
                oldNumeralSystem = int.Parse(input);
            }

            Console.WriteLine("Please enter the new numeral system with base between 2 and 16:");
            input = Console.ReadLine();
           
            //validate input
            if (IsValidnumber(input) == false)
            {
                Restart(0);
            }
            else
            {
                newNumeralSystem = int.Parse(input);
            }

            //conversion of the original number to decimal  
            for (int i = 0, j = oldNumeralSystemNumber.Length - 1; i < oldNumeralSystemNumber.Length && j >= 0; i++, j--)
            {
                decimalNumber += ConvertToDecimalSystem(oldNumeralSystemNumber[i]) * MathPow(oldNumeralSystem, j);
            }

            //conversion of the decimal number to the new system
            char tempChar = new char();
            while (decimalNumber > 0)
            {
                tempChar = ConvertToNewNumeralSystem(decimalNumber % newNumeralSystem);
                decimalNumber = decimalNumber / newNumeralSystem;
                if (tempChar == 'Z')
                {
                    Restart(0);
                }
                else
                {
                    newNumeralSystemNumber.Add(tempChar);
                }
            }

            //print the result using concatenation
            newNumeralSystemNumber.Reverse();
            Console.WriteLine("The number {0} represented in numeral sytem with base {1} is {2}",oldNumeralSystemNumber,newNumeralSystem,string.Concat(newNumeralSystemNumber));
        }
    }
}
