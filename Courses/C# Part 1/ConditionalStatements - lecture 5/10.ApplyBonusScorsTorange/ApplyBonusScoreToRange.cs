using System;

/*Write a program that applies bonus scores to given scores in the range [1..9]. 
 * The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10;
 * if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000.
 * If it is zero or if the value is not a digit, the program must report an error.
 * Use a switch statement and at the end print the calculated new value in the console.
 */

class ApplyBonusScorsTorange
{
    static void Main()
    {
        double score; // as the value could be a floating point number between 1 and 9
        int scoreBonus = new int();
        Console.WriteLine("Please enter the score");
        string typeData = Console.ReadLine();
        if (String.IsNullOrEmpty(typeData))
        {
            Console.WriteLine("Please enter the score.");
        }
        else if (typeData=="0") 
        {
            Console.WriteLine("The score cannot be 0.");
        }
        else if (double.TryParse(typeData, out score))
        {
            if (score >= 1 && score <3.5) //this way we catch also the values up to 3.5 (rounded to 3)
	        {
		       scoreBonus = 10;
	        }
            else if (score >= 3.5 && score < 6.5) //this way we catch the values between 3.5 and up to 6.5 (rounded to 4 and up to 6)
	        {
		        scoreBonus = 100;
	        }
            else if (score >= 6.5 && score <= 9) //this way we catch the values between 6.5 and 9 (rounded to 7 and up to 9)
	        {
		        scoreBonus = 1000;
	        }
            switch (scoreBonus)
            {
                case 10:
                    Console.WriteLine("Total score: {0}",score * scoreBonus);
                    break;
                case 100:
                    Console.WriteLine("Total score: {0}",score * scoreBonus);
                    break;
                case 1000:
                    Console.WriteLine("Total score: {0}",score * scoreBonus);
                    break;
                default:
                    Console.WriteLine("An error occured.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("String detected.Please enter the score using a digit.");
        }
        Console.WriteLine("\nPress any key to restart");
        Console.ReadKey(true);
        Console.Clear();
        Main();
    }
}
