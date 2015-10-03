using System;

class Sheets
{
    static void Main()
    {
        int sheetsA10 = int.Parse(Console.ReadLine());
        string[] sheetCodes = new string[11] {"A10","A9","A8","A7","A6","A5","A4","A3","A2","A1","A0"};

       // 2 ^ 11 - 2
        for (int i = 10; i >= 0; i--)
        {
            if (sheetsA10 >= Math.Pow(2, i))
            {
                sheetsA10 = sheetsA10 - (int)Math.Pow(2, i);
            }
            else
            {
                Console.WriteLine(sheetCodes[i]);
                continue;
            }
        }
    }
}
