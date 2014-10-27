using System;

namespace _02NamingBestPractices
{
    class Program
    {
        public void PrintStatistics(double[] data, int count)
        {
            double maxNumber = 0;
            double minNumber = 0;
            double average;
            for (int i = 0; i < count; i++)
            {
                if (data[i] > maxNumber)
                {
                    maxNumber = data[i];
                }
            }

            Console.WriteLine(maxNumber);
            average = 0;

            for (int i = 0; i < count; i++)
            {
                if (data[i] < minNumber)
                {
                    minNumber = data[i];
                }
            }

            Console.WriteLine(minNumber);
            average = 0;

            for (int i = 0; i < count; i++)
            {
                average += data[i];
            }

            Console.WriteLine(average / count);
        }


        static void Main(string[] args)
        {
        }
    }
}
