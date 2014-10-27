using System;
using System.Text;

namespace _203Slides
{
    class Slides
    {
        static void Main(string[] args)
        {
            string[] sizeOfCube = Console.ReadLine().Split();

            StringBuilder sb = new StringBuilder();

            // Width, height, depth
            string[, ,] cube = new string[int.Parse(sizeOfCube[0]), int.Parse(sizeOfCube[1]), int.Parse(sizeOfCube[2])];

            string[] eachCellOnLevel = new string[cube.GetLength(0) * cube.GetLength(2)];
            int index;
            bool openedParenteshis = false;

            // This for is equal to height
            for (int y = 0; y < cube.GetLength(1); y++)
            {
                string eachLevelOfCube = Console.ReadLine();
                index = 0;

                // Splits the cells on each level of the cube
                for (int xTimesZ = 0; xTimesZ < eachLevelOfCube.Length; xTimesZ++)
                {
                    if (eachLevelOfCube[xTimesZ] == '(')
                    {
                        sb.Append(eachLevelOfCube[xTimesZ]);
                        openedParenteshis = true;
                    }
                    else if (openedParenteshis)
                    {
                        sb.Append(eachLevelOfCube[xTimesZ]);

                        if (eachLevelOfCube[xTimesZ] == ')')
                        {
                            eachCellOnLevel[index] = sb.ToString();
                            openedParenteshis = false;
                            sb.Clear();
                            index++;
                        }
                    }
                }

                index = 0;
                // Equal to depth
                for (int z = 0; z < cube.GetLength(2); z++)
                {
                    // Equal to width
                    for (int x = 0; x < cube.GetLength(0); x++)
                    {
                        cube[x, y, z] = eachCellOnLevel[index];
                        index++;
                    }
                }
            }

            

            string[] ballXAndZ = Console.ReadLine().Split();

            int ballX = int.Parse(ballXAndZ[0]);
            int ballY = cube.GetLength(1) - 1;
            int ballZ = int.Parse(ballXAndZ[1]);

            //for (int y = 0; y < cube.GetLength(1); y++)
            //{
            //    Console.WriteLine("Level: " + y);
            //    for (int z = 0; z < cube.GetLength(2); z++)
            //    {
            //        for (int x = 0; x < cube.GetLength(0); x++)
            //        {
                        
            //            Console.Write("Cell: x = {0}, y = {1} , z = {2} = {3}", x, y, z, cube[x, y, z]);
            //            Console.WriteLine();
            //        }
            //        Console.WriteLine();
            //    }
            //}

            string currentCell;
            string exit = string.Empty;
            int teleportX;
            int teleportZ;

            for (int i = 0; i < (cube.GetLength(0) * cube.GetLength(1) * cube.GetLength(2)); i++)
            {
                currentCell = cube[ballX, ballY, ballZ];

                // Teleport
                for (int j = 0; j < currentCell.Length; j++)
                {
                    if (currentCell[j] == 'T')
                    {
                        teleportX = currentCell[j + 2] - 48;
                        teleportZ = currentCell[j + 4] - 48;
                        break;
                    }
                }

                // Slide
                if (currentCell == "(S L)")
                {
                    if (ballX > 0)
                    {
                        ballY--;
                        ballX--;
                    }
                    // Check if the ball is on the last level
                    else if (ballY == 0)
                    {
                        exit = "Yes";
                        break;
                    }
                    // Check if the ball is stuck
                    else if (ballX == 0)
                    {
                        exit = "No";
                        break;
                    }
                }
                else if (currentCell == "(S R)")
                {
                    if (ballX + 1 < cube.GetLength(0))
                    {
                        ballY--;
                        ballX++;
                    }
                    // Check if the ball is on the last level
                    else if (ballY == 0)
                    {
                        exit = "Yes";
                        break;
                    }
                    // Check if the ball is stuck
                    else if (ballY == cube.GetLength(0) - 1)
                    {
                        exit = "No";
                        break;
                    }
                }
                else if (currentCell == "(S F)")
                {
                    if (ballZ > 0)
                    {
                        ballY--;
                        ballZ--;
                    }
                    // Check if the ball is on the last level
                    else if (ballY == 0)
                    {
                        exit = "Yes";
                        break;
                    }
                    // Check if the ball is stuck
                    else if (ballZ == 0)
                    {
                        exit = "No";
                        break;
                    }
                }
                else if (currentCell == "(S B)")
                {
                    if (ballZ + 1 < cube.GetLength(2))
                    {
                        ballY--;
                        ballZ++;
                    }
                    // Check if the ball is on the last level
                    else if (ballY == 0)
                    {
                        exit = "Yes";
                        break;
                    }
                    // Check if the ball is stuck
                    else if (ballZ == cube.GetLength(2) - 1)
                    {
                        exit = "No";
                        break;
                    }
                }
                else if (currentCell == "(S FL)")
                {
                    if (ballZ > 0 && ballX > 0)
                    {
                        ballY--;
                        ballZ--;
                        ballX--;
                    }
                    // Check if the ball is on the last level
                    else if (ballY == 0)
                    {
                        exit = "Yes";
                        break;
                    }
                    // Check if the ball is stuck
                    else if (ballX == 0 || ballZ == 0)
                    {
                        exit = "No";
                        break;
                    }
                }
                else if (currentCell == "(S FR)")
                {
                    if (ballZ > 0 && ballX + 1 < cube.GetLength(0))
                    {
                        ballY--;
                        ballZ--;
                        ballX++;
                    }
                    // Check if the ball is on the last level
                    else if (ballY == 0)
                    {
                        exit = "Yes";
                        break;
                    }
                    // Check if the ball is stuck
                    else if (ballX == cube.GetLength(0) - 1 || ballZ == 0)
                    {
                        exit = "No";
                        break;
                    }
                }
                else if (currentCell == "(S BL)")
                {
                    if (ballZ + 1 < cube.GetLength(2) && ballX > 0)
                    {
                        ballY--;
                        ballZ++;
                        ballX--;
                    }
                    // Check if the ball is on the last level
                    else if (ballY == 0)
                    {
                        exit = "Yes";
                        break;
                    }
                    // Check if the ball is stuck
                    else if (ballX == 0 || ballZ == cube.GetLength(2) - 1)
                    {
                        exit = "No";
                        break;
                    }
                }
                else if (currentCell == "(S BR)")
                {
                    if (ballZ + 1 < cube.GetLength(2) && ballX + 1 < cube.GetLength(0))
                    {
                        ballY--;
                        ballZ++;
                        ballX++;
                    }
                    // Check if the ball is on the last level
                    else if (ballY == 0)
                    {
                        exit = "Yes";
                        break;
                    }
                    // Check if the ball is stuck
                    else if (ballX == cube.GetLength(0) - 1 || ballZ == cube.GetLength(2) - 1)
                    {
                        exit = "No";
                        break;
                    }
                }

                // Empty cell
                else if (currentCell == "(E)")
                {
                    ballY--;

                    if (ballY == -1)
                    {
                        ballY = 0;
                        exit = "Yes";
                        break;
                    }
                }

                // Basket
                else if (currentCell == "(B)")
                {
                    exit = "No";
                    break;
                }
            }

            Console.WriteLine(exit);
            Console.WriteLine("{0} {1} {2}", ballX, ballY, ballZ);
        }
    }
}
