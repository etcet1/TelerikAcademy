﻿namespace DefineClassesTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    struct Point
    {
        private static readonly Point pointCenter = new Point(0, 0, 0);

        private double x;
        private double y;
        private double z;

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point PointCenter
        {
            get
            {
                return pointCenter;
            }
        }

        public override string ToString()
        {
            string pointDetails = string.Format("Point has coordinates x: {0}, y: {1}, z: {2})", this.x, this.y, this.z);
            return pointDetails;
        }
    }
}
