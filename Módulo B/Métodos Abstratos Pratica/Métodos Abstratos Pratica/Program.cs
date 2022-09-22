using System;
using System.Collections.Generic;
using System.Globalization;
using Métodos_Abstratos_Pratica.Entities.Enums;
using Métodos_Abstratos_Pratica.Entities;
using Type = Métodos_Abstratos_Pratica.Entities.Enums.Type;

namespace Métodos_Abstratos_Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Totally> menu = new List<Totally>();

            Console.Write("Enter number of foods that you want: ");
            int number = int.Parse(Console.ReadLine());

            for (int itens = 1; itens <= number; itens++)
            {
                Console.WriteLine($"Order number {number}°...");
                Console.Write("Order B (Salty) or C (Sweet)? ");
                char quiz = char.Parse(Console.ReadLine());
                Console.Write("Confirm Type Food? Salty/Sweet: ");
                Type food = Enum.Parse<Type>(Console.ReadLine());
                if (quiz == 'B')
                {
                    Console.Write("Food Price $");
                    double priceB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantities: ");
                    int quantyB = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Filling? ");
                    string filling = Console.ReadLine();
                    menu.Add(new Salty(priceB, quantyB, filling, food));
                }
                else
                {
                    Console.Write("Food Price $");
                    double priceC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantities: ");
                    int quantyC = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Cover? ");
                    string cover = Console.ReadLine();
                    menu.Add(new Sweets(priceC, quantyC, cover, food));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Order Account");
            foreach (Totally foods in menu)
            {
                Console.WriteLine("Totally price $" + foods.FinalPrice().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
