using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013ForestRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char path = '*';
            char trees = '.';

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(trees, i));
                Console.Write(new string(path, 1));
                Console.WriteLine(new string(trees, n - 1 - i));
            }

            for (int i = n - 1; i > 0; i--)
            {
                Console.Write(new string(trees, i - 1));
                Console.Write(new string(path, 1));
                Console.WriteLine(new string(trees, n - i));
            }
        }
    }
}
