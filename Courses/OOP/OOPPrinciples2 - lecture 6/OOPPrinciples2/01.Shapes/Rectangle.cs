namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Rectangle : Shape
    {

        public Rectangle(double heightInput, int widthInput)
            : base(heightInput, widthInput)
        {

        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
