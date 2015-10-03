using System;

/* Create a program that assigns null values to an integer and to double variables. 
 * Try to print them on the console, try to add some values or the null literal to them and see the result.
 */

class NullValuesToInteger
{
    static void Main()
    {
        int? testNullInteger = null;
        double? testNullDouble = null;
        Console.WriteLine("Integer with NULL value: " + testNullInteger + ";");
        Console.WriteLine("Double with NULL value: " + testNullDouble + ";");
        Console.WriteLine();
        testNullInteger = 6;
        testNullDouble = 2.33f;
        Console.WriteLine("Integer with changed value: " + testNullInteger + ";");
        Console.WriteLine("Double with changed value: " + testNullDouble + ";");
    }
}
