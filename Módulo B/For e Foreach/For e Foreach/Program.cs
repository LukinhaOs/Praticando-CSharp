using System;

namespace For_e_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[] { "Maria", "João", "Lucas" };

            Console.WriteLine("Com o for padrão");
            for (int itens = 0; itens < nomes.Length; itens++)
            {
                Console.WriteLine(nomes[itens]);
            }
            Console.WriteLine();
            Console.WriteLine("Com o foreach");


            foreach (string dados in nomes)
            {
                Console.WriteLine(dados);
            }
        }
    }
}