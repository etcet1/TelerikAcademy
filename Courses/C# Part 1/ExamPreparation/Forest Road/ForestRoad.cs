using System;

namespace ForestRoad
{
    class ForestRoad
    {
        static void Main()
        {
            string path = Console.ReadLine();

            byte pathWidth = byte.Parse(path);
            byte position = 1;
            for (int i = 1; i <= (2*pathWidth)-1; i++)
            {
                    for (int j = 1; j <= pathWidth; j++)
			    {
			        if (j==position)
                    {
                        Console.Write("*");
                    }
                    else
	                {
                        Console.Write(".");
	                }
			    }
                    if (i < pathWidth)
                    {
                        position++;
                    }
                    else if (i >= pathWidth)
                    {
                        position--;
                    }
                    Console.WriteLine();
            }
        }
    }
}
