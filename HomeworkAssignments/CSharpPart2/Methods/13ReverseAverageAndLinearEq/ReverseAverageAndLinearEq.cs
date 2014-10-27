using System;

namespace _13ReverseAverageAndLinearEq
{
    class ReverseAverageAndLinearEq
    {
        // Reverse digits of a number
        static string Reverse(int a)
        {
            string temp = "";
            while (a != 0)
            {
                temp += (a % 10).ToString();
                a = a / 10;
            }

            return temp;
        }

        // Average of set of integers
        static decimal Average(int[] a)
        {
            decimal result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result = result + a[i];
            }

            result = result / a.Length;

            return result;
        }

        // Solve linear equation
        static string LinearEq(decimal a, decimal b, decimal c)
        {
            decimal x;
            if (a == 0 && b != 0)
            {
                return "There is no solution";
            }
            else if (b > 0)
            {
                c = c - b;
                x = c / a;
            }
            else
            {
                c = c + b;
                x = c / a;
            }
            
            return x.ToString();
        }

        static void Main(string[] args)
        {
            int n;
            string set;
            string input = "";
            while (input != "exit")
            {
                Console.WriteLine(new string('_', 80));
                Console.WriteLine("Menu");
                Console.WriteLine("You can solve three different problems:\nReverse the digits of a number --> type: reverse" +
                    "\nFind the average in a set --> type: average" +
                    "\nSolve a linear equation --> type: linear" +
                    "\nTo exit --> type: exit");
                Console.Write("Input: ");
                input = Console.ReadLine();

                if (input == "reverse")
                {
                    Console.WriteLine(new string('_', 80));
                    Console.WriteLine("Reverse the digits of a number");
                    Console.Write("Enter number: ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Reversed: " + Reverse(n));
                }
                else if (input == "average")
                {
                    Console.WriteLine(new string('_', 80));
                    Console.WriteLine("Find average in set");
                    Console.WriteLine("How large is your set?");
                    set = Console.ReadLine();
                    bool valid;
                    valid = int.TryParse(set, out n);
                    if (valid == false)
                    {
                        Console.WriteLine("The sequence must not be empty and it must contains only numerical characters");
                    }
                    if (valid == true)
                    {
                        int[] array = new int[n];

                        for (int i = 0; i < n; i++)
                        {
                            valid = false;
                            Console.WriteLine("Enter element " + (i + 1));
                            set = Console.ReadLine();
                            valid = int.TryParse(set, out array[i]);
                            if (valid == false)
                            {
                                Console.WriteLine("The sequence must not be empty and it must contains only numerical characters");
                                break;
                            }
                        }
                        Console.WriteLine("Average: " + Average(array));
                    }
                }
                else if (input == "linear")
                {
                    Console.WriteLine(new string('_', 80));
                    Console.WriteLine("Solve linear equation");
                    Console.Write("Enter a: ");
                    int a = int.Parse(Console.ReadLine());
                    if (a == 0)
                    {
                        Console.WriteLine("a must be different from zero !");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Enter b: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Enter c: ");
                        int c = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("{0}x + {1} = {2}", a, b, c);
                        Console.WriteLine("x = " + LinearEq(a, b, c));
                    }
                }
            }
        }
    }
}
