using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10VarDescriptiveNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string edit;
            do
            {
                Console.WriteLine("Enter employee first name.");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter employee last name.");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter epmloyee age. Must be numerical!");
                byte age = byte.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee gender. Male or Female.");
                string gender = Console.ReadLine();
                Console.WriteLine("Enter employee ID Number's last four digits. Must be numerical!");
                short iDNumFourDigits = short.Parse(Console.ReadLine());
                int fullIDNum = 27560000 + iDNumFourDigits;
                Console.WriteLine("Employee record" + "\n" + "..............." + "\n" + "Name: " + firstName + " " + lastName + "\n" + "Age: " + age + "\n" + "Gender " + gender + "\n" + "ID Number: " + fullIDNum + "\n" + "...............");
                Console.WriteLine("Is this information correct? \nDo you want to edit it? \nEnter \"yes\" - It is correct, or \"no\" - No it is incorrect, I want to edit it.");
                edit = Console.ReadLine();
            }
            while (edit == "no");
        }
    }
}
