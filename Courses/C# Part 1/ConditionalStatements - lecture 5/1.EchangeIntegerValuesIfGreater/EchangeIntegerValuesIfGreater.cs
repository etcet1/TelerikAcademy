using System;

/*
 * Write an if statement that examines two integer variables and 
 * exchanges their values if the first one is greater than the second one.
 */

class EchangeIntegerValuesIfGreater
{
    static void Main()
    {
        int fisrtNumber = 6;
        int secondNumber = 5;

        Console.WriteLine("The initial values are {0} and {1}.",fisrtNumber, secondNumber );
        if (fisrtNumber>secondNumber)
        {
            Console.WriteLine("{0} is greater than {1}.", fisrtNumber, secondNumber);
            int temp = fisrtNumber + secondNumber;
            secondNumber = temp - secondNumber;
            fisrtNumber = temp - fisrtNumber;
            Console.WriteLine("The new value of the first number is {0} and the new value of the second number is {1}", fisrtNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("The first number is not greater so we will keep the values of the numbers.");
        }
    }
}
