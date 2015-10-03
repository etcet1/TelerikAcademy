using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert binary numbers to hexadecimal numbers (directly).

namespace NumeralSystems
{
    class BinaryNumberToHexadecimal
    {
        static string HexadecimalInteger(string symbol)
        {
            string hexInteger = string.Empty;
            switch (symbol)
            {
                case "0000":
                    hexInteger = "0";
                    break;
                case "0001":
                    hexInteger = "1";
                    break;
                case "0010":
                    hexInteger = "2";
                    break;
                case "0011":
                    hexInteger = "3";
                    break;
                case "0100":
                    hexInteger = "4";
                    break;
                case "0101":
                    hexInteger = "5";
                    break;
                case "0110":
                    hexInteger = "6";
                    break;
                case "0111":
                    hexInteger = "7";
                    break;
                case "1000":
                    hexInteger = "8";
                    break;
                case "1001":
                    hexInteger = "9";
                    break;
                //uppercase hex
                case "1010":
                    hexInteger = "A";
                    break;
                case "1011":
                    hexInteger = "B";
                    break;
                case "1100":
                    hexInteger = "C";
                    break;
                case "1101":
                    hexInteger = "D";
                    break;
                case "1110":
                    hexInteger = "E";
                    break;
                case "1111":
                    hexInteger = "F";
                    break;
                default:
                    hexInteger = "-1";
                    break;
            }
            return hexInteger;
        }
        static bool IsValidnumber(string input)
        {
            char[] digits = { '1', '0'};
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
            Console.WriteLine("Please enter the binary number:");
            string input = Console.ReadLine();
            string binaryNumber = string.Empty;
            if (IsValidnumber(input) == false)
            {
                Restart(0);
            }
            else
            {
                binaryNumber = input;
            }
            //convert the input to list of strings with length of four symbol needed for direct 
            //conversion from binary to hexadecimal
            List<string> binaryNumberGroup = new List<string>();
            //adding zeros to the left of the string in order to receive string length which could be divided by 4 without
            //remainder
            while (binaryNumber.Length % 4 != 0)
	        {
	            binaryNumber = binaryNumber.PadLeft(binaryNumber.Length+1,'0');
	        }
            //calculating the offsets in order to separate the input in groups of 4 digits needed for the conversion
            int binaryNumberOffset = binaryNumber.Length / 4;
            //split the input and add each group as element in the array
            for (int i = 0; i < binaryNumberOffset; i ++)
            {
                    binaryNumberGroup.Add(binaryNumber.Substring(i*4, 4));
            }
            //convert and print the hexadecimal number
            string temp = string.Empty;
            for (int i = 0, j = binaryNumberGroup.Count - 1; i < binaryNumberGroup.Count && j >= 0; i++, j--)
            {
                temp += HexadecimalInteger(binaryNumberGroup[i]);
            }
            Console.WriteLine("The hexadecimal representations of the binary number {0} is:\n{1}", input, temp);
            Restart(1);
        }
    }
}