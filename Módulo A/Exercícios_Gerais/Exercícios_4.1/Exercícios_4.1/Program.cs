using System;

namespace Exercícios_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor inteiro e confira os números ímpares: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Confira os numeros ímpares");
            for (int passo = 1; passo <= numero; passo++)
            {
                if (passo % 2 == 1)
                {
                    Console.WriteLine(passo);
                }
            }
            Console.WriteLine("Contagem finalizada!");
        }
    }
}
