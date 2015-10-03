using System;
/*
 *Write an expression that calculates rectangle’s area by given width and height.
 */

class RectanglesAreaByWidthAandHeight
{
    static void Main()
    {
        //Using var for the dimentions as they may be integers or floating point numbers
        var width = 5.4;
        var height = 4;
        var area = width * height;
        Console.WriteLine("The area of rectangle with width {0} and height {1} is: {2}", width, height, area);
    }
}
