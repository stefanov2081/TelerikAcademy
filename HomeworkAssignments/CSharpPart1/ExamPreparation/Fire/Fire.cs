using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire
{
    class Fire
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char fire = '#';
            char torchTop = '-';
            char blank = '.';
            char torchLeft = '\\';
            char torchRight = '/';

            // Fire
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(blank, n / 2 - (i + 1)));
                Console.Write(new string(fire, 1));
                Console.Write(new string(blank, i * 2));
                Console.Write(new string(fire, 1));
                Console.WriteLine(new string(blank, n / 2 - (i + 1)));
            }

            // Fire foundation
            for (int i = 0; i < n / 4; i++)
            {
                Console.Write(new string(blank, i));
                Console.Write(new string(fire, 1));
                Console.Write(new string(blank, n - 2 - i * 2));
                Console.Write(new string(fire, 1));
                Console.WriteLine(new string(blank, i));
            }

            // Torch top.
            Console.WriteLine(new string(torchTop, n));

            // Torch bottom.
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(blank, i));
                Console.Write(new string(torchLeft, n / 2 - i));
                Console.Write(new string(torchRight, n / 2 - i));
                Console.WriteLine(new string(blank, i));
            }
        }
    }
}
