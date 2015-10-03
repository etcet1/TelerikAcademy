using System;

class Poker
{
    static void Main()
    {
        string[] cards = new string[5];
        for (int i = 0; i < cards.Length; i++)
        {
            cards[i] = Console.ReadLine();
        }
        Console.WriteLine();

        int[] cardScore = new int[5];
        for (int j = 0; j < cards.Length; j++)
        {
            switch (cards[j])
            {
                case "2":
                    cardScore[j] = 2;
                    break;
                case "3":
                    cardScore[j] = 3;
                    break;
                case "4":
                    cardScore[j] = 4;
                    break;
                case "5":
                    cardScore[j] = 5;
                    break;
                case "6":
                    cardScore[j] = 6;
                    break;
                case "7":
                    cardScore[j] = 7;
                    break;
                case "8":
                    cardScore[j] = 8;
                    break;
                case "9":
                    cardScore[j] = 9;
                    break;
                case "10":
                    cardScore[j] = 10;
                    break;
                case "J":
                    cardScore[j] = 11;
                    break;
                case "Q":
                    cardScore[j] = 12;
                    break;
                case "K":
                    cardScore[j] = 13;
                    break;
                case "A":
                    cardScore[j] = 14;
                    break;
                default:
                    Console.WriteLine("No such card.");
                    break;
            }
        }
        int maxequal = 0;
        int counter = 0;
        for (int i = 0; i < cardScore.Length; i++)
	    {
			 
			
            for (int j = 2; j <= 14; j++)
            {
                if (j == cardScore[i])
	          {
                  counter++;
	          }
                if (counter>maxequal)
                {
                    maxequal = counter;
                }
            }
        }
        Console.WriteLine(maxequal);

    }
}

