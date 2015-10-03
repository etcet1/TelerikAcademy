using System;

class FormulaBit1
{
    static void Main()
    {
        int[,] track = new int[8, 8];
        int[] numbers = new int[8];
        int length = 0;
        int turns = 0;
        int trackrow = 0;
        int trackcol = 7;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = ushort.Parse(Console.ReadLine());
        }
        string binaryNum = "";
        for (int i = 0; i < numbers.Length; i++)
        {
            binaryNum = Convert.ToString(numbers[i], 2).PadLeft(8, '0');
            for (int j = 0; j < 8; j++)
            {
                track[i, j] = int.Parse(binaryNum[j].ToString());
            }
        }
        bool istrack=true;
        if (track[0,7]==1)
	    {
		 istrack=false;
	    }
        while (trackrow>=0&&trackrow<8&&trackcol>=0&&trackcol<8)
        {
            if (trackrow==0&&trackcol==7)
            {
                trackrow++;
                length++;
            }
            while (track[trackrow, trackcol] == 0 && (trackrow > 0 && trackrow < 8 && trackcol > 0 && trackcol < 8))
            {
                trackrow++;
                length++;
            }

            if (track[trackrow, trackcol] == 1 && (trackrow > 0 && trackrow < 8 && trackcol > 0 && trackcol < 8))
            {
                trackcol--;
                turns++;
            }
            
            while (track[trackrow, trackcol] == 0 && (trackrow > 0 && trackrow < 8 && trackcol > 0 && trackcol < 8))
            {
                trackcol--;
                length++;
            }
            if (track[trackrow, trackcol] == 1 && (trackrow > 0 && trackrow < 8 && trackcol > 0 && trackcol < 8))
            {
                trackrow--;
                turns++;
            }
            while (track[trackrow, trackcol] == 0 && (trackrow > 0 && trackrow < 8 && trackcol > 0 && trackcol < 8))
            {
                trackrow--;
                length++;
            }
            if (track[trackrow, trackcol] == 1 && (trackrow > 0 && trackrow < 8 && trackcol > 0 && trackcol < 8))
            {
                trackcol--;
                turns++;
            }
            while (track[trackrow, trackcol] == 0 && (trackrow > 0 && trackrow < 8 && trackcol > 0 && trackcol < 8))
            {
                trackcol--;
                length++;
            }
            if (track[trackrow, trackcol] == 1 && (trackrow > 0 && trackrow < 8 && trackcol > 0 && trackcol < 8))
            {
                turns++;
                continue;
            }
            if (trackcol)
            {
                
            }
        }
        if (istrack)
	    {
	     Console.WriteLine(length);
         Console.WriteLine(turns);
	    }else
	    {
        Console.WriteLine("No");
        Console.WriteLine(length);
	    }
 
        //output
        /*for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                Console.Write(track[row, col]);
            }
            Console.WriteLine();
        }*/
    }
}
