using System;

namespace _04AreaOfTriangle
{
    class AreaOfTriangle
    {
        // Get area by side and height
        static double AreaBySideAndHeight(double side, double height)
        {
            double area = (side * height) / 2;

            return area;
        }

        // Get area by three sides
        static double AreaByThreeSides(double a, double b, double c)
        {
            double semiP = (a + b + c) / 2;
            double area = Math.Sqrt((semiP * (semiP - a) * (semiP - b) * (semiP - c)));

            return area;
        }

        // Get area by two sides and an angle between them
        static double AreaBySidesAndSinus(double a, double b, double angle)
        {
            angle = (Math.PI / 180) * angle;
            double area = (a * b / 2) * Math.Sin(angle);

            return area;
        }

        static void Main(string[] args)
        {
            // Call methods and print
            Console.WriteLine(AreaBySideAndHeight(20, 12));
            Console.WriteLine(AreaByThreeSides(5, 5, 5));
            Console.WriteLine(AreaBySidesAndSinus(7, 10, 25));
        }
    }
}
