using System;

class UKFlag
{
    static void Main(string[] args)
    {
        int flagHeight = int.Parse(Console.ReadLine());

        int inDots = (flagHeight / 2) - 1;
        int outDots = 0;
        for (int i = 0; i < flagHeight / 2; i++)
        {
            Console.Write(new string('.',outDots));
            Console.Write(new string('\\',1));
            Console.Write(new string('.',inDots));
            Console.Write(new string('|', 1));
            Console.Write(new string('.', inDots));
            Console.Write(new string('/', 1));
            Console.Write(new string('.', outDots));
            Console.WriteLine();
            inDots--;
            outDots++;
        }
        Console.Write(new string('-', flagHeight /2));
        Console.Write(new string('*', 1));
        Console.Write(new string('-', flagHeight / 2));
        Console.WriteLine();
        int inDotsDown = 0;
        int outDotsDown = (flagHeight / 2) - 1;
        for (int i = 0; i < flagHeight / 2; i++)
        {
            Console.Write(new string('.', outDotsDown));
            Console.Write(new string('/', 1));
            Console.Write(new string('.', inDotsDown));
            Console.Write(new string('|', 1));
            Console.Write(new string('.', inDotsDown));
            Console.Write(new string('\\', 1));
            Console.Write(new string('.', outDotsDown));
            Console.WriteLine();
            inDotsDown++;
            outDotsDown--;
        }
    }
}
