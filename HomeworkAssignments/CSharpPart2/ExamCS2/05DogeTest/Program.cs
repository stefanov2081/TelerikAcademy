using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DogeTest
{
    class Program
    {
        static char[,] lab;

//{

//    {' ', ' ', ' ', '*', ' ', ' ', ' '},

//    {'*', '*', ' ', '*', ' ', '*', ' '},

//    {' ', ' ', ' ', ' ', ' ', ' ', ' '},

//    {' ', '*', '*', '*', '*', '*', ' '},

//    {' ', ' ', ' ', ' ', ' ', ' ', 'e'},

//};

        static int count = 0;


        static char[] path;

           // new char[lab.GetLength(0) * lab.GetLength(1)];

        static int position = 0;



        static void FindPath(int row, int col, char direction)
        {

            if ((col < 0) || (row < 0) ||

                (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
            {

                // We are out of the labyrinth

                return;

            }



            // Append the direction to the path

            //path[position] = direction;

            position++;



            // Check if we have found the exit

            if (lab[row, col] == 'e')
            {

                PrintPath(path, 1, position - 1);

            }



            if (lab[row, col] == ' ')
            {

                // The current cell is free. Mark it as visited

                lab[row, col] = 's';



                // Invoke recursion to explore all possible directions

                FindPath(row, col - 1, 'L'); // left

                FindPath(row - 1, col, 'U'); // up

                FindPath(row, col + 1, 'R'); // right

                FindPath(row + 1, col, 'D'); // down



                // Mark back the current cell as free

                lab[row, col] = ' ';

            }



            // Remove the last direction from the path

            position--;

        }



        static void PrintPath(char[] path, int startPos, int endPos)
        {

            //Console.Write("Found path to the exit: ");

            //for (int pos = startPos; pos <= endPos; pos++)
            //{

            //    Console.Write(path[pos]);

            //}

            //Console.WriteLine();

            count++;
        }



        static void Main()
        {

            

            // Read input
            string[] sizeOfMatrix = Console.ReadLine().Split();

            lab = new char[int.Parse(sizeOfMatrix[0]), int.Parse(sizeOfMatrix[1])];

            string[] boneCoords = Console.ReadLine().Split();
            int boneX = int.Parse(boneCoords[0]);
            int boneY = int.Parse(boneCoords[1]);

            // Set Doge and bone in the matrix
            lab[boneX, boneY] = 'e';

            // Get enemies
            int numberOfEnemies = int.Parse(Console.ReadLine());

            //
            for (int i = 0; i < numberOfEnemies; i++)
            {
                boneCoords = Console.ReadLine().Split();
                lab[int.Parse(boneCoords[0]), int.Parse(boneCoords[1])] = '*';
            }

            // Fill empty elements of matrix
            for (int i = 0; i < lab.GetLength(0); i++)
            {
                for (int j = 0; j < lab.GetLength(1); j++)
                {
                    if (lab[i, j] != 'e' && lab[i, j] != '*')
                    {
                        lab[i, j] = ' ';
                    }
                }
            }

            path = new char[lab.GetLength(0) * lab.GetLength(1)];
            FindPath(0, 0, 'S');
            Console.WriteLine(count - 1);
        }
    }
}
