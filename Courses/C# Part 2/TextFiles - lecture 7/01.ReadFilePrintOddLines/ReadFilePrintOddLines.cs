using System;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.

namespace TextFiles
{
    class ReadFilePrintOddLines
    {

        static void ReadFilePrinOddLines(string filePath)
        {

            StreamReader fileContent = new StreamReader(filePath);

            using (fileContent)
            {
                int lineNumber = 0;
                string line = fileContent.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    }
                    line = fileContent.ReadLine();
                }
            }
        }

        static void Main()
        {
            string filePath;

            filePath = Console.ReadLine();

            ReadFilePrinOddLines(filePath);
        }
    }
}
