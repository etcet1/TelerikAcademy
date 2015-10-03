using System;

/* 8.Declare two string variables and assign them with following value:
 * The "use" of quotations causes difficulties.
 * Do the above in two different ways: with and without using quoted strings.
 */

class StringsWithQuotedStrings
{
    static void Main()
    {
        string sentenceWithQuotes="The \"use\" of quotations causes difficulties.";
        string sentenceWithoutQuotes = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("With escaping or using \"@\" - the result is the same: \n\n using escape sequence: \n {0} \n\n using \"@\": \n {1}  ", sentenceWithQuotes, sentenceWithoutQuotes);
    }
}
