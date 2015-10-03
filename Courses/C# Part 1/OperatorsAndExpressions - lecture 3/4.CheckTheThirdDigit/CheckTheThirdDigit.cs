using System;

/*
 * Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.
 */

class CheckTheThirdDigit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer:");
        int testInteger = int.Parse(Console.ReadLine());

        //Longer solution
        //First we need to find the remainder if the integer is divided by 1000 - e.g. 732 and after that 
        //divide by 100 in order to find the digit of the hudreds,e.g. the third digit
        int removeThousands = testInteger % 1000;
        int findHundreds = removeThousands / 100;
        bool isSeven = (findHundreds==7);
        Console.WriteLine("\nThe third digit of {0} is 7 - {1}",testInteger, isSeven);

        //Shorter solution
        bool isSevenVariant = (((testInteger%1000)/100)==7);
        Console.WriteLine("\nSecond solution: The third digit of {0} is 7 - {1}", testInteger, isSevenVariant);

        //Another approach solution - convert integer to string and test if the third character from right to left is "7"
        string isSevenAsStriing =  Convert.ToString(testInteger, 10);
        int stringLength = isSevenAsStriing.Length;
        char thirdDgigit = isSevenAsStriing[stringLength - 3];
        bool isSevenThirdVariant = (thirdDgigit == '7');
        Console.WriteLine(isSevenThirdVariant);
        Console.WriteLine("\nThird solution: The third digit of {0} is 7 - {1}", testInteger, isSevenThirdVariant);
    }
}
