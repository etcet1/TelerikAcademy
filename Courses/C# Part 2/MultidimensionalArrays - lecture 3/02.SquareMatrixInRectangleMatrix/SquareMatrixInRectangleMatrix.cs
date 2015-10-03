using System;

//Write a program that reads a rectangular matrix of size N x M and finds in it the
//square 3 x 3 that has maximal sum of its elements.

class SquareMatrixInRectangleMatrix
{
    static void Main()
    {
        int arrayRows = new int();
        int arrayCols = new int();
        int temp = new int();
        Console.WriteLine("Please enter the number of the rows:");
        if (!int.TryParse(Console.ReadLine(), out temp))
        {
            Console.WriteLine("Invalid number!");
            Console.WriteLine("Press any key to restart...");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        else
        {
            arrayRows = temp;
        }
        Console.WriteLine("Please enter the number of the columns:");
        if (!int.TryParse(Console.ReadLine(), out temp))
        {
            Console.WriteLine("Invalid number!");
            Console.WriteLine("Press any key to restart...");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        else
        {
            arrayCols = temp;
        }
        if (arrayCols<3||arrayRows<3)
        {
            Console.WriteLine("Each matrix dimension must be longer than 3!");
            Console.WriteLine("Press any key to restart...");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        int[,] matrix = new int[arrayRows, arrayCols];
        //filling the matrix with values from the console
        for (int i = 0; i < arrayRows; i++)
        {
            for (int j = 0; j < arrayCols; j++)
            {
                if (!int.TryParse(Console.ReadLine(), out temp))
                {
                    Console.WriteLine("Invalid number!");
                    Console.WriteLine("Press any key to restart...");
                    Console.ReadKey();
                    Console.Clear();
                    Main();
                }
                else
                {
                    matrix[i, j] = temp;
                }
            }
        }
        // matrix used for testing
        //int[,] matrix = 
        //{
        //    {0, 2, 4, 0, 9, 5},
        //    {7, 1, 3, 3, 2, 1},
        //    {1, 3, 9, 8, 5, 6},
        //    {4, 6, 7, 9, 1, 0},
        //};

        // Find the maximal sum of matrix with size 3 x 3
        int sum = int.MinValue;
        int sumRow = 0;
        int sumCol = 0;
        //iterating over the matrix and calculating the sum for each possible sub-matrix
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int tempSum = new int();
                for (int platformRow = row; platformRow < row+3; platformRow++)
                {
                    for (int platformCol = col; platformCol < col+3; platformCol++)
                    {
                        tempSum+=matrix[platformRow,platformCol];
                    }
                }
                if (tempSum > sum)
                {
                    sum = tempSum;
                    sumRow = row;
                    sumCol = col;
                }
            }
        }
        //Print the result matrix and the sum
        Console.WriteLine("The maximal sum of sub-matrix is {0}\n",sum);
        Console.WriteLine("The sub-matrix with the sum {0} is as follows:",sum);
        for (int resultRow = sumRow; resultRow < sumRow+3; resultRow++)
        {
            for (int resultCol = sumCol; resultCol < sumCol+3; resultCol++)
            {
                Console.Write(" "+matrix[resultRow,resultCol]);
            }
            Console.WriteLine();
        }
    }
}
