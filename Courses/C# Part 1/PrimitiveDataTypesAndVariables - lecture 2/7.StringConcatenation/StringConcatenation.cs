using System;

/*Declare two string variables and assign them with “Hello” and “World”. 
 * Declare an object variable and assign it with the concatenation of the first two variables
 * (mind adding an interval). Declare a third string variable and initialize it with the value of the object
 * variable (you should perform type casting).
 */

class StringConcatenation
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object stringConcatenation = firstString + " " + secondString;
        Console.WriteLine("The concatenated string is \"{0}\"",stringConcatenation);
        //Performing type casting and assigning of the the third variable.
        string thirdString = (string) stringConcatenation;
        Console.WriteLine("After the type casting the third string now is \"{0}\"",thirdString);
    }
}