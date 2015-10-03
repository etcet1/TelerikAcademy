namespace DefineClassesTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    static class PathToFile
    {
        private const string INPUT_FILE = @"inputPoints.txt";
        private const string OUTPUT_FILE = @"outputPoints.txt";

        public static List<Path> paths = new List<Path>();

        public static void LoadPath()
        {
            using (TextReader read = new StreamReader(INPUT_FILE))
            {
                string line = null;
                int pointCount = 0;
                while ((line = read.ReadLine()) != null)
                {
                    string[] point = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    paths.Add(new Path());
                    for (int i = 0; i < point.Length; i++)
                    {
                        string[] pointCoordinates = point[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        paths[pointCount].AddPoint(new Point(double.Parse(pointCoordinates[0]),
                            double.Parse(pointCoordinates[1]), double.Parse(pointCoordinates[2])));
                    }
                    pointCount++;
                }
            }
        }

        public static void SavePath()
        {
            using (TextWriter write = new StreamWriter(OUTPUT_FILE))
            {
                foreach (Path path in paths)
                {
                    for (int i = 0; i < path.GetPoints.Length - 1; i++)
                    {
                        Point point = path.GetPoints[i];
                        write.Write(point.X + "," + point.Y + "," + point.Z + ";");
                    }
                    Point lastPoint = path.GetPoints[path.GetPoints.Length - 1];
                    write.Write(lastPoint.X + "," + lastPoint.Y + "," + lastPoint.Z + Environment.NewLine);
                }
            }
            paths.Clear();
        }

        public static void PrintPaths()
        {
            if (paths.Count == 0)
            {
                Console.WriteLine("An empty list of paths.");
            }
            else
            {
                for (int i = 0; i < paths.Count; i++)
                {
                    Console.WriteLine("Points of path #{0}: ", (i + 1));
                    for (int j = 0; j < paths[i].GetPoints.Length; j++)
                    {
                        Console.WriteLine("Coordinates of point #{0}: {1}", (j + 1), paths[i].GetPoints[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
