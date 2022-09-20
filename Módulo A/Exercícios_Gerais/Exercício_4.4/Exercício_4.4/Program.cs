using System;

namespace Exercício_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            int multi = 0;

            Console.Write("Informe um número e veja seu fatorial: ");
            valor = int.Parse(Console.ReadLine());
            Console.Write($"Agora informe o tanto de vezes que o número {valor} deve ser multiplicado: ");
            multi = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for (multi = 0; multi <= valor; multi++)
            {
                fatorial = valor * multi;
            }
            Console.Write($"Fatorialde {valor}:  {fatorial}");
        }
    }
}
