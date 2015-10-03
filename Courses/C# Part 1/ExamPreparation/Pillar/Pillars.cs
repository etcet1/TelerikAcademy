using System;

class Pillars
{
    static void Main()
    {
        int[,] matrix=new int[8,8];
        int[] input = new int[8];
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }
        string tmp = string.Empty;
        for (int row = 0; row < 8; row++)
        {
            tmp = Convert.ToString(input[row], 2).PadLeft(8, '0');
            for (int col = 0; col < 8; col++)
            {
                matrix[row, col] = int.Parse(tmp[col].ToString());
            }
        }
       int area1result = 0;
       int area2result = 0;
       int totalresult = -1;
       int totalcol = 0;
        for (int col = 7; col >= 0; col--)
        {
            for (int column = 7; column > col; column--)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row,column]==1)
                    {
                        area1result++;
                    }
                }
            }
            for (int column2 = col-1; column2 >=0; column2--)
            {
                for (int row2 = 0; row2 < 8; row2++)
                {
                    if (matrix[row2, column2] == 1)
                    {
                        area2result++;
                    }
                }
            }
            if (area1result==area2result)
            {
                totalresult=area1result;
                totalcol = 7-col;
                break;
            }
            else
            {
                area1result = 0;
                area2result = 0;
            }
        }
        if (totalresult>=0)
        {
            Console.WriteLine(totalcol);
            Console.WriteLine(totalresult);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

