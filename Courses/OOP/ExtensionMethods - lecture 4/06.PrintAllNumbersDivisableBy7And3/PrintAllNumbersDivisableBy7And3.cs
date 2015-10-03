namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class PrintAllNumbersDivisibleBy3And7
    {

        static void Main(string[] args)
        {

            int[] array = { 2, 5, 123, 73, 28, 42, 56, 89, 63, 210 };

            int[] filteredNumbers = Array.FindAll(array, num => num % 21 == 0);

            Console.WriteLine("Using lambda expression - the numbers divisible by 7 and 3 are:");
            foreach (int num in filteredNumbers)
            {
                Console.WriteLine(num);
            }

            var filteredLINQNumbers =
                from num in array
                where num % 21 == 0
                select num;

            Console.WriteLine("Using LINQ - the numbers divisible by 7 and 3 are:");
            foreach (int num in filteredLINQNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
