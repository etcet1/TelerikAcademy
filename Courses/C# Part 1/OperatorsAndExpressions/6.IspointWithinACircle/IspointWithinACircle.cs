using System;

/*
 * Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
 */

class IspointWithinACircle
{
    static void Main()
    {
        Console.WriteLine("Please enter the coordinates of the point.\nCoordinate X");
        int coordinateX = int.Parse(Console.ReadLine());
        Console.WriteLine("Coordinate Y:");
        int coordinateY = int.Parse(Console.ReadLine());
        bool checkValues = ((Math.Pow(coordinateX, 2) + Math.Pow(coordinateY, 2)) <= Math.Pow(5,2))? true : false ;
        string isWithin = (checkValues == true) ? "within": "not within" ;
        Console.WriteLine("A point with coordinates ({0},{1}) is {2} a circle K(0, 5).",coordinateX,coordinateY,isWithin);
    }
}
