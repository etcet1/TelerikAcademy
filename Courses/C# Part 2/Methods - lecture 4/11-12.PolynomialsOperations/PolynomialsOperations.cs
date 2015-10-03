using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//        x2 + 5 = 1x2 + 0x + 5 
//Extend the program to support also subtraction and multiplication of polynomials.

namespace Methods
{
    class PolynomialsOperations
    {
        //print the polinomial expression
        static void PrintPolinomial(List<int> polinomial)
        {
            for (int i = polinomial.Count - 1; i >= 0; i--)
            {
                if (polinomial[i] != 0 && i != 0)
                {
                    if (polinomial[i - 1] >= 0)
                    {
                        Console.Write("{1}x^{0} + ", i, polinomial[i]);
                    }
                    else
                    {
                        Console.Write("{1}x^{0} ", i, polinomial[i]);
                    }
                }
                else if (i == 0)
                {
                    Console.Write("{0}", polinomial[i]);
                }
            }

            Console.WriteLine();
        }
        static List<int> SumOfPolinomials(List<int> firstPolinomial, List<int> secondPolinomial)
        {
            int resultLenght = (firstPolinomial.Count>=secondPolinomial.Count?firstPolinomial.Count:secondPolinomial.Count);
            //adding zero elements to the smaller list array in order to prevent out of range exception
            for (int i = 0; i < resultLenght; i++)
            {
                if (firstPolinomial.Count>secondPolinomial.Count)
                {
                    secondPolinomial.Add(0);
                }
                else if (firstPolinomial.Count<secondPolinomial.Count)
                {
                    firstPolinomial.Add(0);
                }
            }
            List<int> result = new List<int>();
            for (int i = 0; i < resultLenght; i++)
            {
                result.Add(firstPolinomial[i] + secondPolinomial[i]);
            }
            return result;
        }
        static List<int> SubtractionOfPolinomials(List<int> firstPolinomial, List<int> secondPolinomial)
        {
            int resultLenght = (firstPolinomial.Count >= secondPolinomial.Count ? firstPolinomial.Count : secondPolinomial.Count);
            //adding zero elements to the smaller list array in order to prevent out of range exception
            for (int i = 0; i < resultLenght; i++)
            {
                if (firstPolinomial.Count > secondPolinomial.Count)
                {
                    secondPolinomial.Add(0);
                }
                else if (firstPolinomial.Count < secondPolinomial.Count)
                {
                    firstPolinomial.Add(0);
                }
            }
            List<int> result = new List<int>();
            for (int i = 0; i < resultLenght; i++)
            {
                result.Add(firstPolinomial[i] - secondPolinomial[i]);
            }
            return result;
        }
        static List<int> MultiplicationOfPolinomials(List<int> firstPolinomial, List<int> secondPolinomial)
        {
            int resultLenght = (firstPolinomial.Count >= secondPolinomial.Count ? firstPolinomial.Count : secondPolinomial.Count);
            //adding zero elements to the smaller list array in order to prevent out of range exception
            for (int i = 0; i < resultLenght; i++)
            {
                if (firstPolinomial.Count > secondPolinomial.Count)
                {
                    secondPolinomial.Add(0);
                }
                else if (firstPolinomial.Count < secondPolinomial.Count)
                {
                    firstPolinomial.Add(0);
                }
            }
            List<int> result = new List<int>();
            //populate the List with the needed zero values for each multiplication
            for (int i = 0; i < firstPolinomial.Count + secondPolinomial.Count; i++)
            {
                result.Add(0);
            }
            for (int j = 0; j < firstPolinomial.Count; j++)
            {
                for (int k = 0; k < secondPolinomial.Count; k++)
                {
                    int position = j + k;
                    result[position] += (firstPolinomial[j] * secondPolinomial[k]);
                }
            }
            return result;
        }
        static void Main()
        {
            //input
            List<int> firstPolinomial = new List<int>{ 5, -1 };
            Console.WriteLine("First polinomial:");
            PrintPolinomial(firstPolinomial);

            List<int> secondPolinomial = new List<int>{ 10, -5, 6 };
            Console.WriteLine("Second polinomial:");
            PrintPolinomial(secondPolinomial);

            //sum
            Console.WriteLine("The sum of the polinomials is:");
            List<int> sumResult=SumOfPolinomials(firstPolinomial, secondPolinomial);
            PrintPolinomial(sumResult);

            //subtraction
            Console.WriteLine("The subtraction of the polinomials is:");
            List<int> subtractionResult = SubtractionOfPolinomials(firstPolinomial, secondPolinomial);
            PrintPolinomial(subtractionResult);

            //multiplication
            Console.WriteLine("The multiplication of the polinomials is:");
            List<int> mutiplicationResult = MultiplicationOfPolinomials(firstPolinomial, secondPolinomial);
            PrintPolinomial(mutiplicationResult);

        }
    }
}
