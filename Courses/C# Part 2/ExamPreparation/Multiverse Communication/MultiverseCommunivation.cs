using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MultiverseCommunivation
    {
        static string Convert(string input)
        {
            string digit = string.Empty;
            switch (input)
            {
                case "CHU":
                    digit = "0";
                    break;
                case "TEL":
                    digit = "1";
                    break;
                case "OFT":
                    digit = "2";
                    break;
                case "IVA":
                    digit = "3";
                    break;
                case "EMY":
                    digit = "4";
                    break;
                case "VNB":
                    digit = "5";
                    break;
                case "POQ":
                    digit = "6";
                    break;
                case "ERI":
                    digit = "7";
                    break;
                case "CAD":
                    digit = "8";
                    break;
                case "K-A":
                    digit = "9";
                    break;
                case "IIA":
                    digit = "A";
                    break;
                case "YLO":
                    digit = "B";
                    break;
                case "PLA":
                    digit = "C";
                    break;
            }
            return digit.ToString();
        }

        static long ConvertToDec(string input)
        {
            long digit = new long();
            switch (input)
            {
                case "0":
                    digit = 0;
                    break;
                case "1":
                    digit = 1;
                    break;
                case "2":
                    digit = 2;
                    break;
                case "3":
                    digit = 3;
                    break;
                case "4":
                    digit = 4;
                    break;
                case "5":
                    digit = 5;
                    break;
                case "6":
                    digit = 6;
                    break;
                case "7":
                    digit = 7;
                    break;
                case "8":
                    digit = 8;
                    break;
                case "9":
                    digit = 9;
                    break;
                case "A":
                    digit = 10;
                    break;
                case "B":
                    digit = 11;
                    break;
                case "C":
                    digit = 12;
                    break;
            }
            return digit;
        }

        static void Main()
        {
            string input = Console.ReadLine();
            long offset = input.Length / 3;
            long decmalOffset = new long();
            string[] parts = new string[offset];
            long j = 0;
            for (int i = 0; i < offset; i++)
            {
                parts[j] = input.Substring(3 * i, 3);
                j++;
                decmalOffset++;
            }
            long decimalDigit = new long();
            j = 0;
            for (long i = parts.Length - 1; i >= 0; i--)
            {
                if (j > 0)
                {
                    decimalDigit += ConvertToDec(Convert(parts[i])) * (long)Math.Pow((double)13,(double)j);
                }
                else
                {
                    decimalDigit += ConvertToDec(Convert(parts[i]));
                }
                j++;
            }
            Console.WriteLine(string.Join(",  ", decimalDigit));
        }
    }
}
