using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the 
//current directory. Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used 
//resources in the finally block.


namespace ExceptionHandling
{
    class DownloadAndStoreFile
    {
        static void DownloadFile(string fileUrl, string newFilePath)
        {
            WebClient client = new WebClient();
            client.DownloadFile(fileUrl, newFilePath);
            //Releases all resources used
            client.Dispose();
        }

        static void Main()
        {

            string url;
            string fileName;
            bool error = false;

            try
            {
                Console.WriteLine("Enter the URL for the download:");
                url = Console.ReadLine();
                //get the current filename - after last occurence of '/' in the url
                fileName = url.Substring(url.LastIndexOf('/') + 1, url.Length - url.LastIndexOf('/')-1);
                DownloadFile(url, fileName);
            }
            catch (FileNotFoundException)
            {
                error = true;
                Console.WriteLine("File not found!");
            }
            catch (FormatException)
            {
                error = true;
                Console.WriteLine("Invalid input!");
            }
            catch (IOException)
            {
                error = true;
                Console.WriteLine("Error in read/write operation!");
            }
            catch
            {
                error = true;
                Console.WriteLine("An error occurred, please try again.");
            }
            finally
            {
                if (error==false)
                {
                    Console.WriteLine("Download completed.");
                }
            }
        }
    }
}