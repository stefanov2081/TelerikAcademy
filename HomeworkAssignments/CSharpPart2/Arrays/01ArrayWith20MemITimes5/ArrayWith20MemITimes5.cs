using System;

namespace _01ArrayWith20MemITimes5
{
    class ArrayWith20MemITimes5
    {
        static void Main(string[] args)
        {
            // Allocate array
            int[] arr = new int[20];

            // Multiply each element by 5 and print
            for (int i = 0; i < 20; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }
        }
    }
}
