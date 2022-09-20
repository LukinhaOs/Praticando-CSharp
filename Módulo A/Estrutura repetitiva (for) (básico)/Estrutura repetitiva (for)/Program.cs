using System;

namespace Estrutura_repetitiva__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você digitará? ");
            int numero = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int passo = 1; passo <= numero; passo++)
            {
                Console.Write($"{passo}° Número: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine($"A soma total foi de {soma}");
        }
    }
}
