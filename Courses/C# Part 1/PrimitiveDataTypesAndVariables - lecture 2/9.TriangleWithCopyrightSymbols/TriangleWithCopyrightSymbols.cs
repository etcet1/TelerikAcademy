using System;
using System.Text;

/* Write a program that prints an isosceles triangle of 9 copyright symbols ©.
 * Use Windows Character Map to find the Unicode code of the © symbol.
 * Note: the © symbol may be displayed incorrectly.
 */

class TriangleWithCopyrightSymbols
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int j = 2;
        for (int i = 1; i <= 5; i++)
			{
                string triangleRow = new string('\u0020', j--) + new string('\u00A9', i++);
                Console.WriteLine(triangleRow);
			}
    }
}

/*Another variant with longer solution
 * 
 * class TriangleWithCopyrightSymbols
{
    static void Main()
    {
        char copyrightSymbol = '\u00A9';
        Console.OutputEncoding = Encoding.UTF8;
        int j = 2;
        for (int i = 1; i <= 5; i++)
			{
                string spacesBefore = new string('\u0020', j--) + new string(copyrightSymbol, i++);
                string triangleCopyRight = new string(copyrightSymbol, i++);
                string triangleRow = spacesBefore + triangleCopyRight;
                Console.WriteLine(triangleRow);
			}
    }
}
 * 
 */
