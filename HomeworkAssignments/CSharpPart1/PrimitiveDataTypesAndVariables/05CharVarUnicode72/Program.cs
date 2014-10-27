using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CharVarUnicode72
{
    class Program
    {
        static void Main(string[] args)
        {
            int hex72 = 0x0048;
            char unicodeChar = (char)hex72;
            Console.WriteLine(unicodeChar);
        }
    }
}
