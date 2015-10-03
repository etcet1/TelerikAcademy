namespace DefineClassesTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SamplePoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The center point is at:" + Point.PointCenter);
            double distance = CalculateDistance.CalculateDistanceBetweenPoints(Point.PointCenter, new Point(1, 3, 5.23));

            Console.WriteLine("The distance between the center and the point is: {0}", distance);
            Path path = new Path();

            PathToFile.LoadPath();

            PathToFile.PrintPaths();

            PathToFile.SavePath();
        }

    }
}
