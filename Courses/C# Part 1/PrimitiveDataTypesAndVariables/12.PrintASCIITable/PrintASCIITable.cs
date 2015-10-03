using System;

/* 12.Find online more information about ASCII (American Standard Code for Information Interchange) and 
 * write a program that prints the entire ASCII table of characters on the console.
 */

class PrintASCIITable
{
    static void Main()
    {
        /* String variable used in order to avoid long console screen.
         * Due to the fact that "TAB","new line" and "carriage return" cannot be displayed
         * we use their representation as "TAB","\n" and "\cr".
         * Spaces are being used as a separator between the symbols.
         */ 
        string charactersFromASCII = "";
        for (int i = 0; i < 255; i++)
        {
            if (i == 9)
            {
                charactersFromASCII += " " + "TAB" + " ";
            }
            else if (i == 10)
            {
                charactersFromASCII += " " + "\\n" + " ";
            }
            else if (i == 13)
            {
                charactersFromASCII += " " + "\\cr" + " ";
            }
            else
            {
                charactersFromASCII += " " + (char)i + " ";
            }
        }
        Console.WriteLine(charactersFromASCII);
    }
}
