using System;
using System.Collections.Generic;

// Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size. 

class LargestAreaOfEqualNumbers
{
    public class Point
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }
        public Point(int x, int y)
        {
            xCoordinate = x;
            yCoordinate = y;
        }
    }
    public static int[,] matrix =
    {
        {1, 3, 2, 2, 2, 4},
        {2, 3, 3, 2, 4, 4},
        {4, 3, 1, 2, 3, 3},
        {4, 3, 1, 3, 3, 1},
        {4, 3, 3, 3, 1, 1},
    };
    static bool[,] visitedMatrix = new bool[matrix.GetLength(0), matrix.GetLength(1)];

    public static int BFS(int node, Point nodePoint, int[,] matrix)
        {
        Queue<Point> myQueue = new Queue<Point>();
        int nodeSize=new int();
        myQueue.Enqueue(nodePoint);
        while (myQueue.Count != 0)
            {
                Point currentPoint = myQueue.Dequeue();
                nodeSize++;
                if (currentPoint.xCoordinate < 0 || currentPoint.xCoordinate >= matrix.GetLength(0))
                {
                    break;
                }
                if (currentPoint.yCoordinate < 0 || currentPoint.yCoordinate >= matrix.GetLength(1))
                {
                    break;
                }
                if (currentPoint.yCoordinate - 1 >= 0)
                {
                    if (matrix[currentPoint.xCoordinate, currentPoint.yCoordinate - 1] == node && visitedMatrix[currentPoint.xCoordinate, currentPoint.yCoordinate - 1] == false)
                    {
                        visitedMatrix[currentPoint.xCoordinate, currentPoint.yCoordinate - 1] = true;
                        myQueue.Enqueue(new Point(currentPoint.xCoordinate, currentPoint.yCoordinate - 1));
                    }
                }
                if (currentPoint.yCoordinate + 1 < matrix.GetLength(1))
                {
                    if (matrix[currentPoint.xCoordinate, currentPoint.yCoordinate + 1] == node && visitedMatrix[currentPoint.xCoordinate, currentPoint.yCoordinate + 1] == false)
                    {
                        visitedMatrix[currentPoint.xCoordinate, currentPoint.yCoordinate+1] = true;
                        myQueue.Enqueue(new Point(currentPoint.xCoordinate, currentPoint.yCoordinate+1));
                    }
                }
                if (currentPoint.xCoordinate - 1 >= 0)
                {
                    if (matrix[currentPoint.xCoordinate - 1, currentPoint.yCoordinate] == node && visitedMatrix[currentPoint.xCoordinate - 1, currentPoint.yCoordinate] == false)
                    {
                        visitedMatrix[currentPoint.xCoordinate - 1, currentPoint.yCoordinate] = true;
                        myQueue.Enqueue(new Point(currentPoint.xCoordinate - 1, currentPoint.yCoordinate));
                    }
                }
                if (currentPoint.xCoordinate + 1 < matrix.GetLength(0))  
                {
                    if (matrix[currentPoint.xCoordinate + 1, currentPoint.yCoordinate] == node && visitedMatrix[currentPoint.xCoordinate + 1, currentPoint.yCoordinate] == false)
                    {
                        visitedMatrix[currentPoint.xCoordinate+1, currentPoint.yCoordinate] = true;
                        myQueue.Enqueue(new Point(currentPoint.xCoordinate+1, currentPoint.yCoordinate));
                    }
                }
            }
        return nodeSize;
        }
    public static void Main()
    {
        int maxNumberCount = new int();
        int numberMax = new int();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Point startPoint = new Point(i,j);
                    int maxCount = BFS(matrix[i, j], startPoint, matrix);
                    if (maxCount > maxNumberCount)
                    {
                        numberMax = matrix[i, j];
                        maxNumberCount = maxCount;
                    }
            }
        }
        Console.WriteLine("The result is:");
        Console.WriteLine(maxNumberCount);
        Console.WriteLine("The number is:");
        Console.WriteLine(numberMax);
    }
}

http://pastebin.com/mMemYWY6