namespace DefineClassesTwo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Path
    {
        private List<Point> pointsHolder;

        public Point[] GetPoints
        {
            get
            {
                return this.pointsHolder.ToArray();
            }
        }

        public Path() : this(new List<Point>())
        {

        }

        public Path(IEnumerable<Point> points)
        {
            this.pointsHolder = new List<Point>(points);
        }

        public void AddPoint(Point point)
        {
            this.pointsHolder.Add(point);
        }
    }
}
