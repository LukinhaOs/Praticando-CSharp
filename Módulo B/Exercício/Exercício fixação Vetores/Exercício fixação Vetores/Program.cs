using System;

namespace Exercício_fixação_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aluguel de Quartos com Vetores

            Console.Write("Informe a quantidade de quartos a ser alugada: ");
            int qnt = int.Parse(Console.ReadLine());

            Aluguel[] AlugaQuarto = new Aluguel[qnt];

            for (int quantidade = 0; quantidade < qnt; quantidade++)
            {
                Console.Write("Informe o seu nome: ");
                string nome = Console.ReadLine();
                Console.Write($"{nome}, agora informe o seu e-mail: ");
                string email = Console.ReadLine();
                Console.Write("Por último, informe o número do seu quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"{nome} foi cadastrado(a) no quarto número {quarto}");
                Console.WriteLine();
                AlugaQuarto[quantidade] = new Aluguel { Nome = nome, Email = email, Quarto = quarto };
            }

            Console.WriteLine("============================================================");
            Console.WriteLine("Quartos Ocupados (Busy Rooms)");

            for (int pessoa = 0; pessoa < qnt; pessoa++)
            {
                Console.WriteLine();
                Console.WriteLine($"{AlugaQuarto[pessoa].Nome} foi cadastrado(a) no quarto número: {AlugaQuarto[pessoa].Quarto} Contato: {AlugaQuarto[pessoa].Email}");
            }
        }
    }
}