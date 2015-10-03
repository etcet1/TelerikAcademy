using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger subsetSum = BigInteger.Parse(Console.ReadLine());
        int numbersCount = int.Parse(Console.ReadLine());
        BigInteger[] numbers = new BigInteger[numbersCount];
        BigInteger subsets = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = BigInteger.Parse(Console.ReadLine());
        }
        int totalnumbers = (int)Math.Pow(2, numbersCount);
        for (int currentMember = 0; currentMember < totalnumbers; currentMember++)
        {
            BigInteger tempSum = 0;
            for (int subsetMember = currentMember; subsetMember < numbersCount; subsetMember++)
            {
                tempSum = tempSum + numbers[subsetMember];

                if (tempSum==subsetSum)
                {
                        subsets++;
                }
            }
        }
        Console.WriteLine(subsets);
    }
}
   /* static void Main()
    {
        int i, j, n;
        long[] numbers;
        long sum, mask, temp = 0;
        long counter = 0;
        bool success = false;
        try
        {
            sum = long.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            numbers = new long[n];
            for (i = 0; i < n; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }
            n = (int)Math.Pow(2, n);
            for (i = 1; i < n; i++)
            {
                temp = 0;
                success = false;
                for (j = 0; j < numbers.Length; j++)
                {
                    mask = (long)(1 << j);
                    mask = (i & mask) >> j;
                    if (mask == 1)
                    {
                        temp = temp + numbers[j];
                        success = true;
                    }
                }
                if (temp == sum && success) 
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        catch (Exception ex)
        {
            Console.WriteLine("\n" + ex.Message);
            Console.Write("Another try? (y/n)\t");
            if (Console.ReadLine() == "y")
            {
                Main();
            }
        }
    }
}*/