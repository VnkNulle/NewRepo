using System;

namespace CalculateArea
{
    class Geometry
    {
        public static double CalculateCircleArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Error: Radius cannot be negative.");
            }

            return Math.PI * radius * radius;
        }

        public static double CalculateRectangleArea(double length, double width)
        {
            if (length < 0 || width < 0)
            {
                throw new ArgumentException("Error: Length and width cannot be negative.");
            }

            return length * width;
        }

        public static double CalculateTriangleArea(double baseLength, double height)
        {
            if (baseLength < 0 || height < 0)
            {
                throw new ArgumentException("Error: Base length and height cannot be negative.");
            }

            return 0.5 * baseLength * height;
        }
    }
}
