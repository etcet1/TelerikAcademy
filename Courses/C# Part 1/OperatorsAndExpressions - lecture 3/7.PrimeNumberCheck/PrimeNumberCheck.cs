using System;

/*
 * Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
 */

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Please enter a number /smaller than or equal to 100/:");
        int testNumber = int.Parse(Console.ReadLine());
        //First solution
        bool isPrime = true;
        for (int i = 2; i < testNumber; i++)
        {
                if (testNumber % i == 0)
                {
                    isPrime = false;
                }
        }
        Console.WriteLine("First solution result:");
        if (isPrime == true)
        {
            Console.WriteLine("{0} is prime number.", testNumber);
        }
        else if (isPrime == false)
        {
            Console.WriteLine("{0} is not prime number.", testNumber);
        }

        //Second solution - modification of code found in Internet, which should work faster as the number of 
        //iterations is lower than the first one.
        bool isPrimeSecond = true;
        for (int j = 2; j <= (int)Math.Sqrt(testNumber); j++)
        {
            if (testNumber % j == 0)
            {
                isPrimeSecond = false;
            }
        }
        Console.WriteLine("Second solution result:");
        if (isPrimeSecond == true)
        {
            Console.WriteLine("{0} is prime number.", testNumber);
        }
        else if (isPrimeSecond == false)
        {
            Console.WriteLine("{0} is not prime number.", testNumber);
        }

    }
}
