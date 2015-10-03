namespace DefineClassesTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    static class CalculateDistance
    {

        public static double CalculateDistanceBetweenPoints(Point firstPoint, Point secondPoint)
        {
            double distanceX = firstPoint.X - secondPoint.X;
            double distanceY = firstPoint.Y - secondPoint.Y;
            double distanceZ = firstPoint.Z - secondPoint.Z;

            double distance = Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2) + Math.Pow(distanceZ, 2));

            return distance;
        }
    }
}
