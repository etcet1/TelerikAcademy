using System;

/*
 * Write program that asks for a digit and depending on the input 
 * shows the name of that digit (in English) using a switch statement.
 */

class PrintDigitName
{
    static void Main()
    {   
        //using byte as we will use only the digits from 0 to 9
        byte digitChar;
        bool isFirstByte;
        Console.WriteLine("Please enter a digit");
        isFirstByte = byte.TryParse(Console.ReadLine(), out digitChar);
        Console.WriteLine(byte.MaxValue);
        //check for invalid input
        if (!isFirstByte || digitChar < 0 || digitChar > 9)
        {
            Console.WriteLine("Invalid input detected.{0} is a string or number but not a digit.", digitChar);
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Console.Clear();
            Main();
        }
        switch (digitChar)
        {
            case 0:
                Console.WriteLine("The name of the digit {0} is \"zero\".", digitChar);
                break;
            case 1:
                Console.WriteLine("The name of the digit {0} is \"one\".", digitChar);
                break;
            case 2:
                Console.WriteLine("The name of the digit {0} is \"two\".", digitChar);
                break;
            case 3:
                Console.WriteLine("The name of the digit {0} is \"three\".", digitChar);
                break;
            case 4:
                Console.WriteLine("The name of the digit {0} is \"four\".", digitChar);
                break;
            case 5:
                Console.WriteLine("The name of the digit {0} is \"five\".", digitChar);
                break;
            case 6:
                Console.WriteLine("The name of the digit {0} is \"six\".", digitChar);
                break;
            case 7:
                Console.WriteLine("The name of the digit {0} is \"seven\".", digitChar);
                break;
            case 8:
                Console.WriteLine("The name of the digit {0} is \"eight\".", digitChar);
                break;
            case 9:
                Console.WriteLine("The name of the digit {0} is \"nine\".", digitChar);
                break;
            default:
                Console.WriteLine("An error occured.Please try again", digitChar);
                break;
        }
        Console.WriteLine("Press any key to restart");
        Console.ReadKey(true);
        Console.Clear();
        Main();
    }
}
