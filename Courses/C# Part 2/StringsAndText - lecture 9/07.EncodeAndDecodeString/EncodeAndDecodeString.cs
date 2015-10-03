using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence
//of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the
//string with the first of the key, the second – with the second, etc. When the last key character is reached,
//the next is the first.

namespace StringsAndText
{
    class EncodeAndDecodeString
    {
        static void Main()
        {
            string inputText;
            string cipher;

            Console.WriteLine("Please enter your string:");
            inputText = Console.ReadLine();

            Console.WriteLine("Please enter the cipher:");
            cipher = Console.ReadLine();

            string stringEncoded = Crypt(inputText, cipher);
            Console.WriteLine("Encoded: {0}\n", stringEncoded);


            string stringDecoded = Crypt(stringEncoded, cipher);
            Console.WriteLine("Decoded: {0}\n", stringDecoded);
        }

        private static string Crypt(string input, string cipher)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i += cipher.Length)
            {
                for (int j = 0; j < cipher.Length; j++)
                {
                    if (i + j > input.Length - 1)
                    {
                        break;
                    }
                    char temp = (char)(input[i + j] ^ cipher[j]);
                    sb.Append(temp);
                }
            }
            return sb.ToString();
        }
    }
}
