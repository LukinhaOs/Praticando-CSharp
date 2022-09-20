using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtocap p = new Produtocap("TV 4K", 2500.00, 10);

            p.SetNome("Nova");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
        }
    }
}
