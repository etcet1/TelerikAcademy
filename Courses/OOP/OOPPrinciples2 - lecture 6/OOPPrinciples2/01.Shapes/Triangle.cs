namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Triangle : Shape
    {

       public Triangle(double heightInput, double widthInput)
            : base(heightInput, widthInput)
        {

        }

       public override double CalculateSurface()
       {
            return (this.Width * this.Height) / 2;
       }
    }
}
