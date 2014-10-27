using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012MissCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfJudges = int.Parse(Console.ReadLine());
            int[] votes = new int[numberOfJudges];
            int[] cats = new int[10];

            for (int i = 0; i < numberOfJudges; i++)
			{
                votes[i] = int.Parse(Console.ReadLine());

                switch (votes[i])
                {
                    case 1:
                        cats[0]++;
                        break;
                    case 2:
                        cats[1]++;
                        break;
                    case 3:
                        cats[2]++;
                        break;
                    case 4:
                        cats[3]++;
                        break;
                    case 5:
                        cats[4]++;
                        break;
                    case 6:
                        cats[5]++;
                        break;
                    case 7:
                        cats[6]++;
                        break;
                    case 8:
                        cats[7]++;
                        break;
                    case 9:
                        cats[8]++;
                        break;
                    case 10:
                        cats[9]++;
                        break;
                    default:
                        continue;
                }
			}
            int winningVotes = cats.Max();
            int winner = Array.IndexOf(cats, winningVotes);
            Console.WriteLine(winner + 1);
        }
    }
}
