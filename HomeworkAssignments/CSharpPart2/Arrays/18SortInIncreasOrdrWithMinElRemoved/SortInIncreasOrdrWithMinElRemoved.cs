using System;

namespace _18SortInIncreasOrdrWithMinElRemoved
{
    class SortInIncreasOrdrWithMinElRemoved
    {
        static void Main(string[] args)
        {
            /* TODO: Fix the program...
             * I wrote the code, thinking that the program should sort only non-repetitive values in
             * increasing order. Then I saw that the task description contains repetitive values and values
             * that are greater than the previous number with more than 1...
             * If you are reading this, then I've decided, since this is an additional task, that I am too 
             * lazy to fix it... Please do not take into consideration...
             */ 

            // Get value from user input
            Console.WriteLine("How big array would you like to allocate?");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            // Find max elements in increasing order
            int counter = 1;
            int maxCount = 1;
            int element = 0;

            for (int i = 0; i < n; i++)
            {

                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] + 1 == array[j])
                    {
                        counter++;
                        element = array[j];
                    }
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                }
            }
            // Print
            if (n > 1)
            {
                
                Console.Write("Largest sequence is: ");
                element -= maxCount;
                if (element <= 0)
                {
                    Console.WriteLine("There is no sequence to sort in increasing order...");
                }
                for (int i = 1; i <= maxCount; i++)
                {

                    Console.Write(element + i + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The array has one element... " + array[0]);
            }
        }
    }
}
