using System;



class MissCat2011
{
    static void Main(string[] args)
    {
        int judgesCount = int.Parse(Console.ReadLine());
        int[] cats = new int[11];
        for (int i = 0; i < judgesCount; i++)
        {
            int score=int.Parse(Console.ReadLine());
            cats[score]++;
        }
        int maxScore = 0;
        int winner = 0;
        for (int i = 0; i < cats.Length; i++)
        {
            if (cats[i]>maxScore)
            {
                maxScore = cats[i];
                winner = i;
            }
        }
        Console.WriteLine(winner);
    }
}
