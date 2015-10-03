using System;

class WeAllLoveBits
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        int[] numbers = new int[numbersCount];
        int numberNew = 0;
        for (int k = 0; k < numbersCount; k++)
        {
            numbers[k] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numbersCount; i++)
        {
            int numberTemp1 = ~numbers[i];
            string tmp =string.Empty;
            tmp=Convert.ToString(numbers[i],2);
            string tmp2 = string.Empty;
            int numberTemp2=0;
            for (int j = tmp.Length-1; j >= 0; j--)
			{
             tmp2+=tmp[j];  
			}
            numberTemp2 = Convert.ToInt32(tmp2, 2);

            numberNew = (numbers[i] ^ numberTemp1) & numberTemp2;

            Console.WriteLine(numberTemp2);
        }
    }
}
