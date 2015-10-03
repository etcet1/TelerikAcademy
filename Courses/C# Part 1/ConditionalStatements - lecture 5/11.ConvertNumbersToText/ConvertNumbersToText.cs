﻿using System;
using System.Linq;

/** Write a program that converts a number in the range [0...999] 
 * to a text corresponding to its English pronunciation. Examples:
	0  "Zero"
	273  "Two hundred seventy three"
	400  "Four hundred"
	501  "Five hundred and one"
	711  "Seven hundred and eleven"
 */

class ConvertNumbersToText
{
    static void Main()
    {
        int testedNumber;
        int upToThousand=new int();
        int upToHundred=new int();
        int upToTen = new int();
        string[] pronunciation = new string[3];
        Console.WriteLine("Please enter a number between 0 and 999");
        string typeData = Console.ReadLine();
        if (String.IsNullOrEmpty(typeData))
        {
            Console.WriteLine("Please enter a number.");
        }
        else if (int.TryParse(typeData, out testedNumber))
        {
            if (testedNumber>=0 && testedNumber<=999)
            {
                if (testedNumber / 100 > 0)
                {
                    upToThousand = testedNumber / 100;
                    if ((testedNumber % 100)>10 && (testedNumber%100)<20)
                    {
                        upToHundred = testedNumber % 100;
                    }
                    else
                    {
                        upToHundred = (testedNumber % 100) / 10;
                        upToTen = ((testedNumber % 100) % 10);
                    }

                }
                else if (testedNumber / 10 > 0)
                {
                    if (testedNumber > 10 && testedNumber < 20)
                    {
                        upToHundred = testedNumber;
                    }
                    else
                    {
                        upToHundred = testedNumber / 10;
                        upToTen = ((testedNumber % 100) % 10);
                    }
                }
                else if (testedNumber<10)
                {
                    upToTen = testedNumber;
                }
                switch (upToThousand)
                {
                    case 1:
                        pronunciation[0] = "one hundred";
                        break;
                    case 2:
                        pronunciation[0] = "two hundred";
                        break;
                    case 3:
                        pronunciation[0] = "three hundred";
                        break;
                    case 4:
                        pronunciation[0] =  "four hundred";
                        break;
                    case 5:
                        pronunciation[0] =  "five hundred";
                        break;
                    case 6:
                        pronunciation[0] =  "six hundred";
                        break;
                    case 7:
                        pronunciation[0] =  "seven hundred";
                        break;
                    case 8:
                        pronunciation[0] =  "eight hundred";
                        break;
                    case 9:
                        pronunciation[0] =  "nine hundred";
                        break;
                    default:
                        Console.WriteLine("An error occured.");
                        break;
                }
                switch (upToHundred)
                {
                    case 1:
                        pronunciation[1] = "ten";
                        break;
                    case 2:
                        pronunciation[1] = "twenty";
                        break;
                    case 3:
                        pronunciation[1] = "thirty";
                        break;
                    case 4:
                        pronunciation[1] = "fourty";
                        break;
                    case 5:
                        pronunciation[1] = "fifty";
                        break;
                    case 6:
                        pronunciation[1] = "sixty";
                        break;
                    case 7:
                        pronunciation[1] = "seventy";
                        break;
                    case 8:
                        pronunciation[1] = "eighty";
                        break;
                    case 9:
                        pronunciation[1] = "ninety";
                        break;
                    case 11:
                        pronunciation[1] = "eleven";
                        break;
                    case 12:
                        pronunciation[1] = "twelve";
                        break;
                    case 13:
                        pronunciation[1] = "thirteen";
                        break;
                    case 14:
                        pronunciation[1] = "fourteen";
                        break;
                    case 15:
                        pronunciation[1] = "fifteen";
                        break;
                    case 16:
                        pronunciation[1] = "sixteen";
                        break;
                    case 17:
                        pronunciation[1] = "seventeen";
                        break;
                    case 18:
                        pronunciation[1] = "eighteen";
                        break;
                    case 19:
                        pronunciation[1] = "nineteen";
                        break;
                    default:
                        Console.WriteLine("An error occured.");
                        break;
                }
                switch (upToTen)
                {
                    case 1:
                        pronunciation[2] = "one";
                        break;
                    case 2:
                        pronunciation[2] = "two";
                        break;
                    case 3:
                        pronunciation[2] = "three";
                        break;
                    case 4:
                        pronunciation[2] = "four";
                        break;
                    case 5:
                        pronunciation[2] = "five";
                        break;
                    case 6:
                        pronunciation[2] = "six";
                        break;
                    case 7:
                        pronunciation[2] = "seven";
                        break;
                    case 8:
                        pronunciation[2] = "eight";
                        break;
                    case 9:
                        pronunciation[2] = "nine";
                        break;
                    case 0:
                        //the zero should appear only when the number is 0
                        if (testedNumber>10)
                        {
                            pronunciation[2] = "";
                        }
                        else
                        {
                            pronunciation[2] = "zero";

                        }
                        break;
                    default:
                        Console.WriteLine("An error occured.");
                        break;
                }
                // append diffrent formating due to the specific cases of pronunciation
                // using "where" statment from System.Linq /found in internet/ in order to remove the empty array elements when joining
                if (testedNumber>100 && (testedNumber % 100) < 10)
                {
                    Console.WriteLine("The number is " + String.Join(" and ", pronunciation.Where(x => !string.IsNullOrEmpty(x)).ToArray()));
                }
                else if (testedNumber>100 && (testedNumber % 100) > 10 && (testedNumber % 100) <20)
                {
                   Console.WriteLine("The number is " + String.Join(" and ", pronunciation.Where(x => !string.IsNullOrEmpty(x)).ToArray()));
                }
                else
                {
                    Console.WriteLine("The number is " + String.Join(" ", pronunciation.Where(x => !string.IsNullOrEmpty(x)).ToArray()));
                }
            }
            else
            {
                Console.WriteLine("The number is not in the range 0 - 999.");
            }
        }
        else
        {
            Console.WriteLine("Please enter an integer number.");
        }
        Console.WriteLine("\nPress any key to restart");
        Console.ReadKey(true);
        Console.Clear();
        Main();
    }
}

