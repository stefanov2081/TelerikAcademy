using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06IsFemale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you female? Enter \"true\" or \"false\"!");
            bool isFemale = bool.Parse(Console.ReadLine());
            if (isFemale == true)
            {
                Console.WriteLine("Did you know that in almost every country worldwide, the life expectancy for \nwomen is higher than for men.");
            }
            else
            {
                Console.WriteLine("Did you know that hormone changes linked to competition in bonobos and \nchimpanzees mirror those in human males vying for, say, mates or status.");
            }
        }
    }
}
