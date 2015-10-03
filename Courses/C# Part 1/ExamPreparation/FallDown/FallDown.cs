using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallDownSecondSolution
{
    class FallDownSecondSolution
    {
        static void Main()
        {
            //input of bytes
            int[] nums = new int[8];
            for (int i = 0; i < 8; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            //solution
            for (int i = 0; i < 7; i++)
            {
                for (int line = 7; line > 0; line--)
                {
                    for (int bitPosition = 7; bitPosition > 0; bitPosition--)
                    {
                        if ((nums[line] >> bitPosition & 1) == 0 && (nums[line - 1] >> bitPosition & 1) == 1)
                        {
                            nums[line] |= (1 << bitPosition);
                            nums[line - 1] ^= (1 << bitPosition);
                        }
                    }
                }
                //output
                for (int j = 0; j < 8; j++)
                {
                    Console.WriteLine(Convert.ToString(nums[j], 2).PadLeft(8, '0'));
                }
                Console.WriteLine();
            }
        }
    }
}
