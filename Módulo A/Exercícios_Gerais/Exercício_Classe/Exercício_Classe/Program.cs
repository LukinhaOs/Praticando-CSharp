using System;

namespace Exercício_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Informe os dados a seguir. ");
            Console.Write("Nome da 1° pessoa: ");
            p1.Nome = (Console.ReadLine());
            Console.Write($"Idade do(a) {p1.Nome}: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome da 2° pessoa: ");
            p2.Nome = (Console.ReadLine());
            Console.WriteLine($"Idade do(a) {p2.Nome}: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"{p1.Nome} possui {p1.Idade} anos e é mais velho(a) do que o(a) {p2.Nome}.");
            }
            else
            {
                Console.WriteLine($"{p2.Nome} possui {p2.Idade} anos e é mais velho(a) do que o(a) {p1.Nome}.");
            }
        }
    }
}
