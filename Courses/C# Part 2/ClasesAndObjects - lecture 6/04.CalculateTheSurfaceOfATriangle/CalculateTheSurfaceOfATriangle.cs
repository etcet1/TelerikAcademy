using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

namespace ClasesAndObjects
{
    class CalculateTheSurfaceOfATriangle
    {
        static double SurfaceFromSideAndAltitude(double side, double altitude)
        {
            double triangleArea;

            triangleArea = (side * altitude) / 2;
            return triangleArea;
        }

        static double SurfaceFromThreeSides(double sideOne, double sideTwo, double sideThree)
        {
            double halfPerimeter;
            double triangleArea;

            halfPerimeter = (sideOne + sideTwo + sideThree) / 2;
            triangleArea = Math.Sqrt(halfPerimeter*(halfPerimeter-sideOne)*(halfPerimeter-sideTwo)*(halfPerimeter-sideThree));
            return triangleArea;
        }

        static double SurfaceFromTwoSidesAndAngle(double sideOne, double sideTwo, double angle)
        {
            double sineAngle;
            double triangleArea;

            sineAngle = Math.Sin(Math.PI * angle / 180.0);
            triangleArea = (sideOne * sideTwo * sineAngle) / 2;

            return triangleArea;
        }

        static void Main()
        {
            int methodChoice;

            Console.WriteLine("Please choose the method for calculation of the transgle area:");
            Console.WriteLine("1 - with side and altitude");
            Console.WriteLine("2 - with three sides");
            Console.WriteLine("3 - with two sides and angle between them");
            Console.WriteLine("Your choice:");

            try
            {
                methodChoice = int.Parse(Console.ReadLine());
                if (methodChoice == 1)
                {
                    double side;
                    double altitude;
                    double triangleArea;

                    Console.WriteLine("Enter the triangle's side:");
                    side = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the triangle's altitude:");
                    altitude = double.Parse(Console.ReadLine());

                    triangleArea = SurfaceFromSideAndAltitude(side, altitude);
                    Console.WriteLine("The area of the triangle is {0}", triangleArea);
                }
                else if (methodChoice == 2)
                {
                    double sideOne;
                    double sideTwo;
                    double sideThree;
                    double triangleArea;

                    Console.WriteLine("Enter the first side:");
                    sideOne = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second side:");
                    sideTwo = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the third side:");
                    sideThree = double.Parse(Console.ReadLine());

                    triangleArea = SurfaceFromThreeSides(sideOne, sideTwo, sideThree);
                    Console.WriteLine("The area of the triangle is {0}", triangleArea);
                }
                else if (methodChoice == 3)
                {
                    double sideOne;
                    double sideTwo;
                    double angle;
                    double triangleArea;

                    Console.WriteLine("Enter the first side:");
                    sideOne = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second side:");
                    sideTwo = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the angle between the sides:");
                    angle = double.Parse(Console.ReadLine());

                    triangleArea = SurfaceFromTwoSidesAndAngle(sideOne, sideTwo, angle);
                    Console.WriteLine("The area of the triangle is {0}", triangleArea);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
