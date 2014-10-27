using System;

namespace _14MinMaxAvrgSumProduct
{
    class MinMaxAvrgSumProduct
    {
        // Find smallest element
        static int Min(params int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        // Find largest element
        static int Max(params int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        // Calculate sum
        static int Sum(params int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            return sum;
        }

        // Calculate product
        static decimal Product(params int[] a)
        {
            decimal product = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                product = product * a[i];
            }
            return product;
        }

        // Calculate average
        static decimal Average(params int[] a)
        {
            decimal average;
            decimal sum = Sum(a);
            decimal numOfElements = a.Length;
            average = sum / numOfElements;
            return average;
        }

        static void Main(string[] args)
        {
            // Predefined values
            Console.WriteLine("Smallest element is " + 
                Min(123, 12, 51234, 1231, 51, 123, 421));
            Console.WriteLine("Largest element is " + 
                Max(532, 532, 312,63425, 5413, 12351));
            Console.WriteLine("Sum is " + 
                Sum(1, 3214, 124, 5432, 6432, 123));
            Console.WriteLine("The product of the multiplication is " + 
                Product(123, 421, 4523, 12, 2 , 5, 645));
            Console.WriteLine("Average is " + 
                Average(21, 532, 23, 123, 5124, 632, 123, 21, 5314));
        }
    }
}
