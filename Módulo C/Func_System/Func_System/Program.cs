using System;
using System.Collections.Generic;
using System.Linq;
using Func_System.Entidades;

namespace Func_System
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

            List<string> result = lista.Select(NameSpace).ToList();
            foreach (string itens in result)
            {
                Console.WriteLine(itens);
            }
        }

        static string NameSpace(Produto p)
        {
            return p.Nome.ToUpper();
        }
    }
}
