﻿using System;

/*5.Declare a character variable and assign it with the symbol that has Unicode code 72.
 * Hint: first use the Windows Calculator to find the hexadecimal representation of 72.
 */


class IntegerAsUnicodeSymbol
{
    static void Main()
    {
        char a='\u0048';
        Console.WriteLine(a);
    }
}