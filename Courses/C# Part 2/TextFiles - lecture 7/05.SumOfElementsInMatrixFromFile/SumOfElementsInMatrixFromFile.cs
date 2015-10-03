using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2
//with a maximal sum of its elements. The first line in the input file contains the size of matrix N. Each of the next N
//lines contain N numbers separated by space. The output should be a single number in a separate text file. Example:
//4
//2 3 3 4
//0 2 3 4			17
//3 7 1 2
//4 3 3 2


namespace TextFiles
{
    class SumOfElementsInMatrixFromFile
    {
        static void Main()
        {
            string filePath;
            string resultFilePath;
            string fileLine;
            int result;

            Console.WriteLine("Please enter the path to the file /test.txt/:");
            filePath = Console.ReadLine();

            Console.WriteLine("Please enter the path to the result file:");
            resultFilePath = Console.ReadLine();

            //set the encoding
            Encoding enc = System.Text.Encoding.GetEncoding(1251);

            try
            {
                //reading the data of the new file
                StreamReader fileContent = new StreamReader(filePath, enc);
                //list with the lines from the old file 
  
                using (fileContent)
                {
                    //taking the matrix size
                    fileLine = fileContent.ReadLine();
                    int matrixSize = int.Parse(fileLine);
                    int[,] matrix = new int[matrixSize, matrixSize];

                    //start parsing the matrix
                    fileLine = fileContent.ReadLine();
                    int currentLine = 0;
                    while (fileLine != null)
                    {
                        string[] integers = fileLine.Split(' ');
   
                        //filling the matrix
                        for (int i = 0; i < integers.Length; i++)
			            {
                            matrix[currentLine, i] = int.Parse(integers[i]);
			            }

                        fileLine = fileContent.ReadLine();
                        currentLine++;
                    }

                    result = int.MinValue;

                    //iterating over the matrix and calculating the sum for each possible sub-matrix
                    for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                        {
                            int tempSum = new int();
                            for (int platformRow = row; platformRow < row+2; platformRow++)
                            {
                                for (int platformCol = col; platformCol < col+2; platformCol++)
                                {
                                    tempSum+=matrix[platformRow,platformCol];
                                }
                            }
                            if (tempSum > result)
                            {
                                result = tempSum;
                            }
                        }
                    }
                }

                //print the data to the new file
                StreamWriter newFile = new StreamWriter(resultFilePath, false, enc);

                using (newFile)
                {
                        newFile.WriteLine(result);
                }
                Console.WriteLine("Completed!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured.Please try again.Error:{0}",ex);
            }
        }
    }
}
