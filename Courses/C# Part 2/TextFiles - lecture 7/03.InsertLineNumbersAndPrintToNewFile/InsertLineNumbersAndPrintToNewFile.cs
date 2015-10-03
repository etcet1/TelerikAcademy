using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be 
//written to another text file.

namespace TextFiles
{
    class InsertLineNumbersAndPrintToNewFile
    {
        static string AddLineNumber(string line, int lineNumber)
        {
            string editedLine;

            editedLine = "Line " + lineNumber +": " + line;
                
            return editedLine;
        }

        static void Main()
        {
            // Create reader
            StreamReader streamReader = new StreamReader("txt.txt");
            // Create writer
            StreamWriter streamWriter = new StreamWriter("asd.txt");

            try
            {
                int lineNumber = 1;
                string line = streamReader.ReadLine();

                while (line != null)
                {
                    streamWriter.WriteLine(AddLineNumber(line, lineNumber), true);
                    line = streamReader.ReadLine();
                    lineNumber++;
                }
            }
            catch (FileNotFoundException)
            {

                Console.WriteLine("File not found");
            } 
            finally
            {
                streamReader.Close();
                streamWriter.Close();
            }
        }
    }
}
