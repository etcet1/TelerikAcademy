using System;

class BinaryDigits
{
    static void Main()
    {
        string digit = Console.ReadLine();
        int numbersCount = int.Parse(Console.ReadLine());
        uint[] numbers = new uint[numbersCount];
        int[] result = new int[numbersCount];
        int index;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = uint.Parse(Console.ReadLine());
            string temp=Convert.ToString(numbers[i], 2);
            index = i;
            for (int bukva = 0; bukva < temp.Length; bukva++)
            {
                string kkkk = Convert.ToString(temp[bukva]);
                if (kkkk==digit)
                {
                    result[index]++;
                }
            }
        }

        for (int j = 0; j < result.Length; j++)
        {
            Console.WriteLine(result[j]);
        }
    }
}
