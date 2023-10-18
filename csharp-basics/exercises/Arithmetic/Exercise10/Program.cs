using System;

namespace CalculateArea
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Geometry Calculator:");

            int choice;
            do
            {
                ShowMenu();
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CalculateCircleArea();
                        break;

                    case 2:
                        CalculateRectangleArea();
                        break;

                    case 3:
                        CalculateTriangleArea();
                        break;

                    case 4:
                        Console.WriteLine("Exiting the program.");
                        break;

                    default:
                        Console.WriteLine("Error: Invalid choice. Please enter a number from 1 to 4.");
                        break;
                }

                Console.WriteLine();
            } while (choice != 4);
        }

        static void ShowMenu()
        {
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit");

            Console.Write("Enter your choice (1-4): ");
        }

        static void CalculateCircleArea()
        {
            Console.Write("Enter the radius of the circle: ");
            double circleRadius = double.Parse(Console.ReadLine());

            try
            {
                double circleArea = Geometry.CalculateCircleArea(circleRadius);
                Console.WriteLine($"The area of the circle is: {circleArea:F2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void CalculateRectangleArea()
        {
            Console.Write("Enter the length of the rectangle: ");
            double rectangleLength = double.Parse(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            double rectangleWidth = double.Parse(Console.ReadLine());

            try
            {
                double rectangleArea = Geometry.CalculateRectangleArea(rectangleLength, rectangleWidth);
                Console.WriteLine($"The area of the rectangle is: {rectangleArea:F2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void CalculateTriangleArea()
        {
            Console.Write("Enter the base length of the triangle: ");
            double triangleBase = double.Parse(Console.ReadLine());

            Console.Write("Enter the height of the triangle: ");
            double triangleHeight = double.Parse(Console.ReadLine());

            try
            {
                double triangleArea = Geometry.CalculateTriangleArea(triangleBase, triangleHeight);
                Console.WriteLine($"The area of the triangle is: {triangleArea:F2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
