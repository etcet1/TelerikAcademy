using System;

//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

class PrimeNumbersEratosthenesAlgorithm
{
    static void Main()
    {
        //Algorithm definition:
        //Let A be an array of Boolean values, indexed by integers 2 to n,
        //initially all set to true.
        // for i = 2, 3, 4, ..., not exceeding √n:
        //  if A[i] is true:
        //    for j = i2, i2+i, i2+2i, ..., not exceeding n :
        //      A[j] := false
        long numberN = 10000000;
        bool[] check = new bool[numberN];
        for (long i = 2; i < numberN; i++)
        {
            check[i] = true;
        }
        for (long j = 2; j < Math.Sqrt(numberN); j++)
        {
            if (check[j] == true)
            {
                for (long p = j * j; p < numberN; p = p + j)
                {
                    check[p] = false;
                }
            }
        }
        for (long k = 2; k < numberN; k++)
        {
            if (check[k] == true)
            {
                Console.Write("{0} ", k);
            }
        }

    }
}
