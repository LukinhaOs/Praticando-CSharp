using System;
using Comparision.Entidades;
using System.Collections.Generic;

namespace Comparision
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto("Smart TV Samsung 4k", 3664.00));
            lista.Add(new Produto("Ryzen 5 4500U 3.6GHz", 1011.00));
            lista.Add(new Produto("Geforce RTX 2080 Super", 4289.99));


            Console.WriteLine("--------- LISTA DE ITENS ---------");
            Console.WriteLine("----------------------------------");

            Console.Write("Você deseja agrupar os produtos através de qual catogoria? [P]Produto ou [R]Preço? ");
            string resp = Console.ReadLine().ToUpper();
            Console.WriteLine();

            if (resp == "P")
            {
                lista.Sort((n1, n2) => n1.Nome.ToUpper().CompareTo(n2.Nome.ToUpper()));
            }
            else
            {
                lista.Sort((p1, p2) => p1.Preco.CompareTo(p2.Preco));
            }
            foreach (Produto p in lista)
            {
                Console.WriteLine(p);
            }
        }
    }
}
