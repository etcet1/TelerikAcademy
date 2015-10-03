using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure
//it will work with large files (e.g. 100 MB).

//Modify the solution of the previous problem to replace only whole words (not substrings).

namespace TextFiles
{
    class ReplaceSubstrings
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

                    string newFileLine;

                    fileLine = fileContent.ReadLine();
                    while (fileLine != null)
                    {
                        newFileLine = fileLine.Replace("start", "finish");
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
            catch(FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            catch(Exception)
            {
                Console.WriteLine("An error occured.Please try again.");
            }
        }
    }
}
