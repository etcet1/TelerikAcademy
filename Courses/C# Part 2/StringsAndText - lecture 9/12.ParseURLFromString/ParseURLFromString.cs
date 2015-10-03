using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource]
//        and extracts from it the [protocol], [server] and [resource] elements. For example from the URL
//http://www.devbg.org/forum/index.php the following information should be extracted:
//        [protocol] = "http"
//        [server] = "www.devbg.org"
//        [resource] = "/forum/index.php"

namespace StringsAndText
{
    class ParseURLFromString
    {
        static void Main()
        {

            string inputText;
            string protocol;
            string server;
            string resource;
            List<string> parts = new List<string>();

            Console.WriteLine("Please enter the URL:");
            //read URL and trin spaces at the end if any
            inputText = Console.ReadLine().Trim();

            //extracting a part of the URL without the protocol, e.g. "http://"
            string mainPart = inputText.Substring(inputText.IndexOf("//")+2, inputText.Length - (inputText.IndexOf("//")+2));
            parts = mainPart.Split('/').ToList();

            //assigning the needed results and adding quotes
            protocol = "\"" + inputText.Substring(0, inputText.IndexOf(':')) + "\"";
            server = "\"" + parts[0] + "\"";
            parts.RemoveAt(0);
            resource = "\"" + "/" + string.Join("/", parts) + "\"";

            Console.WriteLine("[protocol] {0}\n[server] {1}\n[resource] {2}", protocol, server, resource);
        }
    }
}
