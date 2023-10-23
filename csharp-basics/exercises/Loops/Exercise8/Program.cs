using System;

namespace AsciiFigure
{
    class Program
    {
        const int FigureSize = 5;

        static void Main(string[] args)
        {
            DrawFigure(FigureSize);
        }

        static void DrawFigure(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size * 4 - i * 4 - 4; j++)
                {
                    Console.Write("/");
                }
                for (int j = 0; j < i * 8; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < size * 4 - i * 4 - 4; j++)
                {
                    Console.Write("\\");
                }
                Console.WriteLine();
            }
        }
    }
}
