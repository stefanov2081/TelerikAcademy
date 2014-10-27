using System;

namespace _02Find3x3MaxSumInMatrix
{
    class Find3x3MaxSumInMatrix
    {
        static void Main(string[] args)
        {
            // Get vale from user input
            Console.WriteLine("Enter width of matrix:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height of matrix:");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.WriteLine("Enter matrix element row {0} column {1}", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            int sum = 0;
            int maxSum = 0;

            // Loop through all elements and find 3x3 elements with greatest sum
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            sum = sum + matrix[row + i, col + j];    
                        }
                        
                        if (maxSum < sum)
                        {
                            maxSum = sum;
                        }
                    }
                }
            }
            Console.WriteLine("Greatest sum of 3x3 elements is " + maxSum);
        }
    }
}
