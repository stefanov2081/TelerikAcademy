using System;

namespace _01PrintMatrixN
{
    class PrintMatrixN
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n, size of the matrix: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int row = 0;
            int col = 0;

            // Case 1:
            for (row = 0; row < n; row++)
            {
                for (col = 0; col < n; col++)
                {
                    matrix[row, col] = row * n + col + 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Case 1:");
            for (col = 0; col < n; col++)
            {
                for (row = 0; row < n; row++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Case 2:
            Console.WriteLine("Case 2:");
            row = 0;
            col = 0;
            for (int t = 1; t <= (n * n); t++)
            {
                if (col % 2 == 0)
                {
                    matrix[row, col] = t;
                    row++;
                    if (row == n)
                    {
                        col++;
                    }
                }
                else
                {
                    row--;
                    matrix[row, col] = t;
                    if (row == 0)
                    {
                        col++;
                    }
                }
            }

            for (row = 0; row < n; row++)
            {
                for (col = 0; col < n; col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Case 3:
            Console.WriteLine("Case 3:");
            row = n - 2;
            col = -1;
            for (int t = 1; t <= (n * n); t++)
            {
                row = row + 1;
                col = col + 1;
                if (row == n && col == n)
                {
                    row = 0;
                    col = 1;
                }
                else if (row == n && col < n)
                {
                    row = n - 1 - col;
                    col = 0;
                }
                else if (row < n && col == n)
                {
                    col = n + 1 - row;
                    row = 0;
                }
                matrix[row, col] = t;
            }

            for (row = 0; row < n; row++)
            {
                for (col = 0; col < n; col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Case 4:
            Console.WriteLine("Case 4:");
            row = 0;
            col = 0;
            int maxRow = n - 1;
            int maxCol = n - 1;
            int time = 1;
            do
            {
                // Go down
                for (int i = row; i <= maxRow; i++)
                {
                    matrix[i, col] = time;
                    time++;
                }
                col++;
                
                // Go right
                for (int i = col; i <= maxCol; i++)
                {
                    matrix[maxRow, i] = time;
                    time++;
                }
                maxRow--;

                // Go up
                for (int i = maxRow; i >= row; i--)
                {
                    matrix[i, maxCol] = time;
                    time++;
                }
                maxCol--;

                // Go left
                for (int i = maxCol; i >= col; i--)
                {
                    matrix[row, i] = time;
                    time++;
                }
                row++;

                
            }
            while (time < n * n);


            for (row = 0; row < n; row++)
            {
                for (col = 0; col < n; col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
