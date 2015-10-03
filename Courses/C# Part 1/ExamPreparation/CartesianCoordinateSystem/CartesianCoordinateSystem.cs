using System;
using System.Numerics;

namespace CartesianCoordinateSystem
{
    class CartesianCoordinateSystem
    {
        static void Main()
        {
            double coordX = double.Parse(Console.ReadLine());
            double coordY = double.Parse(Console.ReadLine());
            int location = 0;
            if (coordX==0)
            {
                if (coordY==0)
                {
                    location=0;
                }
                else if (coordY>0||coordY<0)
                {
                    location=5;
                }
            }
            else if (coordX>0)
	        {
		        if (coordY>0)
	            {
                    location=1;
	            }
                else if (coordY==0)
                {
                    location = 6;
                }
                else
                {
                    location = 4;
                }
            }
            else if (coordX<0)
            {
                if (coordY<0)
                {
                    location = 3;
                }
                else if (coordY == 0)
                {
                    location = 6;
                }
                else if (coordY>0)
                {
                    location = 2;
                }
            }
            Console.WriteLine(location);
        }
    }
}
