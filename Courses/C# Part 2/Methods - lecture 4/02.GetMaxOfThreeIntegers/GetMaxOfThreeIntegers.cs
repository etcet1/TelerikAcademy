using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().


namespace Methods
{
    class GetMaxOfThreeIntegers
    {
        static int GetMax(int firstInteger, int secondInteger)
        {
            int biggerInteger = new int();
            if (firstInteger>=secondInteger)
            {
                biggerInteger = firstInteger;
            }
            else if (firstInteger<secondInteger)
            {
                biggerInteger = secondInteger;
            }
            return biggerInteger;
        }
        static bool IsValidnumber(string consoleInput)
        {
            var temp=new int();
            if (int.TryParse(consoleInput, out temp))
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
            if (mode==0)
            {
                Console.WriteLine("Invalid input detected!");
            }
            else if(mode==1)
            {
                Console.WriteLine("The program ended:)!");
            }
            Console.WriteLine("Press any key to restart...");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        static void Main()
        {
            int tempBiggestNumber = new int();
            int tempInputNumber = new int();
            string input = string.Empty;
            Console.WriteLine("Please enter the first integer:");
            input = Console.ReadLine();
            if (IsValidnumber(input))
            {
                tempInputNumber = int.Parse(input);
            }
            else
	        {
                Restart(0);
	        }
            Console.WriteLine("Please enter the second integer:");
            input = Console.ReadLine();
            if (IsValidnumber(input))
            {
                tempBiggestNumber = GetMax(tempInputNumber, int.Parse(input));
            }
            else
            {
                Restart(0);
            }
            Console.WriteLine("Please enter the third integer:");
            input = Console.ReadLine();
            if (IsValidnumber(input))
            {
                tempBiggestNumber = GetMax(tempBiggestNumber, int.Parse(input));
            }
            else
            {
                Restart(0);
            }
            Console.WriteLine("The biggest enetred integer is {0}", tempBiggestNumber);
            Restart(1);
        }
    }
}
