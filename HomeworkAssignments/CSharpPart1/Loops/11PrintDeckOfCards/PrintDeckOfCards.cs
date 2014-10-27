using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11PrintDeckOfCards
{
    class PrintDeckOfCards
    {
        static void Main(string[] args)
        {
            // Get value from user input.
            Console.WriteLine("Which suit would you like to see?" +
                " Enter 1 for Clubs, 2 for Diamonds, 3 for Hearts, 4 for Spades abd any other number " + 
                "smaller than 255 for the whole deck.");
            byte choice = byte.Parse(Console.ReadLine());
            string[] cards = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };

            switch (choice)
            {
                case 1:
                    for (int i = 0; i < cards.Length; i++)
                    {
                        Console.Write(cards[i] + " of ");
                        for (int j = 0; j < 1; j++)
                        {
                            Console.WriteLine(suits[0]);
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < cards.Length; i++)
                    {
                        Console.Write(cards[i] + " of ");
                        for (int j = 0; j < 1; j++)
                        {
                            Console.WriteLine(suits[1]);
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < cards.Length; i++)
                    {
                        Console.Write(cards[i] + " of ");
                        for (int j = 0; j < 1; j++)
                        {
                            Console.WriteLine(suits[2]);
                        }
                    }
                    break;
                case 4:
                    for (int i = 0; i < cards.Length; i++)
                    {
                        Console.Write(cards[i] + " of ");
                        for (int j = 0; j < 1; j++)
                        {
                            Console.WriteLine(suits[3]);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("So you want to see the whole deck? Here it is...");
                    for (int i = 0; i < cards.Length; i++)
                    {
                        Console.Write(cards[i] + " of ");
                        for (int j = 0; j < 1; j++)
                        {
                            Console.WriteLine(suits[0]);
                        }
                    }
                    for (int i = 0; i < cards.Length; i++)
                    {
                        Console.Write(cards[i] + " of ");
                        for (int j = 0; j < 1; j++)
                        {
                            Console.WriteLine(suits[1]);
                        }
                    }
                    for (int i = 0; i < cards.Length; i++)
                    {
                        Console.Write(cards[i] + " of ");
                        for (int j = 0; j < 1; j++)
                        {
                            Console.WriteLine(suits[2]);
                        }
                    }
                    for (int i = 0; i < cards.Length; i++)
                    {
                        Console.Write(cards[i] + " of ");
                        for (int j = 0; j < 1; j++)
                        {
                            Console.WriteLine(suits[3]);
                        }
                    }
                    break;
            }

        }
    }
}
