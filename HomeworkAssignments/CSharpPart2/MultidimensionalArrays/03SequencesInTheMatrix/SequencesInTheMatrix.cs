using System;

namespace _03SequencesInTheMatrix
{
    class SequencesInTheMatrix
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("Enter n, height of the matrix:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m, width of the matrix:");
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Enter array element[{0}, {1}]", i, j);
                    matrix[i, j] = Console.ReadLine();
                }
            }
            

            string element = "";
            string maxRepEl = "";
            int count;
            int maxCount = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    
                    // Get sequence from repeating elements in row
                    count = 1;
                    for (int i = 1; i < matrix.GetLength(1) - col; i++)
                    {
                        if (matrix[row, col] == matrix[row, col + i])
                        {
                            element = matrix[row, col];
                            count++;
                        }
                        if (count > maxCount)
                        {
                            maxCount = count;
                            maxRepEl = element;
                        }
                        if (matrix[row, col] != matrix[row, col + i])
                        {
                            count = 0;
                            break;
                        }
                    }
                    
                    // Get sequence from repeating elements in column
                    count = 1;
                    for (int i = 1; i < matrix.GetLength(0) - row; i++)
                    {
                        if (matrix[row, col] == matrix[row + i, col])
                        {
                            element = matrix[row, col];
                            count++;
                        }
                        if (count > maxCount)
                        {
                            maxCount = count;
                            maxRepEl = element;
                        }
                        if (matrix[row, col] != matrix[row + i, col])
                        {
                            count = 0;
                            break;
                        }
                    }

                    // Get sequence from repeating elements in right diagonal
                    count = 1;
                    for (int i = 1; i < matrix.GetLength(0) - (row + col); i++)
                    {
                        if (matrix[row, col] == matrix[row + i, col + i])
                        {
                            element = matrix[row, col];
                            count++;
                        }
                        if (count > maxCount)
                        {
                            maxCount = count;
                            maxRepEl = element;
                        }
                        if (matrix[row, col] != matrix[row + i, col + i])
                        {
                            count = 0;
                            break;
                        }
                    }

                    // Get sequence from repeating elements in left diagonal
                    
                        count = 1;
                        for (int i = 1; i <= row - col; i++)
                        {
                            if (matrix[row, col] == matrix[row - i, col + i])
                            {
                                element = matrix[row, col];
                                count++;
                            }
                            if (count > maxCount)
                            {
                                maxCount = count;
                                maxRepEl = element;
                            }
                            if (matrix[row, col] != matrix[row - i, col + i])
                            {
                                count = 0;
                                break;
                            }
                        }
                    
                }


            }
            if (maxCount > 1)
            {
                Console.Write("Largest repeating sequence is:");
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write(" " + maxRepEl);
                    if (i < maxCount - 1)
                    {
                        Console.Write(",");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There are no repeating elements in sequence");
            }
        }
    }
}

