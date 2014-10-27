using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08stringQuotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string withQuotes = "The \"use\" of quotations causes difficulties.";
            string withoutQuotes = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(withQuotes + "\n" + withoutQuotes);
        }
    }
}
