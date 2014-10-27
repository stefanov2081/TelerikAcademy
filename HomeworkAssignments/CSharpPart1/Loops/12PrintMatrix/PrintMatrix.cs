using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12PrintMatrix
{
    class PrintMatrix
    {
        static void Main(string[] args)
        {
            // Get value from user input.
            Console.WriteLine("Enter integer n <= 20, to get a matrix with that size.");
            byte n = byte.Parse(Console.ReadLine());
            int num = 1;

            // First loop goes to the current row, second prints numbers and increments value with one.
            for (int row = 1; row <= n; row++)
            {
                num = row;
                for (int j = 1; j < n + 1; j++)
                {
                    Console.Write("{0,2} ",num);
                    num++;
                }
                Console.WriteLine();
                
            }
        }
    }
}
