using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//Write a program that concatenates two text files into another text file.

namespace TextFiles
{

    class ConcatenateTwoTextFilesIntoNewFile
    {
        static void WriteNewFile(string fileContent, string filePath)
        {
            StreamWriter newTextFile = new StreamWriter(filePath);

            using (newTextFile)
            {
                newTextFile.Write(fileContent);
            }
        }

        static string ReadFile(string filePath)
        {
            StreamReader fileContent = new StreamReader(filePath);

            using (fileContent)
            {
                return fileContent.ReadToEnd();
            }
        }

        static void Main()
        {
            string filePath;
            string newFile;
            StringBuilder newFileContent = new StringBuilder();

            try
            {
                Console.WriteLine("Please enter the path to the first file:");
                filePath = Console.ReadLine();

                //append the content of the first file to the new file
                newFileContent.AppendLine(ReadFile(filePath));

                Console.WriteLine("Please enter the path to the second file:");
                filePath = Console.ReadLine();

                //append the content of the second file to the new file
                newFileContent.AppendLine(ReadFile(filePath));

                Console.WriteLine("Please enter the name of the file:");
                newFile = Console.ReadLine();

                //write the concatenated content to the new file
                WriteNewFile(newFileContent.ToString(), newFile);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("A part of a file or a directory cannot be found in the current path!");
            }
            catch (EndOfStreamException)
            {
                Console.WriteLine("The file path contains a directory that cannot be found!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The file path or the file name is longer than the system-defined maximum length!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found at the specified path!");
            }
            catch (FileLoadException)
            {
                Console.WriteLine("The file cannot be loaded!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Empty file path - please enter a valid one!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid argument provided!");
            }
        }
    }
}