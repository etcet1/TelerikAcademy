using System;
using System.Collections.Generic;

//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.

class ReadWordFromConsole
{
    static void Main()
    {
        Console.WriteLine("Enter the word:");
        string word = Console.ReadLine();
        List<char> wordSymbols = new List<char>();
        for (int i = 0; i < word.Length; i++)
        {
            wordSymbols.Add(word[i]);
        }
        //using the ACII table for filling o f the array with leters
        List<char> letters = new List<char>();
        for (int i = 65; i < 122; i++)
        {
            letters.Add((char)i);
            //jump to lowercase "a"
            if (i==90)
            {
                i = 96;
            }
        }
        //sorting the char array in order to use BinarySearch for representation of the letter index
        letters.Sort();
        for (int i = 0; i < wordSymbols.Count; i++)
        {
            Console.WriteLine("The postion of the letter {0} is {1}",wordSymbols[i], letters.BinarySearch(wordSymbols[i]));
        }
        Console.WriteLine("\nThe array with letters is ordered as follows /index -> value/:");
        for (int i = 0; i < letters.Count; i++)
        {
            Console.Write("{1} -> {0}; ", letters[i], i);
        }
        Console.WriteLine();
    }
}
