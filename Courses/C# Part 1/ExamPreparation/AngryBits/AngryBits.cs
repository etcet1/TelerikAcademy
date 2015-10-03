using System;

class AngryBits
{
    static void Main()
    {
        char[,] matrix=new char[8,16];
        ushort[] numbers=new ushort[8];
        int result=0;
        int pigs = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i]=ushort.Parse(Console.ReadLine());
        }
        string zeroandones = "";
        for (int i = 0; i < numbers.Length; i++)
        {
            zeroandones = Convert.ToString(numbers[i],2).PadLeft(16,'0');
            for (int j = 0; j < 16; j++)
            {
                matrix[i,j]=zeroandones[j];
            }
        }
        for (int col = 0; col < 8; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                if (matrix[row,col]=='1')
                {
                    bool up = true;
                    while (true)
                    {
                        if (row>0&&up)
	                    {
		                    row--;
                            col++;
                            result++;

	                    }else
	                    {
                            row++;
                            col++;
                            result++;
                            up = false;
	                    }
                        //Console.WriteLine("row "+row);
                        //Console.WriteLine("col " + col);
                        if(matrix[row,col]=='1')
                        {
                            //pig found
                            pigs++;
                            //surrounding pigs
                            /*if (matrix[row - 1, col - 1] == '1' || matrix[row - 1, col] == '1' || matrix[row - 1, col + 1] == '1')
                            {
                                pigs++;
                            }
                            if (matrix[row, col - 1] == '1' || matrix[row, col+1] == '1')
                            {
                                pigs++;
                            }
                            if (matrix[row + 1, col - 1] == '1' || matrix[row + 1, col] == '1' || matrix[row + 1, col + 1] == '1')
                            {
                                pigs++;
                            }*/
                            result = result * pigs;
                            break;
                        }
                        else if (col==15||row==7)
                        {
                            break;
                        }
                    }
                    
                }
            }
            //result = result * pigs;
        }

        Console.WriteLine(result);

        //printing
        /*for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 16; col++)
            {
                Console.Write(matrix[row,col]);
            }
            Console.WriteLine();
        }*/
    }
}
