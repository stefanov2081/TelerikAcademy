using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10AddBonusScores
{
    class AddBonusScores
    {
        static void Main(string[] args)
        {
            // Get value from user input.
            Console.WriteLine("Enter integer from 1 to 9 to get a bonus.");
            string choice = Console.ReadLine();
            int n;
            int.TryParse(choice, out n);

            
            // Switch to case from 1 to 9. Else convert to string and give error message.
            switch (n)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(n + " gives you a bonus of " + (n * 10));
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(n + " gives you a bonus of " + (n * 100));
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(n + " gives you a bonus of " + (n * 1000));
                    break;
                default:
                    Console.WriteLine("Error. Please enter integer from 1 to 9.");
                    break;
            }
        }
    }
}
