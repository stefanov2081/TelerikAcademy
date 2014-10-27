using System;
using System.Collections.Generic;
using System.Text;

/*Refactor and improve the naming in the C# source project “3. Naming-Identifiers-Homework.zip”. 
 * You are allowed to make other improvements in the code as well (not only naming) as well as to fix bugs.
 * I am allowed to make other improvements, but they are not compulsory
*/

namespace Minesweeper
{
    public class Mines
    {
        public class PlayerScore
        {
            private string name;
            private int score;

            public PlayerScore(string name, int score)
            {
                this.name = name;
                this.score = score;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Score
            {
                get { return score; }
                set { score = value; }
            }

            public PlayerScore() { }

            
        }

        private static void HighScores(List<PlayerScore> score)
        {
            Console.WriteLine("\nTo4KI:");
            if (score.Count > 0)
            {
                for (int i = 0; i < score.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, score[i].Name, score[i].Score);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void PlayerTurn(char[,] gameField,
            char[,] minesInField, int row, int col)
        {
            char numberOfMines = numberOfMinesAroundPlayerSelection(minesInField, row, col);
            minesInField[row, col] = numberOfMines;
            gameField[row, col] = numberOfMines;
        }

        private static void DrawGameField(char[,] board)
        {
            int numberOfRows = board.GetLength(0);
            int numberOfCols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < numberOfRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < numberOfCols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> minesList = new List<int>();
            while (minesList.Count < 15)
            {
                Random random = new Random();
                int minePosition = random.Next(50);
                if (!minesList.Contains(minePosition))
                {
                    minesList.Add(minePosition);
                }
            }

            foreach (int position in minesList)
            {
                int mineCol = (position / cols);
                int mineRow = (position % cols);

                if (mineRow == 0 && position != 0)
                {
                    mineCol--;
                    mineRow = cols;
                }
                else
                {
                    mineRow++;
                }
                gameField[mineCol, mineRow - 1] = '*';
            }

            return gameField;
        }

        private static void GetNumberOfMinesAroundPlayerPosition(char[,] gameField)
        {
            int row = gameField.GetLength(0);
            int col = gameField.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (gameField[i, j] != '*')
                    {
                        char minesAroundPlayerSelection = numberOfMinesAroundPlayerSelection(gameField, i, j);
                        gameField[i, j] = minesAroundPlayerSelection;
                    }
                }
            }
        }

        private static char numberOfMinesAroundPlayerSelection(char[,] minesInField, int row, int col)
        {
            int count = 0;
            int rows = minesInField.GetLength(0);
            int cols = minesInField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (minesInField[row - 1, col] == '*')
                {
                    count++;
                }
            }
            if (row + 1 < rows)
            {
                if (minesInField[row + 1, col] == '*')
                {
                    count++;
                }
            }
            if (col - 1 >= 0)
            {
                if (minesInField[row, col - 1] == '*')
                {
                    count++;
                }
            }
            if (col + 1 < cols)
            {
                if (minesInField[row, col + 1] == '*')
                {
                    count++;
                }
            }
            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (minesInField[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }
            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (minesInField[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }
            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (minesInField[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }
            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (minesInField[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }
            return char.Parse(count.ToString());
        }

        static void Main()
        {
            const int MaxPoints = 35;
            string command = string.Empty;
            char[,] gameField = CreateGameField();
            char[,] minesInGameField = PlaceMines();
            int counter = 0;
            bool explosion = false;
            List<PlayerScore> highScores = new List<PlayerScore>(6);
            int row = 0;
            int col = 0;
            bool firstGame = true;
            bool flawlessGame = false;

            do
            {
                if (firstGame)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    DrawGameField(gameField);
                    firstGame = false;
                }

                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= gameField.GetLength(0) && col <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        HighScores(highScores);
                        break;
                    case "restart":
                        gameField = CreateGameField();
                        minesInGameField = PlaceMines();
                        DrawGameField(gameField);
                        explosion = false;
                        firstGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (minesInGameField[row, col] != '*')
                        {
                            if (minesInGameField[row, col] == '-')
                            {
                                PlayerTurn(gameField, minesInGameField, row, col);
                                counter++;
                            }

                            if (MaxPoints == counter)
                            {
                                flawlessGame = true;
                            }
                            else
                            {
                                DrawGameField(gameField);
                            }
                        }
                        else
                        {
                            explosion = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (explosion)
                {
                    DrawGameField(minesInGameField);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", counter);
                    string niknejm = Console.ReadLine();
                    PlayerScore t = new PlayerScore(niknejm, counter);
                    if (highScores.Count < 5)
                    {
                        highScores.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < highScores.Count; i++)
                        {
                            if (highScores[i].Score < t.Score)
                            {
                                highScores.Insert(i, t);
                                highScores.RemoveAt(highScores.Count - 1);
                                break;
                            }
                        }
                    }

                    highScores.Sort((PlayerScore r1, PlayerScore r2) => r2.Name.CompareTo(r1.Name));
                    highScores.Sort((PlayerScore r1, PlayerScore r2) => r2.Score.CompareTo(r1.Score));
                    HighScores(highScores);

                    gameField = CreateGameField();
                    minesInGameField = PlaceMines();
                    counter = 0;
                    explosion = false;
                    firstGame = true;
                }

                if (flawlessGame)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    DrawGameField(minesInGameField);

                    Console.WriteLine("Daj si imeto, batka: ");
                    string name = Console.ReadLine();
                    PlayerScore score = new PlayerScore(name, counter);
                    highScores.Add(score);
                    HighScores(highScores);

                    gameField = CreateGameField();
                    minesInGameField = PlaceMines();
                    counter = 0;
                    flawlessGame = false;
                    firstGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }
    }
}
