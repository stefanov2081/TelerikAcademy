using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09IsSumFromSubsetEqualToZero
{
    class IsSumFromSubsetEqualToZero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You can find if a subset from a set of 5 integers is equal to zero.");
            int sum = 0;
            // Get value from user input.
            int[] set = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter value for number " + (i + 1));
                set[i] = int.Parse(Console.ReadLine());
            }

            // Loop trough array. If anyone is zero => there is subset equal to zero. k1
            for (int i = 0; i < 5; i++)
            {
                if (set[i] == 0)
                {
                    Console.WriteLine("Input number {0} is a subset that has a value of {1}", 
                        (i + 1), set[i]);
                }
            }

            // Loop through array. If set[0] + set[i] = 0 => there is subset equal to zero. k2,1
            for (int i = 1; i < 5; i++)
            {
                sum = set[0] + set[i];
                if (sum == 0)
                {
                    Console.WriteLine("Sum of {0} + {1} has a value of {2}", set[0], set[i], sum);
                }
            }

            // Loop through array. If set[1] + set[i] = 0 => there is subset equal to zero. k2,2
            for (int i = 2; i < 5; i++)
            {
                sum = set[1] + set[i];
                if (sum == 0)
                {
                    Console.WriteLine("Sum of {0} + {1} has a value of {2}", set[1], set[i], sum);
                }
            }

            // Loop through array. If set[2] + set[i] = 0 => there is subset equal to zero. k2,3
            for (int i = 3; i < 5; i++)
            {
                sum = set[2] + set[i];
                if (sum == 0)
                {
                    Console.WriteLine("Sum of {0} + {1} has a value of {2}", set[2], set[i], sum);
                }
            }

            // Loop through array. If set[3] + set[i] = 0 => there is subset equal to zero. k2,3
            for (int i = 4; i < 5; i++)
            {
                sum = set[3] + set[i];
                if (sum == 0)
                {
                    Console.WriteLine("Sum of {0} + {1} has a value of {2}", set[3], set[i], sum);
                }
            }

            // Loop through array. If set[0] + set[1] + set[i] = 0 => there is subset equal to zero. k3,2
            for (int i = 2; i < 5; i++)
            {
                sum = set[0] + set[1] + set[i];
                if (sum == 0)
                {
                    Console.WriteLine("Sum of {0} + {1} + {2} has a value of {3}",
                        set[0], set[1], set[i], sum);
                }
            }

            // Loop through array. If set[0] + set[2] + set[i] = 0 => there is subset equal to zero. k3,3
            for (int i = 3; i < 5; i++)
            {
                sum = set[0] + set[2] + set[i];
                if (sum == 0)
                {
                    Console.WriteLine("Sum of {0} + {1} + {2} has a value of {3}",
                        set[0], set[2], set[i], sum);
                }
            }

            // Loop through array. If set[0] + set[2] + set[i] = 0 => there is subset equal to zero. k3,4
            for (int i = 4; i < 5; i++)
            {
                sum = set[0] + set[3] + set[i];
                if (sum == 0)
                {
                    Console.WriteLine("Sum of {0} + {1} + {2} has a value of {3}",
                        set[0], set[3], set[i], sum);
                }
            }

            // Loop through array. If set[2] + set[j] + set[i] = 0 => there is subset equal to zero. k3,1,2
            for (int i = 3, j = 2; i < 5; i++, j++)
            {
                sum = set[1] + set[j] + set[i];
                if (sum == 0)
                {
                    Console.WriteLine("Sum of {0} + {1} + {2} has a value of {3}",
                        set[1], set[j], set[i], sum);
                }
            }

            // Loop through array. If set[2] + set[j] + set[i] = 0 => there is subset equal to zero. k4,2
            for (int i = 2; i < 4; i++)
            {
                sum = set[0] + set[1] + set[i] + set[4];
                if (sum == 0)
                {
                    Console.WriteLine("Sum of {0} + {1} + {2} + {3} has a value of {4}",
                        set[0], set[1], set[i], set[4], sum);
                }
            }

            // Three special cases.
            if (set[2] + set[3] + set[4] == 0)
            {
                sum = set[2] + set[3] + set[4];
                Console.WriteLine("Sum of {0} + {1} + {2} has a value of {3}", set[2], set[3], set[4], sum);
            }
            else if (set[1] + set[2] + set[3] + set[4] == 0)
            {
                sum = set[1] + set[2] + set[3] + set[4];
                Console.WriteLine("Sum of {0} + {1} + {2} + {3} has a value of {4}",
                    set[1], set[2], set[3], set[4], sum);
            }
            else if (set[0] + set[1] + set[2] + set[3] == 0)
            {
                sum = set[0] + set[1] + set[2] + set[3];
                Console.WriteLine("Sum of {0} + {1} + {2} + {3} has a value of {4}",
                    set[0], set[1], set[2], set[3], sum);
            }
        }
    }
}
