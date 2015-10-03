using System;
using System.Collections.Generic;

//We are given a matrix of strings of size N x M. Sequences in the matrix we 
//define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 


class LongestSequenceOfStrings
{
    static void Printmatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.ForegroundColor=ConsoleColor.Yellow;
                Console.Write("{0}", matrix[row, col].PadLeft(8));
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
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
        string[,] matrix = new string[arrayRows, arrayCols];
        //filling the matrix with values from the console
        Console.WriteLine("Please enter the strings of the array:");
        for (int i = 0; i < arrayRows; i++)
        {
            for (int j = 0; j < arrayCols; j++)
            {
                 matrix[i, j] = Console.ReadLine();
            }
        }
        //matrix used for testing
        //string[,] matrix = 
        //{
        //    {"ha", "fifi", "ho", "hi"},
        //    {"fo", "ha", "hi", "xx"},
        //    {"xxx", "ho", "ha", "xx"}
        //};

        //string[,] matrix = 
        //{
        //    {"s", "qq", "s"},
        //    {"pp", "pp", "s"},
        //    {"pp", "qq", "s"}
        //};


        List<string> longestString = new List<string>();
        int longestStringCount = new int();
        List<string> tempLongestString = new List<string>();
        int tempStringCount = new int();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                tempLongestString.Clear();
                tempStringCount = new int();
                int stringRow = row;
                int stringCol = col;
                string testString = matrix[row, col];
                ////check on row
                while (stringRow < matrix.GetLength(0) && stringCol < matrix.GetLength(1))
                {
                    if (matrix[stringRow, stringCol] == testString)
                    {
                        tempStringCount++;
                        tempLongestString.Add(matrix[stringRow, stringCol]);
                    }
                    else
                    {
                        break;
                    }
                    stringCol++;
                }
                if (tempStringCount > longestStringCount)
                {
                    longestString.Clear();
                    longestString = new List<string>(tempLongestString);
                    longestStringCount = tempStringCount;
                }
                tempLongestString.Clear();
                tempStringCount = new int();
                stringRow = row;
                stringCol = col;
                //check on col
                while (stringRow < matrix.GetLength(0) && stringCol < matrix.GetLength(1))
                {
                    if (matrix[stringRow, stringCol] == testString)
                    {
                        tempStringCount++;
                        tempLongestString.Add(matrix[stringRow, stringCol]);
                    }
                    else
                    {
                        break;
                    }

                    stringRow++;
                }
                if (tempStringCount > longestStringCount)
                {
                    longestString.Clear();
                    longestString = new List<string>(tempLongestString);
                    longestStringCount = tempStringCount;
                }
                tempLongestString.Clear();
                tempStringCount = new int();
                stringRow = row;
                stringCol = col;
                //check on diagonal
                while (stringRow < matrix.GetLength(0) && stringCol < matrix.GetLength(1))
                {
                    if (matrix[stringRow, stringCol] == testString)
                    {
                        tempStringCount++;
                        tempLongestString.Add(matrix[stringRow, stringCol]);
                    }
                    else
                    {
                        break;
                    }
                    stringCol++;
                    stringRow++;
                }
                if (tempStringCount > longestStringCount)
                {
                    longestString.Clear();
                    longestString = new List<string>(tempLongestString);
                    longestStringCount = tempStringCount;
                }
            }
        }
        Console.WriteLine("The string matrix is:\n");
        Printmatrix(matrix);
        Console.WriteLine("\nThe longest sequence of equal strings is with {1} elements-> {0}", string.Join(",", longestString), longestStringCount);
    }
}
