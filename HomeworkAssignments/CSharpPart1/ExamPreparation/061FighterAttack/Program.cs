using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _061FighterAttack
{
    class Program
    {
        static void Main(string[] args)
        {
            int pX1 = int.Parse(Console.ReadLine());
            int pY1 = int.Parse(Console.ReadLine());
            int pX2 = int.Parse(Console.ReadLine());
            int pY2 = int.Parse(Console.ReadLine());
            int fX = int.Parse(Console.ReadLine());
            int fY = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int damage = 0;

            // From left to right
            if (pX1 <= pX2)
            {
                // From top to bottom
                if (pY1 >= pY2)
                {
                    // Rocket hit
                    if (((fX + d) >= pX1) && ((fX + d) <= pX2))
                    {
                        if ((fY <= pY1) && (fY >= pY2))
                        {
                            damage += 100;
                        }
                        // Splash damage - north
                        if (((fY + 1) <= pY1) && ((fY + 1) >= pY2))
                        {
                            damage += 50;
                        }
                        // Splash damage - south
                        if (((fY - 1) <= pY1) && ((fY - 1) >= pY2))
                        {
                            damage += 50;
                        }
                    }
                    // Splash damage - east
                    if (((fX + d + 1) >= pX1) && ((fX + d + 1) <= pX2))
                    {
                        if ((fY <= pY1) && (fY >= pY2))
                        {
                            damage += 75;
                        }
                    }
                }
                // From bottom to top
                else if (pY1 <= pY2)
                {
                    // Rocket hit
                    if (((fX + d) >= pX1) && ((fX + d) <= pX2))
                    {
                        if ((fY >= pY1) && (fY <= pY2))
                        {
                            damage += 100;
                        }
                        // Splash damage - north
                        if (((fY + 1) >= pY1) && ((fY + 1) <= pY2))
                        {
                            damage += 50;
                        }
                        // Splash damage - south
                        if (((fY - 1) >= pY1) && ((fY - 1) <= pY2))
                        {
                            damage += 50;
                        }
                    }
                    // Splash damage - east
                    if (((fX + d + 1) >= pX1) && ((fX + d + 1) <= pX2))
                    {
                        if ((fY >= pY1) && (fY <= pY2))
                        {
                            damage += 75;
                        }
                    }
                }
            }
            // From right to left
            else if (pX1 >= pX2)
            {
                // From top to bottom
                if (pY1 >= pY2)
                {
                    // Rocket hit
                    if (((fX + d) <= pX1) && ((fX + d) >= pX2))
                    {
                        if ((fY <= pY1) && (fY >= pY2))
                        {
                            damage += 100;
                        }
                        // Splash damage - north
                        if (((fY + 1) <= pY1) && ((fY + 1) >= pY2))
                        {
                            damage += 50;
                        }
                        // Splash damage - south
                        if (((fY - 1) <= pY1) && ((fY - 1) >= pY2))
                        {
                            damage += 50;
                        }
                    }
                    // Splash damage - east
                    if (((fX + d + 1) <= pX1) && ((fX + d + 1) >= pX2))
                    {
                        if ((fY <= pY1) && (fY >= pY2))
                        {
                            damage += 75;
                        }
                    }
                }
                // From bottom to top
                else if (pY1 <= pY2)
                {
                    // Rocket hit
                    if (((fX + d) <= pX1) && ((fX + d) >= pX2))
                    {
                        if ((fY >= pY1) && (fY <= pY2))
                        {
                            damage += 100;
                        }
                        // Splash damage - north
                        if (((fY + 1) >= pY1) && ((fY + 1) <= pY2))
                        {
                            damage += 50;
                        }
                        // Splash damage - south
                        if (((fY - 1) >= pY1) && ((fY - 1) <= pY2))
                        {
                            damage += 50;
                        }
                    }
                    // Splash damage - east
                    if (((fX + d + 1) <= pX1) && ((fX + d + 1) >= pX2))
                    {
                        if ((fY >= pY1) && (fY <= pY2))
                        {
                            damage += 75;
                        }
                    }
                }
            }
            Console.WriteLine(damage + "%");
        }
    }
}
