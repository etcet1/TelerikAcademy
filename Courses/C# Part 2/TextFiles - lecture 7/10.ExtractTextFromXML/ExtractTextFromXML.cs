using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts from given XML file all the text without the tags. Example:
//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest> Games
//</instrest><interest>C#</instrest><interest> Java</instrest></interests></student>

namespace TextFiles
{
    class ExtractTextFromXML
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
                    string newFileLine = string.Empty;
                    while (fileLine != null)
                    {
                        newFileLine = string.Empty;

                        //searching for substrings between > and < at each line and adding it at new line
                        for (int i = 0; i < fileLine.Length - 1; i++)
                        {
                            if (fileLine[i] == '>' && fileLine[i + 1] != '<' && !char.IsControl(fileLine[i + 1]))
                            {
                                while (fileLine[i] != '<' && i < fileLine.Length - 1)
                                {
                                    if (fileLine[i] != '>' && fileLine[i] != '<')
                                    {
                                        newFileLine += fileLine[i];
                                    }
                                    i++;
                                }
                            }
                        }

                        changedData.Add(newFileLine);
                        fileLine = fileContent.ReadLine();
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
            catch (Exception ex)
            {
                Console.WriteLine("An error occured.Please try again.Error: {0}", ex);
            }
        }
    }
}
