using System;
using System.IO;
using System.Text;

namespace _05ReadMatrixFromFile
{
    class FindMaxArea
    {
        // Find 2x2 elements with max sum
        static int MaxSum(int[,] matrix)
        {
            int sum = 0;
            int maxSum = 0;

            // Loop through all elements and find 2x2 elements with greatest sum
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    sum = 0;
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
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

            return maxSum;
        }

        static void Main(string[] args)
        {
            // Filepath
            string filepath = @"..\..\..\matrix.txt";

            int number;
            int[,] matrix;

            // Read from file
            using (StreamReader reader = new StreamReader(filepath))
            {
                // Read first digit in the file and assign the size of the matrix
                number = ((char)reader.Read()) - 48;
                matrix = new int[number, number];

                int row = 0;
                int col = 0;

                // Read while there are no more characters to be read
                while ((number = ((char)reader.Read()) - 48) != 65487)
                {
                    // If the character is a digit => add to matrix
                    if (number >= 0)
                    {
                        matrix[row, col] = number;
                        col++;
                        if (col == 4)
                        {
                            col = 0;
                            row++;
                        }
                    }
                }

                // Call MaxSum() and print
                Console.WriteLine("Greatest sum of 2x2 elements is " + MaxSum(matrix));
            }
        }
    }
}
