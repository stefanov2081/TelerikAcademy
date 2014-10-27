using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int tomatoAmount = int.Parse(Console.ReadLine());
            int tomatoArea = int.Parse(Console.ReadLine());
            int cucumberAmount = int.Parse(Console.ReadLine());
            int cucumberArea = int.Parse(Console.ReadLine());
            int potatoAmount = int.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine());
            int carrotAmount = int.Parse(Console.ReadLine());
            int carrotArea = int.Parse(Console.ReadLine());
            int cabbageAmount = int.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine());
            int beansAmount = int.Parse(Console.ReadLine());

            float tomatoPrice = tomatoAmount * 0.5f;
            float cucumberPrice = cucumberAmount * 0.4f;
            float potatoPrice = potatoAmount * 0.25f;
            float carrotPrice = carrotAmount * 0.6f;
            float cabbagePrice = cabbageAmount * 0.3f;
            float beansPrice = beansAmount * 0.4f;
            float totalCost = tomatoPrice + cucumberPrice + potatoPrice + carrotPrice + cabbagePrice + beansPrice;

            int totalArea = 250 - tomatoArea - cucumberArea - potatoArea - carrotArea - cabbageArea;

            Console.WriteLine("Total costs: {0:F2}", totalCost);

            if (totalArea > 0)
            {
                Console.WriteLine("Beans area: " + totalArea);
            }
            else if (totalArea == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Insufficient area");
            }
        }
    }
}
