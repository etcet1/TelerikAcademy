using System;


class TelerikLogo
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        int Y = X;
        int Z = (X / 2) + 1;
        int width = (2 * X + 2 * Z) - 3;
        int height = width;
        int[,] matrix = new int[height, width];

        //solution
        int currentRow = X / 2;
        int currentCol = 0;

        while (true)
        {
            matrix[currentRow, currentCol] = 1;
            currentCol++;
            currentRow--;
            if (currentRow < 0)
            {
                currentRow++;
                currentCol--;
                break;
            }
        }
        while (true)
        {
            matrix[currentRow, currentCol] = 1;
            currentCol++;
            currentRow++;
            if (currentRow == 2 * X - 2)
            {
                break;
            }
        }
        while (true)
        {
            matrix[currentRow, currentCol] = 1;
            currentRow++;
            currentCol--;
            if (currentRow == height)
            {
                currentRow--;
                currentCol++;
                break;
            }
        }
        while (true)
        {
            matrix[currentRow, currentCol] = 1;
            currentRow--;
            currentCol--;
            if (currentCol == X / 2 - 1)
            {
                currentRow++;
                currentCol++;
                break;
            }
        }
        while (true)
        {
            matrix[currentRow, currentCol] = 1;
            currentCol++;
            currentRow--;
            if (currentRow < 0)
            {
                currentRow++;
                currentCol--;
                break;
            }
        }
        while (true)
        {
            matrix[currentRow, currentCol] = 1;
            currentCol++;
            currentRow++;
            if (currentCol == width)
            {
                break;
            }
        }
        //output
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write('.');
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write('*');
                }

            }
            Console.WriteLine();
        }
    }
}

