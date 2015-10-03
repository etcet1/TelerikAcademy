namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Circle : Shape
    {

        public Circle(double heightInput, double widthInput)
            : base(heightInput, widthInput)
        {
            if (heightInput != widthInput)
            {
                 throw new ArgumentOutOfRangeException("Height and width should be equal.");
            }
        }

        public override double CalculateSurface()
        {
            return Math.PI * this.Width * 2;
        }
    }
}
