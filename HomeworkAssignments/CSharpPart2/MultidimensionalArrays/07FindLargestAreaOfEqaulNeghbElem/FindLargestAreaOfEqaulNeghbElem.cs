using System;
using System.Collections.Generic;

namespace _07FindLargestAreaOfEqaulNeghbElem
{
    class OrderedPair
    {
        public int i1;
        public int i2;
        public bool discovered = false;
    }

    class FindLargestAreaOfEqaulNeghbElem
    {
        // Find Adjacent vertices
        static bool[,] AdjacentEqaulVertices(int[,] matrix, int row, int col)
        {
            bool[,] temp = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            int[] dRow = { -1, 1, 0, 0 };
            int[] dCol = { 0, 0, -1, 1 };

            for (int i = 0; i < 4; i++)
            {

                int modRow = dRow[i] + row;
                int modCol = dCol[i] + col;

                // Prevent index out of range errors
                if (modRow == -1 || modRow >= matrix.GetLength(0) ||
                    modCol == -1 || modCol >= matrix.GetLength(1))
                {
                    continue;
                }

                if (matrix[modRow, modCol] == matrix[row, col])
                {
                    temp[modRow, modCol] = true;
                }
            }

            return temp;
        }

        // DFS itterative from Wikipedia
        // 1  procedure DFS-iterative(G,v):
        static int DFS(int[,] matrix, OrderedPair[,] vertex, int row, int col)
        {
            int count = 0;
            OrderedPair currentVertex;
            bool[,] temp = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            // 2      let S be a stack
            Stack<OrderedPair> stackM = new Stack<OrderedPair>();
            // 3      S.push(v)
            stackM.Push(vertex[row, col]);
            // 4      while S is not empty
            while (stackM.Count != 0)
            {
                // 5            v ← S.pop()
                currentVertex = stackM.Pop();

                // 6            if v is not labeled as discovered:
                if (currentVertex.discovered == false)
                {
                    // 7                label v as discovered
                    currentVertex.discovered = true;
                    count++;
                    // 8                for all edges from v to w in G.adjacentEdges(v) do
                    temp = AdjacentEqaulVertices(matrix, currentVertex.i1, currentVertex.i2);
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (temp[i, j])
                            {
                                // 9                    S.push(w)
                                stackM.Push(vertex[i, j]);
                            }
                        }
                    }
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            //// DFS seems to work only for non diagonal elements
            //// Get value from user input, uncomment for manual input
            //Console.WriteLine("Enter matrix height:");
            //int height = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter matrix width:");
            //int width = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[height, width];

            //for (int i = 0; i < height; i++)
            //{
            //    for (int j = 0; j < width; j++)
            //    {
            //        Console.WriteLine("Enter matrix element[{0}, {1}]", i, j);
            //        matrix[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            int[,] matrix = {{1, 3, 2, 2, 2, 4},
                             {3, 3, 3, 2, 4, 4},
                             {4, 3, 1, 2, 3, 3},
                             {4, 3, 1, 3, 3, 1},
                             {4, 3, 3, 3, 1, 1}};

            int maxCount = 0;
            int count;
            // Instantiate object
            OrderedPair[,] vertex = new OrderedPair[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    vertex[i, j] = new OrderedPair();
                    vertex[i, j].i1 = i;
                    vertex[i, j].i2 = j;
                }
            }

            // Call DFS for all undiscovered elements in matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (vertex[i, j].discovered == false)
                    {
                        count = DFS(matrix, vertex, i, j);
                        if (count > maxCount)
                        {
                            maxCount = count;
                        }
                    }
                }
            }

            Console.WriteLine(maxCount);
        }
    }
}
