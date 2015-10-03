using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that compares two text files line by line and prints the number of lines that are the same and the 
//number of lines that are different. Assume the files have equal number of lines.

namespace TextFiles
{
    class CompareTwoFilesLineByLine
    {

        static void Main()
        {
            string firstFilePath;
            string secondFilePath;
            string firstFileLine;
            string secondFileLine;
            int equalLines = new int();
            int notEqualLines = new int();

            Console.WriteLine("Please enter the path to the first file:");

            firstFilePath = Console.ReadLine();

            Console.WriteLine("Please neter the path to the second file:");

            secondFilePath = Console.ReadLine();

            Encoding enc = System.Text.Encoding.GetEncoding(1251);

            try
            {
                StreamReader firstFile = new StreamReader(firstFilePath, enc);
                StreamReader secondFile = new StreamReader(secondFilePath, enc);

                firstFileLine = firstFile.ReadLine();
                secondFileLine = secondFile.ReadLine();

                while (firstFileLine != null && secondFileLine != null)
                {
                    if (firstFileLine.Equals(secondFileLine))
                    {
                        equalLines++;
                    }
                    else
                    {
                        notEqualLines++;
                    }
                    firstFileLine = firstFile.ReadLine();
                    secondFileLine = secondFile.ReadLine();
                }
                firstFile.Close();
                secondFile.Close();

                Console.WriteLine("The equal lines are {0}", equalLines);
                Console.WriteLine("The different lines are {0}", notEqualLines);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Please enter a correct file path.");
            }
        }
    }
}
