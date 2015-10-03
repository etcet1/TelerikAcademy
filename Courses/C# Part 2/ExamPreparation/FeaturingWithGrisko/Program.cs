using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApplication3
{
    class Permute
    {
        // List<string> foundWords = new List<string>();
        HashSet<string> foundWords = new HashSet<string>();

        private void swap(ref char a, ref char b)
        {
            if (a == b) return;
            a ^= b;
            b ^= a;
            a ^= b;
        }

        public void setper(char[] list)
        {
            int x = list.Length - 1;
            long res = go(list, 0, x);

            Console.WriteLine(res);
        }

        private long go(char[] list, int k, int m)
        {
            int i;

            long res = new long();

            if (k == m)
            {
                bool included = true;
                StringBuilder testString = new StringBuilder();

                for (int j = 0; j < list.Length - 1; j++)
                {
                    if (list[j] == list[j + 1])
                    {
                        included = false;
                    }
                    testString.Append(list[j + 1]);
                }


                if (included &&!foundWords.Contains(testString.ToString()))
                {
                    res = 1;
                    foundWords.Add(testString.ToString());
                }
            }
            else
            {
                for (i = k; i <= m; i++)
                {
                    swap(ref list[k], ref list[i]);

                    res += go(list, k + 1, m);

                    swap(ref list[k], ref list[i]);
                }
            }
            return res;
        }
    }

    class Class1
    {
        static void Main()
        {

            Permute p = new Permute();
            string c = Console.ReadLine();
            char[] c2 = c.ToCharArray();
            /*calling the permute*/
            p.setper(c2);
        }
    }
}