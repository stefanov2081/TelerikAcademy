using System;

namespace _035FallDown
{
    class FallDown
    {
        static void Main(string[] args)
        {
            int[] n = new int[9];
            n[0] = 0;

            for (int i = 1; i < n.Length; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 1; j < n.Length; j++)
            {
                for (int i = n.Length - 1; i > 1; i--)
                {
                    n[0] = n[i];
                    n[i] = n[i] | n[i - 1];
                    n[i - 1] = n[i - 1] & n[0];
                }
            }

            for (int i = 1; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
        }
    }
}
