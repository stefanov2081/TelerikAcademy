using System;
using System.Text;

namespace _203Slides_Transposed_
{
    class Ball
    {
        public int BallWidth { get; set; }

        public int BallHeight { get; set; }

        public int BallDepth { get; set; }

        public Ball(int ballWidth, int ballHeight, int ballDepth)
        {
            this.BallWidth = ballWidth;
            this.BallHeight = ballHeight;
            this.BallDepth = ballDepth;
        }

        public Ball(Ball ball)
        {
            this.BallWidth = ball.BallWidth;
            this.BallHeight = ball.BallHeight;
            this.BallDepth = ball.BallDepth;
        }
    }

    class Slides
    {
        private static int width;
        private static int depth;
        private static int height;
        private static string[, ,] cube;
        private static Ball cubeBall;

        private static void ReadInput()
        {
            string[] rawNumbers = Console.ReadLine().Split();
            width = int.Parse(rawNumbers[0]);
            height = int.Parse(rawNumbers[1]);
            depth = int.Parse(rawNumbers[2]);

            cube = new string[width, height, depth];

            for (int h = 0; h < height; h++)
            {
                string[] lineFragment = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                for (int d = 0; d < depth; d++)
                {
                    string[] cubeContent = lineFragment[d].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int w = 0; w < width; w++)
                    {
                        cube[w, h, d] = cubeContent[w];
                    }
                }
            }

            string[] rawBallCoords = Console.ReadLine().Split();

            int ballWidth = int.Parse(rawBallCoords[0]);
            int ballDepth = int.Parse(rawBallCoords[1]);

            cubeBall = new Ball(ballWidth, 0, ballDepth);
        }

        private static void ProccessBallCommands()
        {
            while (true)
            {
                string currCell = cube[cubeBall.BallWidth, cubeBall.BallHeight, cubeBall.BallDepth];

                string[] splittedCell = currCell.Split();

                string command = splittedCell[0];

                switch (command)
                {
                    case "S":
                        ProccesBallSlides(splittedCell[1]);
                        break;
                    case "T":
                        cubeBall.BallWidth = int.Parse(splittedCell[1]);
                        cubeBall.BallDepth = int.Parse(splittedCell[2]);
                        break;
                    case "B":
                        PrintMessage();
                        return;
                    case "E":
                        if (cubeBall.BallHeight == height - 1)
                        {
                            PrintMessage();
                            return;
                        }
                        else
                        {
                            cubeBall.BallHeight++;
                        }
                        break;
                    default: 
                        throw new ArgumentException("Invalid command!");
                }
            }
        }

        private static void ProccesBallSlides(string command)
        {
            Ball newCubeBall = new Ball(cubeBall);
            switch (command)
            {
                case "R":
                    newCubeBall.BallHeight++;
                    newCubeBall.BallWidth++;
                    break;
                case "L":
                    newCubeBall.BallHeight++;
                    newCubeBall.BallWidth--;
                    break;
                case "F":
                    newCubeBall.BallHeight++;
                    newCubeBall.BallDepth--;
                    break;
                case "B":
                    newCubeBall.BallHeight++;
                    newCubeBall.BallDepth++;
                    break;
                case "FL":
                    newCubeBall.BallHeight++;
                    newCubeBall.BallDepth++;
                    newCubeBall.BallWidth--;
                    break;
                case "FR":
                    newCubeBall.BallHeight++;
                    newCubeBall.BallDepth++;
                    newCubeBall.BallWidth--;
                    break;
                case "BL":
                    newCubeBall.BallHeight++;
                    newCubeBall.BallDepth--;
                    newCubeBall.BallWidth++;
                    break;
                case "BR":
                    newCubeBall.BallHeight++;
                    newCubeBall.BallDepth--;
                    newCubeBall.BallWidth++;
                    break;
                default:
                    throw new ArgumentException("Invalid command!");
            }

            if (IsPassable(newCubeBall))
            {
                cubeBall = new Ball(newCubeBall);
            }
            else
            {
                PrintMessage();
                Environment.Exit(0);
            }
        }

        private static void PrintMessage()
        {
            string currentCell = cube[cubeBall.BallWidth, cubeBall.BallHeight, cubeBall.BallDepth];

            if (currentCell == "B" || cubeBall.BallHeight != height - 1)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }

            Console.WriteLine("{0} {1} {2}", cubeBall.BallWidth, cubeBall.BallHeight, cubeBall.BallDepth);
        }

        private static bool IsPassable(Ball ball)
        {
            if (ball.BallWidth >= 0 && ball.BallHeight >= 0 && ball.BallDepth >= 0
                && ball.BallWidth < width && ball.BallHeight < height && ball.BallDepth < depth)
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            ReadInput();
            ProccessBallCommands();
        }

        

        
    }
}
