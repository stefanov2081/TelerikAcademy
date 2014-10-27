using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041ShipDamage
{
    class Program
    {
        static void Main(string[] args)
        {
            int sX1 = int.Parse(Console.ReadLine());
            int sY1 = int.Parse(Console.ReadLine());
            int sX2 = int.Parse(Console.ReadLine());
            int sY2 = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int cX1 = int.Parse(Console.ReadLine());
            int cY1 = int.Parse(Console.ReadLine());
            int cX2 = int.Parse(Console.ReadLine());
            int cY2 = int.Parse(Console.ReadLine());
            int cX3 = int.Parse(Console.ReadLine());
            int cY3 = int.Parse(Console.ReadLine());

            int projectilePosCY1 = h - (cY1) + h;
            int projectilePosCY2 = h - (cY2) + h;
            int projectilePosCY3 = h - (cY3) + h;
            int shipDamage = 0;

            // Projectile 1:
            if ((cX1 == sX1 && projectilePosCY1 == sY1) || (cX1 == sX1 && projectilePosCY1 == sY2) ||
                (cX1 == sX2 && projectilePosCY1 == sY1) || (cX1 == sX2 && projectilePosCY1 == sY2))
            {
                shipDamage += 25;
            }
            if (((cX1 > sX1 && cX1 < sX2) && (projectilePosCY1 == sY1 || projectilePosCY1 == sY2)) ||
                ((cX1 == sX1 || cX1 == sX2) && (projectilePosCY1 < sY1 && projectilePosCY1 > sY2)))
            {
                shipDamage += 50;
            }
            if ((cX1 > sX1 && cX1 < sX2) && (projectilePosCY1 < sY1 && projectilePosCY1 > sY2))
            {
                shipDamage += 100;
            }

            // Projectile 2:
            if ((cX2 == sX1 && projectilePosCY2 == sY1) || (cX2 == sX1 && projectilePosCY2 == sY2) ||
                (cX2 == sX2 && projectilePosCY2 == sY1) || (cX2 == sX2 && projectilePosCY2 == sY2))
            {
                shipDamage += 25;
            }
            if (((cX2 > sX1 && cX2 < sX2) && (projectilePosCY2 == sY1 || projectilePosCY2 == sY2)) ||
                ((cX2 == sX1 || cX2 == sX2) && (projectilePosCY2 < sY1 && projectilePosCY2 > sY2)))
            {
                shipDamage += 50;
            }
            if ((cX2 > sX1 && cX2 < sX2) && (projectilePosCY2 < sY1 && projectilePosCY2 > sY2))
            {
                shipDamage += 100;
            }

            // Projectile 3:
            if ((cX3 == sX1 && projectilePosCY3 == sY1) || (cX3 == sX1 && projectilePosCY3 == sY2) ||
                (cX3 == sX2 && projectilePosCY3 == sY1) || (cX3 == sX2 && projectilePosCY3 == sY2))
            {
                shipDamage += 25;
            }
            if (((cX3 > sX1 && cX3 < sX2) && (projectilePosCY3 == sY1 || projectilePosCY3 == sY2)) ||
                ((cX3 == sX1 || cX3 == sX2) && (projectilePosCY3 < sY1 && projectilePosCY3 > sY2)))
            {
                shipDamage += 50;
            }
            if ((cX3 > sX1 && cX3 < sX2) && (projectilePosCY3 < sY1 && projectilePosCY3 > sY2))
            {
                shipDamage += 100;
            }

            Console.WriteLine(shipDamage +"%");

        }
    }
}
