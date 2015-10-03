using System;

/*
 * Write a program that, depending on the user's choice inputs int, double or string variable.
 * If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
 * The program must show the value of that variable as a console output. Use switch statement.
 */

class PrintVariableDependOnInput
{
    static void Main()
    {
        Console.WriteLine("Please enter the desired code for type of data /1 - integer, 2 - double, 3 - string/");
        string typeData = Console.ReadLine();
        if (String.IsNullOrEmpty(typeData))
        {
        Console.WriteLine("Please choose your data type.");
        Console.WriteLine("\nPress any key to restart");
        Console.ReadKey(true);
        Console.Clear();
        }
        Console.WriteLine("Please enter your data");
        string inputData = Console.ReadLine();
        switch (typeData)
        {
            case "1":
                int inputDataInt;
                //test the input if it is the right type
                if (int.TryParse(inputData, out inputDataInt))
                {
                    Console.WriteLine("Your data of type integer + 1 -> {0}",inputDataInt + 1);
                }
                else
                {
                    Console.WriteLine("Invalid data type.");
                }
                break;
            case "2":
                double inputDataDouble;
                //test the input if it is the right type
                if (double.TryParse(inputData, out inputDataDouble))
                {
                    Console.WriteLine("Your data of type double + 1 -> {0}", inputDataDouble + 1);
                }
                else
                {
                    Console.WriteLine("Invalid data type.");
                }
                break;
            case "3":
                Console.WriteLine("Your data of type string + * -> {0}", inputData + '*');
                break;
            default:
                Console.WriteLine("Please choose you data type.");
                break;
        }
        Console.WriteLine("\nPress any key to restart");
        Console.ReadKey(true);
        Console.Clear();
        Main();
    }
}
