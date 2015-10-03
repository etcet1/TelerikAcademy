using System;

//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

class PrintMatrix
{
    static void Printmatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0}", matrix[row, col].ToString().PadLeft(3));
            }
            Console.WriteLine();
        }
    }
    static void PrintMatrixFirstOption(int matrixDimension)
    {
        int[,] matrix = new int[matrixDimension, matrixDimension];
        int i = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = i;
                i++;
            }
        }
        Printmatrix(matrix);
    }
    static void PrintMatrixSecondOption(int matrixDimension)
    {
        int[,] matrix = new int[matrixDimension, matrixDimension];
        int i = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = i;
                    i++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = i;
                    i++;
                }
            }
        }
        Printmatrix(matrix);
    }
    static void PrintMatrixThirdOption(int matrixDimension)
    {
        int[,] matrix = new int[matrixDimension, matrixDimension];
        int i = 1;
        int row = new int();
        int col = new int();
        for (int j = matrixDimension - 1;j >= 0; j--)
        {
            row = j;
            col = 0;
            while (row < matrixDimension && col < matrixDimension)
            {
                matrix[row, col] = i;
                i++;
                row++;
                col++;
            }
        }
        for (int k = 1; k <= matrixDimension; k++)
        {
            row = 0;
            col = k;
            while (row < matrixDimension && col < matrixDimension)
            {
                matrix[row, col] = i;
                i++;
                row++;
                col++;
            }
        }

        Printmatrix(matrix);
    }
    static void PrintMatrixFourthOption(int matrixDimension)
    {
        //based on algorithm found in internet
        int[,] matrix = new int[matrixDimension, matrixDimension];
        int i = 1;
        for (int dimension = 0; dimension < matrixDimension / 2 + matrixDimension % 2; dimension++)
        {
            for (int row = dimension; row < matrixDimension - dimension; row++)
            {
                matrix[row, dimension] = i;
                i++;
            }
            for (int col = 1 + dimension; col < matrixDimension - dimension; col++)
            {
                matrix[matrixDimension - 1 - dimension, col] = i;
                i++;
            }
            for (int row = matrixDimension - 2 - dimension; row >= dimension; row--)
            {
                matrix[row, matrixDimension - 1 - dimension] = i;
                i++;
            }
            for (int col = matrixDimension - 2 - dimension; col > dimension; col--)
            {
                matrix[dimension, col] = i;
                i++;
            }
        }
        Printmatrix(matrix);
    }
    static void Main()
    {
        int arrayDimension = new int();
        Console.WriteLine("Please enter a number:");
        if (!int.TryParse(Console.ReadLine(), out arrayDimension))
        {
            Console.WriteLine("Invalid number!");
        }
        else
        {
            Console.WriteLine("Option A");
            PrintMatrixFirstOption(arrayDimension);
            Console.WriteLine();
            Console.WriteLine("Option B");
            PrintMatrixSecondOption(arrayDimension);
            Console.WriteLine();
            Console.WriteLine("Option C");
            PrintMatrixThirdOption(arrayDimension);
            Console.WriteLine();
            Console.WriteLine("Option D");
            PrintMatrixFourthOption(arrayDimension);
            Console.WriteLine("Press any key to restart...");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
