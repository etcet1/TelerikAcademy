namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ShapesTest
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>{ 
                             new Rectangle(3, 4),
                             new Circle(4.3,4.3),
                             new Triangle(4, 5),
                             new Rectangle(2.3, 5),
                             new Circle(3,3),
                             new Triangle(5.7, 2.3)
                             };

            foreach (var shape in shapes)
            {
                Console.WriteLine("A {0,9} with dimensions: ({1} x {2}) and surface: {3:0.000}",
                    shape.GetType().Name, shape.Width, shape.Height, shape.CalculateSurface());
            }
        }
    }
}
