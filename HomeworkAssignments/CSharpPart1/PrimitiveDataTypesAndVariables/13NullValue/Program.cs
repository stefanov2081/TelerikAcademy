using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13NullValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            Console.WriteLine("Integer \"a\" has a Null value" + a);
            Console.WriteLine("Double \"b\" has a Null value" + b);
            a = 5;
            b = 12;
            Console.WriteLine("When we assign value, integer \"a\" has a value of {0}", a);
            Console.WriteLine("When we assign value, double \"b\" has a value of {0}", b);
        }
    }
}
