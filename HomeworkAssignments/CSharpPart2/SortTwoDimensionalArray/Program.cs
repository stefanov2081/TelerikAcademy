using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTwoDimensionalArray
{
    class Program
    {
        // Sort the array
        static void SortArray(int[,] matrix, int n, int m)
        {
            int swapvall;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    for (int y = row; y < n; y++)
                    {
                        for (int x = col + 1; x < m; x++)
                        {
                            if (matrix[y, x] <= matrix[row, col])
                            {
                                swapvall = matrix[row, col];
                                matrix[row, col] = matrix[y, x];
                                matrix[y, x] = swapvall;
                            }
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // Get values from user input
            Console.WriteLine("Enter n, height of matrix:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m, width of matrix:");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.WriteLine("Enter array element[{0},{1}]", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            SortArray(matrix, n, m);
            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }
        }
    }
}
