using System;
using System.Globalization;
using System.Threading;
/*
 * Write a program that reads the radius r of a circle and prints its perimeter and area.
 */

class ReadCircleRadiusPrintAreaAndPerimeter
{
    static void Main()
    {
        Console.WriteLine("Please enter the radius of a circle:");
        string inputError = "Invalid numbers!Please try again";
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;     // Change of the decimal separator to "."
        double PI = (double)22 / 7; //calculating PI number as double for accuracy
        double radius;
        if (!(double.TryParse(Console.ReadLine(), out radius))) // e.g. (int.TryParse(Console.ReadLine(), out firstNumber) == false
        {
            Console.WriteLine(inputError);
            return;
        }
        double circleArea = PI * Math.Pow(radius, 2);
        double circlePerimeter = 2 * PI * radius;
        Console.WriteLine("The perimeter of the circle with radius {0} is {1}\nThe area of the circle with radius {0} is {2}", radius, circlePerimeter,circleArea);
    }
}
