using System;

namespace Calculator2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("-----------------");

            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the operator (+, -, *, or /): ");
            char op = char.Parse(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Error: Cannot divide by zero.");
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    break;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
