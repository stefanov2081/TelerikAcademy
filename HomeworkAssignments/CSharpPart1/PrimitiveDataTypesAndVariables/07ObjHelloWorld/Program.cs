using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07ObjHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object concStr = hello + " " + world;
            string objConcStr = (string)concStr;
            Console.WriteLine(objConcStr);
        }
    }
}
