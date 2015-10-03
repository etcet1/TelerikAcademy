using System;

/*
 * Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) 
 * and out of the rectangle R(top=1, left=-1, width=6, height=2).
 */


class IsPointWithinCircleAndOutOfRectangle
{
    static void Main()
    {
        Console.WriteLine("Please enter the coordinates of the point.\nCoordinate X");
        int coordinateX = int.Parse(Console.ReadLine());
        Console.WriteLine("Coordinate Y:");
        int coordinateY = int.Parse(Console.ReadLine());

        // Circle coordinates K( (1,1), 3)
        int xCircle = 1;
        int yCircle = 1;
        int radiusCircle = 3;
        
        //Rectangle coordinates R(top=1, left=-1, width=6, height=2)
        int xLeftRectangle = -1;
        int yLeftRectangle = 1; 
        int width = 6;
        int height = 2;
        int xRightRectangle = xLeftRectangle + width;
        int yRightRectangle = yLeftRectangle - height;
        //Check if the point is within the circle
        bool checkInCircle = ((Math.Pow(coordinateX, 2) + Math.Pow(coordinateY, 2)) <= Math.Pow(radiusCircle, 2)) ? true : false;
        string isWithinCircle = (checkInCircle == true) ? "within" : "out of";
        //Check if the point is within the rectangle
        bool checkOutOfRectangle = ((coordinateX < xLeftRectangle || coordinateX > xRightRectangle) || (coordinateY > yLeftRectangle || coordinateY < yRightRectangle));
        string isWithinRectangle = (checkOutOfRectangle == true) ? "out of" : "within";

        Console.WriteLine("Point ({0},{1}) is {2} a circle K( (1,1), 3) and {3}\nrectangle R(top=1, left=-1, width=6, height=2).", coordinateX, coordinateY, isWithinCircle, isWithinRectangle);
    }
}
