using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that deletes from given text file all odd lines. The result should be in the same file.

namespace TextFiles
{
    class DeleteOddLinesFromFile
    {
        static void Main()
        {
            string filePath;
            string fileLine;

            Console.WriteLine("Please enter the path to the file /test.txt/:");
            filePath = Console.ReadLine();

            //set the encoding
            Encoding enc = System.Text.Encoding.GetEncoding(1251);

            try
            {
                //reading the data of the new file
                StreamReader fileContent = new StreamReader(filePath, enc);
                //list with the lines from the old file 
                List<string> changedData = new List<string>();

                using (fileContent)
                {
                    fileLine = fileContent.ReadLine();
                    int currentLine = 0;
                    while (fileLine != null)
                    {
                        //taking only even lines
                        if (currentLine % 2 == 0)
                        {
                            changedData.Add(fileLine);
                        }

                        fileLine = fileContent.ReadLine();

                        currentLine++;
                    }
                }

                //replacing the data of the old file
                StreamWriter newFileContent = new StreamWriter(filePath, false, enc);

                using (newFileContent)
                {
                    foreach (var line in changedData)
                    {
                        newFileContent.WriteLine(line);
                    }
                }
                Console.WriteLine("Completed!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured.Please try again.");
            }
        }
    }
}