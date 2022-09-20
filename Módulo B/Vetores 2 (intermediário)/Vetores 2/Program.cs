using System;
using System.Globalization;

namespace Vetores_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            ValorDoProduto[] vetores = new ValorDoProduto[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome do Produto: ");
                string name = Console.ReadLine();
                Console.Write($"Preço do(a) {name} R$");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetores[i] = new ValorDoProduto { Name = name, Price = price };
                Console.WriteLine("Produto Inserido!");
                Console.WriteLine();
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma = vetores[i].Price;
            }

            double avg = soma / n;

            Console.WriteLine($"Preço médio {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}