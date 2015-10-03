using System;
using System.Threading;


class FallingRocksGame
{
    static int firstPlayerScore = 0;
    static int firstPlayerColumn = 0; // column
    static int firstPlayerRow = 0; // row

    static int[] rockXPosition = {1,24,34,12,56,67};
    static int rockYPosition = 0;
    static int cleanupPosition = 0;
    static int consoleRow = 1;

    static char[] rocks = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };

    static bool[,] isUsed;
    static char[] rockChar = new char[6];

    static void Main(string[] args)
    {
        SetGameField();
        firstPlayerColumn = (Console.WindowWidth/ 2) - 4;
        firstPlayerRow = Console.WindowHeight - 1;
        isUsed = new bool[Console.WindowWidth, Console.WindowHeight];

        while (true)
        {
            Random rnd = new Random();
            if (consoleRow == 1)
            {   
                for (int j = 0; j < 6; j++)
		    	{
			     rockXPosition[j] = rnd.Next(100);
                 rockChar[j] = rocks[rnd.Next(rocks.Length)];
			    }
                rockYPosition = consoleRow;
                cleanupPosition = 1;
            }
            else
            {
                rockYPosition = consoleRow;
                cleanupPosition = rockYPosition - 1;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < rockChar.Length; i++)
            {
               Console.SetCursorPosition(rockXPosition[i], rockYPosition);
               Console.WriteLine(rockChar[i]);
               // Thread.Sleep(50);
               ClearOldPosition(rockXPosition[i], cleanupPosition);
            }
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    ClearOldPosition(firstPlayerColumn, firstPlayerRow);
                    firstPlayerColumn--;
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    Console.Write(" ");
                    ClearOldPosition(firstPlayerColumn, firstPlayerRow);
                    firstPlayerColumn++;
                };
            }
            Console.SetCursorPosition(firstPlayerColumn, firstPlayerRow);
            Console.ResetColor();
            Console.Write("(0)");
            Thread.Sleep(150);
            if (consoleRow<29)
            {
                consoleRow++;
            }
            else
            {
                consoleRow = 1;
            }
        }
        Console.Clear();
    }

    static void SetGameField()
    {
        Console.WindowHeight = 30;
        Console.BufferHeight = 30;

        Console.WindowWidth = 100;
        Console.BufferWidth = 100;
    }
    static void ClearOldPosition(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write("   "); //three space as our dwarf has three chars
    }

}

