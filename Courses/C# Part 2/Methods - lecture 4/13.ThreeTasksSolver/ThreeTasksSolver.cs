using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

namespace Methods
{
    class ThreeTasksSolver
    {
        //check if the input actually is a valid integer
        static bool IsValidnumber(string consoleInput)
        {
            var temp = new int();
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
        static string Reverse(string inputdecimal)
        {
            string result = string.Empty;
            //check for negative sign and remove it from the original string
            if (inputdecimal[0].ToString() == "-")
            {
                result += inputdecimal[0].ToString();
                inputdecimal = inputdecimal.Remove(0, 1);
            }
            //reverse the integer
            for (int i = inputdecimal.Length - 1; i >= 0; i--)
            {
                result += inputdecimal[i].ToString();
            }

            return result;
        }
        static void AverageInteger(int[] sequenceArray)
        {
            int sum = 0;
            for (int i = 0; i < sequenceArray.Length; i++)
            {
                sum += sequenceArray[i];
            }
            Console.WriteLine("The average of a sequence of integers {0} is {1}.", string.Join(", ", sequenceArray), sum / sequenceArray.GetLength(0));
        }
        static void LinearEquation(decimal a, decimal b)
        {
            if (a==0)
            {
                Console.WriteLine("Parameter a cannot be 0.");
                Restart(1);
            }
            else
            {
                Console.WriteLine("The solution of the linear equation {0} * x + {1} = 0 is {2}", a, b,-(b) / a);
            }
        }
        static void Main()
        {
            Console.WriteLine("What you like to do?");
            Console.WriteLine("1 - Reverse digits of number");
            Console.WriteLine("2 - Calculates the average of a sequence of integers");
            Console.WriteLine("3 - Solves a linear equation a * x + b = 0");
            int input = int.Parse(Console.ReadLine());
            if (IsValidnumber(input.ToString()) == false)
            {
                Restart(0);
            }
            if (input == 1)
            {
                Console.WriteLine("Please enter an integer:");
                string integerInput = Console.ReadLine();
                if (IsValidnumber(integerInput))
                {
                    Console.WriteLine("The original integer is {0}", integerInput);
                    Console.WriteLine("The reversed integer is {0}", Reverse(integerInput));
                    Restart(1);
                }
                else
                {
                    Restart(0);
                }
            }
            else if (input == 2)
            {
                Console.WriteLine("Please enter the length of the sequence:");
                string integerInput = Console.ReadLine();
                if (IsValidnumber(integerInput))
                {
                    int sequenceLength = int.Parse(integerInput);
                    int[] sequenceArray = new int[sequenceLength];
                    for (int i = 0; i < sequenceArray.GetLength(0); i++)
                    {
                        integerInput = Console.ReadLine();
                        if (IsValidnumber(integerInput))
                        {

                            sequenceArray[i] = int.Parse(integerInput);
                        }
                        else
                        {
                            Restart(0);
                        }
                    }
                    AverageInteger(sequenceArray);
                    Restart(1);
                }
                else
                {
                    Restart(0);
                }
            }
            else if (input == 3)
            {
                Console.WriteLine("Please enter value a:");
                string integerInput = Console.ReadLine();
                decimal a = new decimal();
                decimal b = new decimal();
                if (IsValidnumber(integerInput))
                {
                    a = decimal.Parse(integerInput);
                }
                else
                {
                    Restart(0);
                }
                Console.WriteLine("Please enter value b:");
                integerInput = Console.ReadLine();
                if (IsValidnumber(integerInput))
                {
                    b = decimal.Parse(integerInput);
                }
                else
                {
                    Restart(0);
                }
                LinearEquation(a, b);
                Restart(1);
            }
            else
            {
                Restart(0);
            }
        }
    }
}