using System;

/*
 * Write a program that shows the sign (+ or -) of the product of three
 * real numbers without calculating it. Use a sequence of if statements.
 */

class ShowSignOfProductOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter the first number");
        string input1 = Console.ReadLine();
        int firstNumberInteger;
        double firstNumberDouble;
        dynamic firstNumber;
        //test the input in order to get its type
        if (int.TryParse(input1, out firstNumberInteger))
        {
            firstNumber = firstNumberInteger;
        }
        else if (double.TryParse(input1, out firstNumberDouble))
        {
            firstNumber = firstNumberDouble;
        }
        else
	    {
            firstNumber = input1;
            Console.WriteLine("{0} is not a number", input1);
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Console.Clear();
            Main();
    	}
        Console.WriteLine("Please enter the second number");
        string input2 = Console.ReadLine();
        int secondNumberInteger;
        double secondNumberDouble;
        dynamic secondNumber;
        //test the input in order to get its type
        if (int.TryParse(input2, out secondNumberInteger))
        {
            secondNumber = secondNumberInteger;
        }
        else if (double.TryParse(input2, out secondNumberDouble))
        {
            secondNumber = secondNumberDouble;
        }
        else
        {
            secondNumber = input2;
            Console.WriteLine("{0} is not a number", input2);
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Console.Clear();
            Main();
        }
        Console.WriteLine("Please enter the third number");
        string input3 = Console.ReadLine();
        int thirdNumberInteger;
        double thirdNumberDouble;
        dynamic thirdNumber;
        //test the input in order to get its type
        if (int.TryParse(input3, out thirdNumberInteger))
        {
            thirdNumber = thirdNumberInteger;
        }
        else if (double.TryParse(input3, out thirdNumberDouble))
        {
            thirdNumber = thirdNumberDouble;
        }
        else
        {
            thirdNumber = input3;
            Console.WriteLine("{0} is not a number", input3);
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Console.Clear();
            Main();
        }
        if (firstNumber>0 && secondNumber>0 && thirdNumber > 0)
        {
            Console.WriteLine("The product of the three numbers {0},{1} and {2} is with sign \"+\"", firstNumber, secondNumber, thirdNumber);
        }
        else if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The product of the three numbers {0},{1} and {2} is with 0.", firstNumber, secondNumber, thirdNumber);
        }
        else
        {
            Console.WriteLine("The product of the three numbers {0},{1} and {2} is with sign \"-\"", firstNumber, secondNumber, thirdNumber);
        }
        Console.WriteLine("Press any key to restart");
        Console.ReadKey(true);
        Console.Clear();
        Main();
    }
}