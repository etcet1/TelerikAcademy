using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert binary numbers to their decimal representation.

namespace NumeralSystems
{
    class BinaryNumberToDecimal
    {

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

        //own mehod for power calculation faster than Math.Pow
        static int MathPow(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            Console.WriteLine(result);
            return result;
        }

        static void Main()
        {
            string binaryString = string.Empty;
            int decimalNumber = new int();
            string binaryNumber = string.Empty;
            string input;

            Console.WriteLine("Please enter the binary number:");
            input = Console.ReadLine();

            if (IsValidnumber(input) == false)
            {
                Restart(0);
            }
            else
            {
                binaryNumber = input;
            }
            int temp = new int();
            for (int i = 0, j = binaryNumber.Length-1; i < binaryNumber.Length&&j>=0; i++,j--)
			{
                temp += int.Parse(binaryNumber[i].ToString()) * MathPow(2, j);
			}
            Console.WriteLine("The decimal representations of the binary number {0} is:\n{1}", input, temp);
            Restart(1);
        }

    }
}
