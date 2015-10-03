using System;

//Write a method that asks the user for his name and prints
//“Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

namespace Methods
{
    class PrintUserName
    {
        static void PrintHelloName()
        {
            Console.WriteLine("Hi, what is you name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello,{0}!",userName);
        }
        static void Main()
        {
            PrintHelloName();
        }
    }
}
