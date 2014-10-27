using System;

namespace _01ProperNaming
{
    public class Size
    {
        public double Width {get; set;}
        public double Height { get; set; }
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public static Size GetRotatedSize(Size size, double rotatedFigureAngle)
        {
            double cosWidthSize = Math.Abs(Math.Cos(rotatedFigureAngle)) * size.Width;
            double sinHeightSize = Math.Abs(Math.Sin(rotatedFigureAngle)) * size.Height;
            double sinWidthSize = Math.Abs(Math.Sin(rotatedFigureAngle)) * size.Width;
            double cosHeightSize = Math.Abs(Math.Cos(rotatedFigureAngle)) * size.Height;
            double widthSize = cosWidthSize + sinHeightSize;
            double heightSize = sinWidthSize + cosHeightSize;
            return new Size(widthSize, heightSize);
        }
    }
}
