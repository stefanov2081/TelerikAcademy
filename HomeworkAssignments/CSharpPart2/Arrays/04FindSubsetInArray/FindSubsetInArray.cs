using System;

namespace _04FindSubsetInArray
{
    class FindSubsetInArray
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("How big an array would you like to allocate?");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int counter = 1;
            int maxSeq = 0;
            int element = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            // Find subset
            int ii = 0;
            int j = 1;
            if (array.Length > 1)
            {
                while (true)
                {
                    // Compare element with index i, starting from the first element in the array, with all
                    // the elements after it
                    if (array[ii] == array[j])
                    {
                        // Prevents index out of range errors
                        if (j < array.Length - 1)
                        {
                            counter++;
                            j++;
                            continue;
                        }
                        else
                        {
                            counter++;
                        }
                    }

                    // If there are elements in a sequence add the number of elements to maxSeq
                    if (counter > maxSeq)
                    {
                        maxSeq = counter;
                        element = array[ii];
                    }

                    // Prevents index out of range errors
                    if (j >= array.Length - 1)
                    {
                        break;
                    }

                    // If the next element is different, select next element and start again. counter = 1
                    // because it counts the selected element too
                    if (array[ii] != array[j])
                    {
                        // Prevents index out of range errors
                        if (j < array.Length - 1)
                        {
                            ii = j;
                            j++;
                            counter = 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                // Print
                Console.WriteLine("Largest sequence has {0} elements: {1}", maxSeq, element);
            }
            else
            {
                Console.WriteLine("The set has one member... " + array[0]);
            }



        }
    }
}
