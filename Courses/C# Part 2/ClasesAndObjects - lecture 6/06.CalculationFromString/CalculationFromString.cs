using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that
//reads these values from given string and calculates their sum. Example:
//        string = "43 68 9 23 318"  result = 461

namespace ClasesAndObjects
{
    class CalculationFromString
    {
        static List<int> NumbersFromString(string numberSequence)
        {
            List<string> numbersAsString = new List<string>();
            List<int> numbers = new List<int>();

            //split the string into separate number strings
            numbersAsString = numberSequence.Split(' ').ToList();

            //convert the number strings to numbers and add them to a list with integers
            foreach (var item in numbersAsString)
            {
                numbers.Add(int.Parse(item));
            }

            return numbers;
        }

        static int CalculateResult(string numberSequence)
        {
            List<int> numbers = new List<int>();
            int calculatedResult = new int();

            numbers = NumbersFromString(numberSequence);
            foreach (var number in numbers)
            {
                calculatedResult += number;
            }

            return calculatedResult;
        }

        static void Main()
        {
            string input;
            int result;

            try
            {
                Console.WriteLine("Please enter your numbers separated with \" \":");
                input = Console.ReadLine();
                result = CalculateResult(input);

                Console.WriteLine("The sum of the numbers {0} is {1}.", input, result);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid input number!");
            }
        }
    }
}
