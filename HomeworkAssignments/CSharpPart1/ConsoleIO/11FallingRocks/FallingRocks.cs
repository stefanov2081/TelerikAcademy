using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _11FallingRocks
{

    class FallingRocks
    {
        // * Note: Crappy alpha version!!! I do not have time to finish it right now...
        // Sets the starting position of the dwarf.
        static int dwarfStartingXPosition = Console.WindowWidth / 2 - 2;
        static int dwarfStartingYPosition = 23;
        // Stores player's lives left.
        static int livesLeft = 3;
        // Stores the rocks and coordinates of rocks.
        static string[] rocks = new string[] { "^", "@", "*", "+", "%", "$", "#", "!", ".", ";", "-" };
        static string[] randomRock = new string[25];
        static int rockPositionY = 1;
        static int[] randomRockPositionX = new int[25];
        // Random Generator.
        static Random randomGenerator = new Random();

        static void RockHitsDwarf()
        {

            for (int i = 0; i < 25; i++)
            {
                if (((randomRockPositionX[i] == dwarfStartingXPosition) | (randomRockPositionX[i] == dwarfStartingXPosition + 1) | (randomRockPositionX[i] == dwarfStartingXPosition + 2)) & (rockPositionY == dwarfStartingYPosition))
                {
                    livesLeft--;
                }
                if (livesLeft == 0)
                {
                    DrawAtPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2, "Game over!");
                    DrawAtPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 + 1, 
                        "Pres ctrl + c to quit.");
                    Console.ReadKey();
                }
            }

        }

        // Draw rocks.
        static void DrawRocks(int numberOfRocks)
        {
            for (int i = 0; i < 15; i++)
            {
                DrawAtPosition(randomRockPositionX[i], rockPositionY, randomRock[i]);
            }
        }

        // Moves the rocks down.
        static void MoveRocks()
        {
            if (rockPositionY < 23)
            {
                rockPositionY++;
            }
            else
            {
                for (int i = 0; i < 15; i++)
                {
                    randomRockPositionX[i] = randomGenerator.Next(0, Console.WindowWidth - 5);
                    randomRock[i] = rocks[randomGenerator.Next(0, 11)];
                }
                rockPositionY = 1;
            }
        }

        // Moves dwarf to the right.
        static void MoveDwarfRight()
        {
            if (dwarfStartingXPosition < Console.WindowWidth - 3)
            {
                dwarfStartingXPosition++;
            }
        }

        // Moves dwarf to the left.
        static void MoveDwarfLeft()
        {
            if (dwarfStartingXPosition > 0)
            {
                dwarfStartingXPosition--;
            }
        }

        // Draws dwarf.
        static void DrawDwarf()
        {
            DrawAtPosition(dwarfStartingXPosition, dwarfStartingYPosition, "(O)");
        }

        // Prints how many lives does the playe have left.
        static void PrintLivesLeft()
        {
            DrawAtPosition(0, 24, "Lives left: " + livesLeft);
        }

        // Draws at given position.
        static void DrawAtPosition(int x, int y, string symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        // Sets constant console size.
        static void SetGameField()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        MoveDwarfLeft();
                    }
                    if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        MoveDwarfRight();
                    }
                }
                Console.Clear();
                SetGameField();
                DrawRocks(15);
                MoveRocks();
                DrawDwarf();
                RockHitsDwarf();
                PrintLivesLeft();
                Thread.Sleep(150);
            }

        }






    }
}
