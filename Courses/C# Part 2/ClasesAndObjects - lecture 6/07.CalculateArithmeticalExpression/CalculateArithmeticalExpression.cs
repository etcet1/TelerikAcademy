using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//* Write a program that calculates the value of given arithmetical expression. The expression can contain the following
//elements only:
//Real numbers, e.g. 5, 18.33, 3.14159, 12.6
//Arithmetic operators: +, -, *, / (standard priorities)
//Mathematical functions: ln(x), sqrt(x), pow(x,y)
//Brackets (for changing the default priorities)
//    Examples:
//    (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)  ~ 10.6
//    pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)  ~ 21.22
//    Hint: Use the classical "shunting yard" algorithm and "reverse Polish notation".
//
//the solution is created according to the video lecture // and Wikipedia //

namespace ClasesAndObjects
{
    class CalculateArithmeticalExpression
    {
        static List<char> barcketSymbols = new List<char>() { '(', ')' };
        static List<char> mathOperators = new List<char>() { '+', '-', '*', '/' };
        static List<string> mathFunctions = new List<string>() { "pow", "sqrt", "ln" };


        static List<string> SeparatedElements(string input)
        {
            var elements = new List<string>();

            var numbers = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '-' && (i == 0 || input[i - 1] == ',' || input[i - 1] == '('))
                {
                    numbers.Append("-");
                }
                else if (char.IsDigit(input[i]) || input[i] == '.')
                {
                    numbers.Append(input[i]);
                }
                else if (!char.IsDigit(input[i]) && input[i] != '.' && numbers.Length != 0)
                {
                    elements.Add(numbers.ToString());
                    numbers.Clear();
                    i--;
                }
                else if (input[i] == ',')
                {
                    elements.Add(input[i].ToString());
                }
                else if (barcketSymbols.Contains(input[i]))
                {
                    elements.Add(input[i].ToString());
                }
                else if (mathOperators.Contains(input[i]))
                {
                    elements.Add(input[i].ToString());
                }
                else if (i + 1 < input.Length && input.Substring(i, 2).ToLower() == "ln")
                {
                    elements.Add("ln");
                    i++;
                }
                else if (i + 2 < input.Length && input.Substring(i, 3).ToLower() == "pow")
                {
                    elements.Add("pow");
                    i += 2;
                }
                else if (i + 3 < input.Length && input.Substring(i, 4).ToLower() == "sqrt")
                {
                    elements.Add("sqrt");
                    i += 3;
                }
                else
                {
                    throw new ArgumentException("Invalid expresssion!");
                }
            }

            if (numbers.Length != 0)
            {
                elements.Add(numbers.ToString());
            }

            return elements;
        }

        static int OperatorPrecedence(string arithmeticOperator)
        {
            if (arithmeticOperator == "+" || arithmeticOperator == "-")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        static Queue<string> ConvertToRPN(List<string> elements)
        {
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < elements.Count; i++)
            {
                var currentElement = elements[i];
                double number;

                if (double.TryParse(currentElement, out number))
                {
                    queue.Enqueue(currentElement);
                }
                else if (mathFunctions.Contains(currentElement))
                {
                    stack.Push(currentElement);
                }
                else if (currentElement == ",")
                {
                    if (!stack.Contains("(") || stack.Count == 0)
                    {
                        throw new ArgumentException("Invalid bracket or function operator!");
                    }

                    while (stack.Peek() != "(")
                    {
                        string currentOperator = stack.Pop();

                        queue.Enqueue(currentOperator);
                    }
                }
                else if (mathOperators.Contains(currentElement[0]))
                {
                    //if not working refactor logic for operator

                    while (stack.Count != 0 && mathOperators.Contains(stack.Peek()[0]) && OperatorPrecedence(currentElement) <= OperatorPrecedence(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    }

                    stack.Push(currentElement);
                }
                else if (currentElement == "(")
                {
                    stack.Push("(");
                }
                else if (currentElement == ")")
                {
                    if (!stack.Contains("(") || stack.Count == 0)
                    {
                        throw new ArgumentException("Invalid bracket position!");
                    }

                    while (stack.Count != 0 && stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }

                    stack.Pop();

                    if (stack.Count != 0 && mathFunctions.Contains(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }
            }

            while (stack.Count != 0)
            {
                if (barcketSymbols.Contains(stack.Peek()[0]))
                {
                    throw new ArgumentException("Invalid bracket position!");
                }

                queue.Enqueue(stack.Pop());
            }

            return queue;
        }

        //dealing with the commas using the InvariantCulture
        static void SetInvariantCulture()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        static double GetResultFromRPN(Queue<string> queue)
        {
            Stack<double> stack = new Stack<double>();

            while (queue.Count != 0)
            {
                string currentElement = queue.Dequeue();

                double number;

                if (double.TryParse(currentElement, out number))
                {
                    stack.Push(number);
                }
                else if (mathOperators.Contains(currentElement[0]) || mathFunctions.Contains(currentElement))
                {
                    if (currentElement == "+")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression!");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(firstValue + secondValue);
                    }
                    else if (currentElement == "-")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression!");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue - firstValue);
                    }
                    else if (currentElement == "*")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression!");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue * firstValue);
                    }
                    else if (currentElement == "/")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression!");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue / firstValue);
                    }
                    else if (currentElement == "pow")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression!");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(Math.Pow(secondValue, firstValue));
                    }
                    else if (currentElement == "sqrt")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Invalid expression!");
                        }

                        double firstValue = stack.Pop();

                        stack.Push(Math.Sqrt(firstValue));
                    }
                    else if (currentElement == "ln")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Invalid expression!");
                        }

                        double firstValue = stack.Pop();

                        stack.Push(Math.Log(firstValue));
                    }
                }
            }

            if (stack.Count == 1)
            {
                return stack.Pop();
            }
            else
            {
                throw new ArgumentException("Invalid expression!");
            }
        }

        static void Main()
        {
            SetInvariantCulture();

            Console.WriteLine("Please enter the expression:");
            string input = Console.ReadLine().Trim();
            string cleanedInput = input.Replace(" ", string.Empty);
            var separatedElements = SeparatedElements(cleanedInput);
            var reversedPolishNotation = ConvertToRPN(separatedElements);
            var finalresult = GetResultFromRPN(reversedPolishNotation);

            Console.WriteLine("The result of the expression is:\n{0}", finalresult);
        }
    }
}
