using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding
//tags [URL=…]…/URL]. Sample HTML fragment:

//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course.
//Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

//<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course.
//Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

namespace StringsAndText
{
    class ReplaceAnchorTagsHTML
    {
        static void Main()
        {

            string inputText;
            //tags to find
            string[] anchorTags = { "<a href=\"", "\">", "</a>" };
            //replacement tags
            string[] newTags = { "[URL=", "]", "[/URL]" };

            Console.WriteLine("Please enter your string:");
            inputText = Console.ReadLine();

            for (int i = 0; i < anchorTags.Length; i++)
            {
                //initialize replacements
                inputText = inputText.Replace(anchorTags[i], newTags[i]);
            }

            Console.WriteLine("The string with the replaced tags:\n{0}", inputText);

        }
    }
}
