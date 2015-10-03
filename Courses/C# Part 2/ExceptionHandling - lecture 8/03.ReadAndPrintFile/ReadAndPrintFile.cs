using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and 
//prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions
//and print user-friendly error messages.


namespace ExceptionHandling
{
    class ReadAndPrintFile
    {

        static string ReadFile(string fileLocation)
        {
            string fileContents = File.ReadAllText(fileLocation);

            return fileContents;
        }

        static void PrintFile(string fileContent)
        {
            Console.WriteLine(fileContent);
        }

        static void Main()
        {
            try
            {
                string fileContent;
                string fileLocation;
                
                fileLocation = Console.ReadLine();
                //read file
                fileContent = ReadFile(fileLocation);
                //print file
                PrintFile(fileContent);
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
                Console.WriteLine("File not found at the path specified!");
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
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Unauthorized access!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The current operation is not supported.");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch
            {
                Console.WriteLine("Fatal error!");
            }
        }
    }
}
