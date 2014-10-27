using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043FirTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char blank = '.';
            char asterisk = '*';
            int incrementJ = 2;

            for (int i = 2, j = 3; i <= n; i++, j++)
            {
                Console.Write(new string(blank, n - i));
                Console.Write(new string(asterisk, j - 2));
                Console.WriteLine(new string(blank, n - i));
                j++;
            }

            Console.Write(new string(blank, n - 2));
            Console.Write(new string(asterisk, 1));
            Console.WriteLine(new string(blank, n - 2));
        }
    }
}
