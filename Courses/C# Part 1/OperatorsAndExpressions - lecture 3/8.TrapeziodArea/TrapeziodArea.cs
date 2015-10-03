using System;

/*
 * Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */

class TrapeziodArea
{
    static void Main()
    {
        Console.WriteLine("Please enter the sides and the hight of the trapezoid.\n Side A");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Side B:");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Height");
        double height = double.Parse(Console.ReadLine());
        if (sideA<=0||sideB<=0||height<=0)
	    {
		 Console.WriteLine("\nInvalid input data.All values must be higher than 0.");
        }
        else
        {
            double trapezoidArea = ((sideA + sideB) / 2) * height;
            Console.WriteLine("\nThe area of trapzeoid with side {0} and side {1} and height {2} is {3}", sideA, sideB, height, trapezoidArea);
        }
    }
}
