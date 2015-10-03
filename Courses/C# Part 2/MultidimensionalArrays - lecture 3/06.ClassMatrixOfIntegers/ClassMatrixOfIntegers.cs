using System;

//Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, 
//subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

public class MatrixOfIntegers
{
    public int[] Matrix(int matrixDimension)
    {
        int[,] matrix = new int[matrixDimension,matrixDimension];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row,col]=new Random
            }
        }
        return matrix;
    }
}
class MainProgram
{
        public static void Main(string[] args)
    {
        var instance = new MatrixOfIntegers();
        var test = instance.Matrix(4);
        Console.WriteLine(string.Join(",",test));
    }

}