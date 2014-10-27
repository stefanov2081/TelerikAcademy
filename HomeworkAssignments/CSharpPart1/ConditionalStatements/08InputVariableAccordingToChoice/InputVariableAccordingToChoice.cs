using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08InputVariableAccordingToChoice
{
    class InputVariableAccordingToChoice
    {
        static void Main(string[] args)
        {
            // Get value from user input.
            Console.WriteLine("You can choose what kind of variable to use." + 
                "\nEnter 1 for integer, 2 for double and 3 for string");
            byte userChoice = byte.Parse(Console.ReadLine());

            // Get value from user input, according to user choice and print value.
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("You have selected option 1." + "\nEnter integer.");
                    int userChoice1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(userChoice1 + " + 1 = " + (userChoice1 + 1));
                    break;
                case 2:
                    Console.WriteLine("You have selected option 2." + "\nEnter double.");
                    double userChoice2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(userChoice2 + " + 1 = " + (userChoice2 + 1));
                    break;
                case 3:
                    Console.WriteLine("You have selected option 3." + "\nEnter string.");
                    string userChoice3 = Console.ReadLine();
                    Console.WriteLine(userChoice3 + " + * = " + userChoice3 + "*");
                    break;
            }

        }
    }
}
