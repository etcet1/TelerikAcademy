using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
//    Ivan			George
//    Peter			Ivan
//    Maria			Maria
//    George		Peter


namespace TextFiles
{
    class ReadFileAndSortStrings
    {
        static void Main()
        {
            string filePath;
            string newFilePath;
            string fileLine;

            //path to the original file
            Console.WriteLine("Please enter the path to the file /test.txt/:");
            filePath = Console.ReadLine();

            //path to the new file
            Console.WriteLine("Please enter the path to the new file:");
            newFilePath = Console.ReadLine();

            Encoding enc = System.Text.Encoding.GetEncoding(1251);

            //creating reader and writer
            StreamReader fileContent = new StreamReader(filePath, enc);

            StreamWriter newFileContent = new StreamWriter(newFilePath, false);

            //creating list with the data
            List<string> stringFromFiles = new List<string>();

            using (fileContent)
            {
                fileLine = fileContent.ReadLine();
                while (fileLine != null)
                {
                    stringFromFiles.Add(fileLine);
                    fileLine = fileContent.ReadLine();
                }
                
            }

            //sote the data from file
            stringFromFiles.Sort();

            using (newFileContent)
            {
                foreach (var item in stringFromFiles)
                {
                    newFileContent.WriteLine(item);

                }
            }
        }
    }
}