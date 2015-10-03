using System;

/* 2.Which of the following values can be assigned to a variable of type 
 * float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
 */
class ChooseFloatOrDouble
{
    static void Main()
    {
        double firstValue = 34.567839023;
        float secondValue = 12.345f;
        double thirdValue = 8923.1234857;
        float fourthValue = 3456.091f;
        Console.WriteLine("{0} is double", firstValue);
        Console.WriteLine("{0} is float", secondValue);
        Console.WriteLine("{0} is double", thirdValue);
        Console.WriteLine("{0} is float", fourthValue);

    }
}
