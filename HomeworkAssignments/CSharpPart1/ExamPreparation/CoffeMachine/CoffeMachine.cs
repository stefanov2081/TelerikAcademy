using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    class CoffeMachine
    {
        static void Main(string[] args)
        {
            decimal[] trays = new decimal[5];
            decimal[] traysInHundreds = new decimal[5];
            decimal sumInTrays = 0;
            for (int i = 0; i < 5; i++)
            {
                trays[i] = decimal.Parse(Console.ReadLine());
            }
            

            decimal amount = decimal.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            traysInHundreds[0] = trays[0] * 0.05m;
            traysInHundreds[1] = trays[1] * 0.10m;
            traysInHundreds[2] = trays[2] * 0.20m;
            traysInHundreds[3] = trays[3] * 0.50m;
            traysInHundreds[4] = trays[4] * 1;

            for (int i = 0; i < 5; i++)
            {
                sumInTrays += traysInHundreds[i];
            }

            decimal change = (amount - price);

            if ((amount >= price) && (change <= sumInTrays))
            {
                Console.WriteLine("Yes {0:F2}", (sumInTrays - change));
            }

            else if ((amount > price) && (change >= sumInTrays))
            {
                Console.WriteLine("No {0:F2}", ((sumInTrays - change) * -1));
            }

            else if (price > amount)
            {
                Console.WriteLine("More {0:F2}", (price - amount));
            }

            
        }
    }
}
