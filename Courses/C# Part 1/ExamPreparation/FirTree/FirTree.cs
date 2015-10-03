using System;

class FirTree
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int width = ((height - 2)*2) + 1;
        int[,] matrix = new int[height, width];
        int dots=height-2;
        for (int i = 0; i < height-1; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if ((j>=dots)&&(j<width-dots))
                {
                    matrix[i,j]=1;
                }
            }
            dots--;
        }
        matrix[height-1, height-2] = 1;        
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (matrix[row,col]==0)
                {
                    Console.Write('.');
                }
                else if (matrix[row,col]==1)
                {
                    Console.Write('*');
                }
            }
            Console.WriteLine();
        }
    }
}
