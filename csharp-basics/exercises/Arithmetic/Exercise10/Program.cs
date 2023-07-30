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

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Geometry Calculator:");

            int choice;
            do
            {
                Console.WriteLine("1. Calculate the Area of a Circle");
                Console.WriteLine("2. Calculate the Area of a Rectangle");
                Console.WriteLine("3. Calculate the Area of a Triangle");
                Console.WriteLine("4. Quit");

                Console.Write("Enter your choice (1-4): ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
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
                        break;

                    case 2:
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
                        break;

                    case 3:
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
    }
}
