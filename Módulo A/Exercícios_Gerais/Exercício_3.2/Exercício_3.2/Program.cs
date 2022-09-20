using System;

namespace Exercício_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coordenadas");

            string[] dados = Console.ReadLine().Split(' ');
            int x = int.Parse(dados[0]);
            int y = int.Parse(dados[1]);

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine($"Valores digitados {x} e {y}. Forma crescente!");
                }
                else
                {
                    Console.WriteLine($"Valores digitados {x} e {y}. Forma decrescente");
                }
                dados = Console.ReadLine().Split(' ');
                x = int.Parse(dados[0]);
                y = int.Parse(dados[1]);
            }
        }
    }
}
