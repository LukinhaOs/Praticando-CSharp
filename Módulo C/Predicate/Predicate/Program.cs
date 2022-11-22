using System;
using System.Collections.Generic;
using Predicate.Entidades;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto("Smart TV Samsung 4k", 2678.00));
            lista.Add(new Produto("Xbox Series X", 2889.00));
            lista.Add(new Produto("Geladeira Panasonic", 5650.00));
            lista.Add(new Produto("Headset Dragon RGB", 328.00));

            lista.RemoveAll(PrecoConditional);
            foreach (Produto p in lista)
            {
                Console.WriteLine(p);
            }

        }
        public static bool PrecoConditional(Produto p)
        {
            return p.Preco >= 2800.0;
        }
    }
}
