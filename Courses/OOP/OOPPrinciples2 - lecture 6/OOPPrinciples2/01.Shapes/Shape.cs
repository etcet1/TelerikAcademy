namespace Shapes
{
    using System;
    using System.Collections.Generic;

    public abstract class Shape
    {
        public double width;
        public double height;

        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width should be bigger than zero.");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height should be bigger than zero.");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public Shape(double heightInput, double widthInput)
        {
            this.Height = heightInput;
            this.Width = widthInput;
        }

        public abstract double CalculateSurface();

    }
}
