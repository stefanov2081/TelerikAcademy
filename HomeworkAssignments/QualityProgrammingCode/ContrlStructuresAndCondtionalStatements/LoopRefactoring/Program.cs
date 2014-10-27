using System;

namespace LoopRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {0};
            int expectedValue = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);

                    if (array[i] == expectedValue)
                    {
                        i = 666;
                        Console.WriteLine("Value Found");
                    }
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
