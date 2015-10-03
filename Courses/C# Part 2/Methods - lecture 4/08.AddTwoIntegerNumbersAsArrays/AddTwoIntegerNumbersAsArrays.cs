using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i]
//contains a digit; the last digit is kept in arr[0]). 
//Each of the numbers that will be added could have up to 10 000 digits.

namespace Methods
{
    class AddTwoIntegerNumbersAsArrays
    {
        //validate the input and transform it to char array
        static List<char> ValidateTransformInput(char[] input)
        {
            char[] digits={'1','2','3','4','5','6','7','8','9','0'};
            List<char> resultNumber = new List<char>();
            for (int i = input.Length-1; i >=0; i--)
            {
                if (digits.Contains(input[i]))
                {
                    resultNumber.Add(input[i]);
                }
                else
                {
                    Restart(0);
                    break;
                }
            }
            return resultNumber;
        }
        static string CalculateResult(List<char> firstNumber, List<char> secondNumber)
        {
            List<char> resultCalcuation = new List<char>();
            int addition = new int();
            int numberLength = new int();
            if (firstNumber.Count>=secondNumber.Count)
            {
                numberLength = firstNumber.Count;
                //add zero elements to the shorter array in order to avoid out of range exception
                int listDifference = firstNumber.Count - secondNumber.Count;
                for (int j = 0; j <= listDifference; j++)
                {
                    secondNumber.Add('0');
                }
            }
            else
            {
                numberLength = secondNumber.Count;
                //add zero elements to the shorter array in order to avoid out of range exception
                int listDifference = secondNumber.Count - firstNumber.Count;
                for (int j = 0; j <= listDifference; j++)
                {
                    firstNumber.Add('0');
                }
            }
            for (int i = 0; i < numberLength; i++)
			{
                if (i == 0)
                {
                    addition = (int.Parse(firstNumber[i].ToString()) + int.Parse(secondNumber[i].ToString())) % 10;
                }
                else
                {
                    addition = ((int.Parse(firstNumber[i].ToString()) + int.Parse(secondNumber[i].ToString())) % 10) +
                   ((int.Parse(firstNumber[i - 1].ToString()) + int.Parse(secondNumber[i - 1].ToString())) / 10);
                }
                //represent the int as char and add it to the char list with the results
                resultCalcuation.Add(Convert.ToChar(addition.ToString()));
            }
            //reversing of the list in order to print the digits iin the right direction
            resultCalcuation.Reverse();
            string printResult = string.Empty;
            foreach (var result in resultCalcuation)
	        {
		        printResult+=result;
	        }
            return printResult;
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
            List<char> firstNumber = new List<char>();
            List<char> secondNumber = new List<char>();
            Console.WriteLine("Please enter the first number:");
            firstNumber = ValidateTransformInput(Console.ReadLine().ToCharArray());
            Console.WriteLine("Please enter the second number:");
            secondNumber = ValidateTransformInput(Console.ReadLine().ToCharArray());
            string result = CalculateResult(firstNumber, secondNumber);
            Console.WriteLine("The sum of the numbers is {0}",result);
            Restart(1);
        }
    }
}
