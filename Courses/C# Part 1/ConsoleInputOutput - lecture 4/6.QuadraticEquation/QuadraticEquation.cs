using System;

/*
 * Write a program that reads the coefficients a, b and c of a quadratic equation 
 * ax2+bx+c=0 and solves it (prints its real roots).
 */

class QuadraticEquation
{
    static float firstParameter = 0.0f;
    static float secondParameter = 0.0f;
    static float thirdParameter = 0.0f;

    static void Main()
    {
        string inputError = "Invalid numbers!Please try again";
        Console.WriteLine("Please fill the values a,b and c of the equation ax2+bx+c=0\n");
        Console.WriteLine("Enter the first parameter a:");
        if (!(float.TryParse(Console.ReadLine(), out firstParameter))) // e.g. (int.TryParse(Console.ReadLine(), out firstNumber) == false
        {
            Console.WriteLine(inputError);
            return;
        }
        Console.WriteLine("Enter the first parameter b:");
        if (!(float.TryParse(Console.ReadLine(), out secondParameter))) // e.g. (int.TryParse(Console.ReadLine(), out secondnumber) == false
        {
            Console.WriteLine(inputError);
            return;
        }
        Console.WriteLine("Enter the third parameter c:");
        if (!(float.TryParse(Console.ReadLine(), out thirdParameter))) // e.g. (int.TryParse(Console.ReadLine(), out secondnumber) == false
        {
            Console.WriteLine(inputError);
            return;
        }
        //calculating the Discriminant of the eqation D = b^2 - 4ac
        float discriminant =(float)Math.Pow(secondParameter,2) - (4 * firstParameter * thirdParameter);
        if (discriminant < 0)
        {
            Console.WriteLine("The equation has no real roots.");
        }
        else if (discriminant == 0)
        {
            float root = -(secondParameter / (2 * firstParameter));
            Console.WriteLine("The equation has one root:{0}", root);
        }
        else if (discriminant > 0)
        {
            float firstRoot =(float)((-secondParameter) + Math.Sqrt(discriminant)) / (2 * firstParameter);
            float secondRoot = (float)((-secondParameter) - Math.Sqrt(discriminant)) / (2 * firstParameter);
            Console.WriteLine("The equation has two roots:\n{0}\n{1}",firstRoot,secondRoot);
        }
        else
        {
            Console.WriteLine("The equation has invalid parameters.Please try again.");
            return;
        }
        ResetCalculations();
    }
    //Return the console to the initial state in order to continue with the calculation
    static void ResetCalculations()
    {
        firstParameter = new float();
        secondParameter = new float();
        thirdParameter = new float();
        Console.WriteLine();
        Console.WriteLine("Press any key to continue with the calculation");
        Console.ReadKey(true);
        Console.Clear();
        Main();
    }
}
