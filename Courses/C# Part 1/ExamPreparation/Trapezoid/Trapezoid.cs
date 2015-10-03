using System;

class Trapezoid
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int bottomwidth = 2 * width;
        int height = width + 1;
        int[,] matrix = new int[height, bottomwidth];
        for (int i = bottomwidth-1; i >= width; i--)
        {
            matrix[0, i] = 1;
        }
        int temp=width-1;
        for (int i = 1; i < height-1; i++)
        {
            matrix[i, temp] = 1;
            matrix[i, bottomwidth - 1] = 1;
            temp--;
        }

        for (int i = bottomwidth - 1; i >= 0; i--)
        {
            matrix[height-1, i] = 1;
        }
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < bottomwidth; col++)
            {
                if (matrix[row,col]==0)
                {
                    Console.Write('.');
                }
                if (matrix[row, col] == 1)
                {
                    Console.Write('*');
                }
            }
            Console.WriteLine();
        }

    }
}
