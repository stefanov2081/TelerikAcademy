using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11SwapValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 5;
            int secondValue = 10;
            int storeValue;
            Console.WriteLine("First variable has value of {0} and the second one has value of {1}", firstValue, secondValue);
            storeValue = firstValue;
            firstValue = secondValue;
            secondValue = storeValue;
            Console.WriteLine("After we swap the values, the first one has value of {0} and the second one has value of {1}", firstValue, secondValue);
        }
    }
}
