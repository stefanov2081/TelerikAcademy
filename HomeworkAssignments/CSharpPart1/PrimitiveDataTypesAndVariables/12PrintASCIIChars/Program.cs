using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12PrintASCIIChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char characters = (char)0;
            do
            {
                Console.WriteLine(characters);
                characters++;
            }
            while (characters <= 127);
        }
    }
}
