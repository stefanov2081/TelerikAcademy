using System;

namespace _05FindMaxIncreasingSubsetInArray
{
    class FindMaxIncreasingSubsetInArray
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("How big array would you like to allocate?");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int counter = 1;
            int maxSeq = 0;
            int element = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int ii = 0;
            int j = 1;

            // Find max increasing subset
            if (array.Length > 1)
            {
                while (true)
                {
                    // If the selected element + 1 is equal to the nex one increment counter
                    if (array[ii] + 1 == array[j])
                    {
                        // Prevents index out of range errors
                        if (j < array.Length - 1)
                        {
                            counter++;
                            ii++;
                            j++;
                            continue;
                        }
                        else
                        {
                            counter++;
                            element = array[ii] + 1;
                        }
                    }

                    // Find the max increasing sequnce so far and store it's first member
                    if (counter > maxSeq)
                    {
                        maxSeq = counter;
                        if (j < array.Length - 1)
                        {
                            element = array[ii];
                        }
                    }

                    // Prevents index out of range errors
                    if (j >= array.Length - 1)
                    {
                        break;
                    }

                    // If the selected element + 1 is different than the next one, select the next one
                    if (array[ii] + 1 != array[j])
                    {
                        // Prevents index out of range errors
                        if (j < array.Length - 1)
                        {
                            ii++; ;
                            j++;
                            counter = 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                // Print largest sequence starting from it's first member
                Console.Write("Largest sequence is: ");
                element -= maxSeq;
                for (int i = 1; i <= maxSeq; i++)
                {

                    Console.Write(element + i + " ");
                }
            }
            else
            {
                Console.WriteLine("The set has one member... " + array[0]);
            }
        }
    }
}
