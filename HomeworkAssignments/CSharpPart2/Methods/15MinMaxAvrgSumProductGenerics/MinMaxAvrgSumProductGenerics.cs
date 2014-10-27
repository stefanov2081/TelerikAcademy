using System;

namespace _15MinMaxAvrgSumProductGenerics
{
    class MinMaxAvrgSumProductGenerics
    {
        // Find smallest element
        static T Min<T>(params T[] a)
        {
            dynamic min = a[0];
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
        static T Max<T>(params T[] a)
        {
            dynamic max = a[0];
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
        static T Sum<T>(params T[] a)
        {
            dynamic sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            return sum;
        }

        // Calculate product
        static T Product<T>(params T[] a)
        {
            dynamic product = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                product = product * a[i];
            }
            return product;
        }

        // Calculate average
        static T Average<T>(params T[] a)
        {
            dynamic average;
            dynamic sum = Sum(a);
            dynamic numOfElements = a.Length;
            average = sum / numOfElements;
            return average;
        }

        static void Main(string[] args)
        {
            // Predefined values
            Console.WriteLine("Smallest element is " + 
                Min(1, 2, 3, 4, 5, 6, 7));
            Console.WriteLine("Largest element is " + 
                Max(44721, 4218321, 321763721638216, 213213217321, 538749812));
            Console.WriteLine("Sum is " + 
                Sum(-123, 4321421, -32167890, 4213421, 53290142, -4321421));
            Console.WriteLine("The product of the multiplication is " + 
                Product(133.21421, 543.643, -1532.654654, 0.4532, 2342, 12));
            Console.WriteLine("Average is " + 
                Average(1, 12.43, -453, 579320402, -467324812, 234352.47218472819));
        }
    }
}
