using System;

namespace Abstraction
{
    class Circle : Figure
    {
        private double radius;

        public Circle()
            : base()
        {
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        // Zero is left intentionally... imagine that the figure is infinitely small...
        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Figure must have positive width");
                }

                this.radius = value;
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
