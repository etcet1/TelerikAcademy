using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
//Use variable number of arguments.
//* Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, 
//etc.). Use generic method (read in Internet about generic methods in C#).

namespace Methods
{
    class ModifiedSetOfIntegercalculations
    {
        static bool IsValidnumber(string input)
        {
            char[] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (digits.Contains(input[i]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
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
        static T Multiply<T>(List<T> testList)
        {
            dynamic result = 1;
            for (int i = 0; i < testList.Count; i++)
            {
                result = result * (dynamic)testList[i];
            }
            return result;
        }
        static T Average<T>(List<T> testList)
        {
            dynamic result = Summary((dynamic)testList) / (dynamic)testList.Count;
            return result;
        }
        static T Summary<T>(List<T> testList)
        {
            dynamic result = 0;
            for (int i = 0; i < testList.Count; i++)
            {
                result = result + (dynamic)testList[i];
            }
            return result;
        }
        static T Maximum<T>(List<T> testList)
        {
            dynamic maxElement = testList[0];
            for (int i = 0; i < testList.Count; i++)
            {
                if ((dynamic)testList[i] > maxElement)
                {
                    maxElement = testList[i];

                }
            }
            return maxElement;
        }
        static T Minimum<T>(List<T> testList)
        {
            dynamic minElement = testList[0];
            for (int i = 0; i < testList.Count; i++)
            {
                if ((dynamic)testList[i] < minElement)
                {
                    minElement = testList[i];
                }
            }
            return minElement;
        }
        static void Main()
        {
            Console.WriteLine("Please enter a sequence of integers and type \"end\" when ready.");
            List<dynamic> listSequence = new List<dynamic>();
            dynamic input = Console.ReadLine();
            if (IsValidnumber(input) == false)
            {
                Restart(0);
            }
            while (input != "end")
            {
                if (input == "end")
                {
                    break;
                }
                else if (IsValidnumber(input) == false)
                {
                    Restart(0);
                }
                else
                {
                    //the example works with decimal in order to return right results at average
                    //but could be chaged to other types as int,double,float but not string 
                    //as the input is being validated 
                    listSequence.Add(Convert.ToDecimal(input));
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("The minimum number of the set of integers {0} is:\n {1}", string.Join(", ", listSequence), Minimum(listSequence));
            Console.WriteLine("The maximum number of the set of integers {0} is:\n {1}", string.Join(", ", listSequence), Maximum(listSequence));
            Console.WriteLine("The average of the set of integers {0} is:\n {1}", string.Join(", ", listSequence), Average(listSequence));
            Console.WriteLine("The sum of the set of integers {0} is:\n {1}", string.Join(", ", listSequence), Summary(listSequence));
            Console.WriteLine("The product of the set of integers {0} is:\n {1}", string.Join(", ", listSequence), Multiply(listSequence));
            Restart(1);
        }
    }
}
