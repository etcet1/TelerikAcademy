using System;

/* Write a program that reads a positive integer number N (N < 20)
 * from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.
 */

namespace OutputRange1toNAsSpiral
{
    class OutputRange1toNAsSpiral
    {
        static void Main()
        {
            int numberN;
            Console.WriteLine("Please enter a number");
            string inputOne = Console.ReadLine();
            if (!int.TryParse(inputOne, out numberN))
            {
                Console.WriteLine("Please enter valid number");
            }
            else if (numberN >= 20 && numberN <= 0)
	        {
                Console.WriteLine("Please enter valid number between 0 and 20");
            }
            else
            {
                int[,] matrix = new int[numberN,numberN];
                int matrixVal=1;
                int totalMatrixValues = numberN * numberN; //our matrix is square so rows * columns = n * n
                int matrixRow = 0;
                int matrixColumn = 0;
                int matrixMaxRow = numberN - 1;
                int matrixMaxColumn = numberN - 1;
                //setting matrix as after each iteration over row or column reducing the size of the matrix 
                while (matrixVal <= totalMatrixValues)
                {
                    for (int i = matrixColumn; i <= matrixMaxColumn; i++)
                    {
                        matrix[matrixRow, i] = matrixVal;      
                        matrixVal++;
                    }
                    matrixRow++;
                    for (int j = matrixRow; j <= matrixMaxRow; j++)
                    {
                        matrix[j, matrixMaxColumn] = matrixVal;
                        matrixVal++;
                    }
                    matrixMaxColumn--;
                    for (int k = matrixMaxColumn; k >= matrixColumn; k--)
                    {
                        matrix[matrixMaxRow, k] = matrixVal;
                        matrixVal++;
                    }
                    matrixMaxRow--;
                    for (int l = matrixMaxRow; l >= matrixRow; l--)
                    {
                        matrix[l, matrixColumn] = matrixVal;
                        matrixVal++;
                    }
                    matrixColumn++;
                }
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    string printValue;
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if ((int)matrix[row, col] < 10)
                        {
                            printValue = " " + Convert.ToString(matrix[row, col]);
                        }
                        else
                        {
                            printValue = Convert.ToString(matrix[row, col]);
                        }
                        Console.Write(printValue);

                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Console.Clear();
            Main();            
        }
    }
}
