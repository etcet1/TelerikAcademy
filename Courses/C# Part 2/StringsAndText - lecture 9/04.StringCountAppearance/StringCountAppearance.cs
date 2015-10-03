using System;
using System.Text;

//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//        Example: The target substring is "in". The text is as follows:
//We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking
//all the day. We will move out of it in 5 days.
//    The result is: 9.

namespace StringsAndText
{
    class StringCountAppearance
    {
        static void Main()
        {
            string testInput;
            string needle;
            int foundIndex;
            int startIndex = 0;
            int count = 0;
          
            Console.WriteLine("Please enter your text string:");
            testInput = Console.ReadLine().ToLower();

            Console.WriteLine("For what substring we are looking for?");
            needle = Console.ReadLine().ToLower();


            for (int i = 0; i < testInput.Length; i++)
            {
                foundIndex = testInput.IndexOf(needle, startIndex);

                if (foundIndex > -1)
                {
                    startIndex = foundIndex + needle.Length;
                    count++;
                }
            }

            if (count==0)
            {
                Console.WriteLine("The substring {0} is not found in the string.", needle);
            }
            else
            {
                Console.WriteLine("The substring {0} is found {1} in the string.", needle, count);
            }
        }
    }
}
