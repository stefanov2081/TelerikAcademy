using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053CardWarsBatka
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] frstPlayerCards = new string[3];
            string[] scndPlayerCards = new string[3];
            string[] deck = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" };
            int frstPlayerHand = 0;
            int scndPlayerHand = 0;
            int frstPRoundWons = 0;
            int scndPRoundWons = 0;
            int[] cardsValue = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 12, 13 };

            int counter = 0;
            int i = 0;
            int j = 0;

            // Calulate hands strength each round.
            for (int k = 0; k < n; k++)
            {
                for (int fPcards = 0; fPcards < 3; fPcards++)
                {
                    frstPlayerCards[fPcards] = Console.ReadLine();
                }
                for (int sPcards = 0; sPcards < 3; sPcards++)
                {
                    scndPlayerCards[sPcards] = Console.ReadLine();
                }

                
                // First player hand strength.
                counter = 0;
                i = 0;
                j = 0;
                while (counter < 3)
                {
                    if (frstPlayerCards[j] == deck[i])
                    {
                        frstPlayerHand += cardsValue[i];
                        j++;
                        counter++;
                        i = 0;
                    }
                    else if ((frstPlayerCards[j] == "Z") || (frstPlayerCards[j] == "Y") ||
                        (frstPlayerCards[j] == "X"))
                    {
                        j++;
                        counter++;
                    }
                    else
                    {
                        i++;
                    }

                }

                // Second player hand strength.
                counter = 0;
                i = 0;
                j = 0;
                while (counter < 3)
                {
                    if (scndPlayerCards[j] == deck[i])
                    {
                        scndPlayerHand += cardsValue[i];
                        j++;
                        counter++;
                        i = 0;
                    }
                    else if ((scndPlayerCards[j] == "Z") || (scndPlayerCards[j] == "Y") ||
                    (scndPlayerCards[j] == "X"))
                    {
                        j++;
                        counter++;
                    }
                    else
                    {
                        i++;
                    }
                }

                // Check special cards
                j = 0;
                while (j < 3)
                {
                    if (frstPlayerCards[j] == "Z")
                    {
                        frstPlayerHand *= 2;

                    }
                    else if (frstPlayerCards[j] == "Y")
                    {
                        frstPlayerHand -= 200;
                    }
                    j++;
                }

                j = 0;
                while (j < 3)
                {
                    if (scndPlayerCards[j] == "Z")
                    {
                        scndPlayerHand *= 2;

                    }
                    else if (scndPlayerCards[j] == "Y")
                    {
                        scndPlayerHand -= 200;
                    }
                    j++;
                }

                if ((scndPlayerCards[0] != "X") && (scndPlayerCards[1] != "X") &&
                    (scndPlayerCards[2] != "X") && (frstPlayerCards[0] == "X") ||
                        (frstPlayerCards[1] == "X") || (frstPlayerCards[2] == "X"))
                {
                    frstPlayerHand += 5000;
                }
                else if ((frstPlayerCards[0] != "X") && (frstPlayerCards[1] != "X") &&
                (frstPlayerCards[2] != "X") && (scndPlayerCards[1] == "X") ||
                    (scndPlayerCards[1] == "X") || (scndPlayerCards[2] == "X"))
                {
                    scndPlayerHand += 5000;
                }
                else if ((frstPlayerCards[0] == "X") || (frstPlayerCards[1] == "X") ||
                    (frstPlayerCards[2] == "X") && (scndPlayerCards[0] == "X") ||
                        (scndPlayerCards[1] == "X") || (scndPlayerCards[2] == "X"))
                {
                    frstPlayerHand += 50;
                    scndPlayerHand += 50;
                }


                // Only the player with highest score gets points for the round.
                if (frstPlayerHand > scndPlayerHand)
                {
                    frstPRoundWons += 1;
                }
                if (scndPlayerHand > frstPlayerHand)
                {
                    scndPRoundWons += 1;
                }

            }
            if ((frstPlayerHand > 4000) || (scndPlayerHand > 4000))
            {
                if ((scndPlayerCards[0] != "X") && (scndPlayerCards[1] != "X") &&
                    (scndPlayerCards[2] != "X") && (frstPlayerCards[0] == "X") ||
                        (frstPlayerCards[1] == "X") || (frstPlayerCards[2] == "X"))
                {
                    Console.WriteLine("X card drawn! Player one wins the match!");
                }
                else if ((frstPlayerCards[0] != "X") && (frstPlayerCards[1] != "X") &&
                (frstPlayerCards[2] != "X") && (scndPlayerCards[1] == "X") ||
                    (scndPlayerCards[1] == "X") || (scndPlayerCards[2] == "X"))
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                }
            }
            else
            {
                if (frstPlayerHand > scndPlayerHand)
                {
                    Console.WriteLine("First player wins! \nScore: {0} \nGames won: {1}",
                        frstPlayerHand, frstPRoundWons);
                }
                if (scndPlayerHand > frstPlayerHand)
                {
                    Console.WriteLine("Second player wins! \nScore: {0} \nGames won: {1}",
                        scndPlayerHand, scndPRoundWons);
                }
                if (frstPlayerHand == scndPlayerHand)
                {
                    
                    Console.WriteLine("It's a tie! \nScore: {0}", frstPlayerHand);
                }
            }
        }
    }
}
