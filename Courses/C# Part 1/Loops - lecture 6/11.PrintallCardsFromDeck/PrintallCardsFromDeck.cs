using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
 * The cards should be printed with their English names. Use nested for loops and switch-case.
 */

namespace PrintallCardsFromDeck
{
    class PrintallCardsFromDeck
    {
        static void Main()
        {
            string cardsColor = "";
            string cardsType = "";
            for (int i = 1; i <= 4; i++)
            {   
                //asigning case for each card color 
                switch (i)
                {
                    case 1:
                        cardsColor = "Clubs";
                        break;
                    case 2:
                        cardsColor = "Diamonds";
                        break;
                    case 3:
                        cardsColor = "Hearts";
                        break;
                    case 4:
                        cardsColor = "Spades";
                        break;
                    default:
                        Console.WriteLine("No such card color.");
                        break;
                }
                    for (int j = 2; j <= 14; j++)
			    {
                    //asigning case for each card type 
                    switch (j)
                    {
                        case 2:
                            cardsType = "Two";
                            break;
                        case 3:
                            cardsType = "Three";
                            break;
                        case 4:
                            cardsType = "Four";
                            break;
                        case 5:
                            cardsType = "Five";
                            break;
                        case 6:
                            cardsType = "Six";
                            break;
                        case 7:
                            cardsType = "Seven";
                            break;
                        case 8:
                            cardsType = "Eight";
                            break;
                        case 9:
                            cardsType = "Nine";
                            break;
                        case 10:
                            cardsType = "Ten";
                            break;
                        case 11:
                            cardsType = "Jack";
                            break;
                        case 12:
                            cardsType = "Queen";
                            break;
                        case 13:
                            cardsType = "King";
                            break;
                        case 14:
                            cardsType = "Ace";
                            break;
                        default:
                            Console.WriteLine("No such card.");
                            break;
                    }
                    Console.WriteLine(cardsType + " of " + cardsColor);
			 
			    }
                
            }
        }
    }
}
