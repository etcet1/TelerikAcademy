using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray64
{
    class BitArray64Test
    {
        public static void Main()
        {
            BitArray64 number = new BitArray64(7);
            // second BitArray
            BitArray64 number2 = new BitArray64(7);

            // print bits of the ulong number
            foreach (var bit in number)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            // print the original number
            Console.WriteLine(number.Number);

            //are the numbers equal
            Console.WriteLine(number.Equals(number2));

            // hash code
            Console.WriteLine(number.GetHashCode());

            // change bit
            number[5] = 1;

            // print the changed number
            foreach (var bit in number)
            {
                Console.Write(bit);
            }

            Console.WriteLine();
            Console.WriteLine(number.Number);
        }
    }
}
