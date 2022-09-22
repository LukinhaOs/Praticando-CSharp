using System;
using Métodos_Abstratos.Entities;
using Métodos_Abstratos.Entities.Enums;
using System.Globalization;
using System.Collections.Generic;

namespace Métodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> itens = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Figure Shape number {i}°: ");
                Console.Write("Rectangle or Circle? C/R: ");
                char quiz = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Colors color = Enum.Parse<Colors>(Console.ReadLine());
                if (quiz == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    itens.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    itens.Add(new Circle(radius, color));
                }

                Console.WriteLine();
            }
            Console.WriteLine("SHAPE AREAS");
            foreach (Shape figure in itens)
            {
                Console.WriteLine(figure.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
