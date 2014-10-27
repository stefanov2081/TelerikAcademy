using System;

namespace _03Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                // Each row
                string[] row = Console.ReadLine().Split();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }

            int sum;
            int maxSum = int.MinValue;
            bool singlePattern = true;
            int diagonal;

            // Check rows
            for (int i = 0; i < n - 2; i++)
            {
                // Check cols
                for (int j = 0; j < n - 4; j++)
                {
                    sum = 0;
                    if (matrix[i, j] + 1 == matrix[i, j + 1])
                    {
                        sum += matrix[i, j] + matrix[i, j + 1];
                    }
                    if (matrix[i, j + 1] + 1 == matrix[i, j + 2])
                    {
                        sum += matrix[i, j + 2];
                    }
                    if (matrix[i, j + 2] + 1 == matrix[i + 1, j + 2])
                    {
                        sum += matrix[i + 1, j + 2];
                    }
                    if (matrix[i + 1, j + 2] + 1 == matrix[i + 2, j + 2])
                    {
                        sum += matrix[i + 2, j + 2];
                    }
                    if (matrix[i + 2, j + 2] + 1 == matrix[i + 2, j + 3])
                    {
                        sum += matrix[i + 2, j + 3];
                    }
                    if (matrix[i + 2, j + 3] + 1 == matrix[i + 2, j + 4])
                    {
                        sum += matrix[i + 2, j + 4];
                        singlePattern = true;
                    }
                    else
                    {
                        sum = 0;
                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }

                
            }

            if (singlePattern)
            {
                Console.WriteLine("YES " + maxSum);
            }
            else
            {
                diagonal = matrix[0, 0];
                for (int row = 1; row < n; row++)
                {
                    for (int col = row; col <= row; col++)
                    {
                        diagonal += matrix[row, col];
                    }
                }

                Console.WriteLine("NO " + diagonal);
            }
        }
    }
}
