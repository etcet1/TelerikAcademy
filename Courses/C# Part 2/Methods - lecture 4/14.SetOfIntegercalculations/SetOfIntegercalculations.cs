using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

namespace Methods
{

    class SetOfIntegercalculations
    {
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
        static long Multiply(List<int> testList)
        {
            long result = 1;
            for (int i = 0; i < testList.Count; i++)
            {
                result = result * testList[i];
            }
            return result;
        }
        static decimal Average(List<int> testList)
        {
            decimal result = Summary(testList) / testList.Count;
            return result;
        }
        static int Summary(List<int> testList)
        {
            int result = new int();
            for (int i = 0; i < testList.Count; i++)
            {
                result = result + testList[i];
            }
            return result;
        }
        static int Maximum(List<int> testList)
        {
            int maxElement = int.MinValue;
            for (int i = 0; i < testList.Count; i++)
            {
                if (testList[i] > maxElement)
                {
                    maxElement = testList[i];

                }
            }
            return maxElement;
        }
        static int Minimum(List<int> testList)
        {
            int minElement = int.MaxValue;
            for (int i = 0; i < testList.Count; i++)
            {
                if (testList[i] < minElement)
                {
                    minElement = testList[i];
                }
            }
            return minElement;
        }
        static void Main()
        {
            Console.WriteLine("Please enter a sequence of integers and type \"end\" when ready.");
            List<int> listSequence = new List<int>();
            string input = Console.ReadLine();
            if (IsValidnumber(input) == false)
            {
                Restart(0);
            }
            while (input!="end")
            {
                if (input=="end")
                {
                    break;
                }
                else if (IsValidnumber(input) == false)
                {
                    Restart(0);
                }
                else
                {
                    listSequence.Add(int.Parse(input));
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("The minimum number of the set of integers {0} is:\n {1}",string.Join(", ", listSequence), Minimum(listSequence));
            Console.WriteLine("The maximum number of the set of integers {0} is:\n {1}", string.Join(", ", listSequence), Maximum(listSequence));
            Console.WriteLine("The average of the set of integers {0} is:\n {1}", string.Join(", ", listSequence), Average(listSequence));
            Console.WriteLine("The sum of the set of integers {0} is:\n {1}", string.Join(", ", listSequence), Summary(listSequence));
            Console.WriteLine("The product of the set of integers {0} is:\n {1}", string.Join(", ", listSequence), Multiply(listSequence));
            Restart(1);
        }
    }
}
