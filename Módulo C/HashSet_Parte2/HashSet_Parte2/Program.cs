using System;
using System.Collections.Generic;
using HashSet_Parte2.Entidades;

namespace HashSet_Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  HashSet<string> set = new HashSet<string>();

              set.Add("Maria");
              set.Add("Lucas");

             Console.Write(set.Contains("Lucas")); // O procedimento "Contains" usa o GetHashCode para conferir o valor e o Equals para validar/confirmar */

            HashSet<Produto> teste1 = new HashSet<Produto>();
            teste1.Add(new Produto("Smart TV Samsung", 4200.0));
            teste1.Add(new Produto("XboxSeries S", 1889.0));

            HashSet<Ponto> teste2 = new HashSet<Ponto>();

            teste2.Add(new Ponto(3, 9));
            teste2.Add(new Ponto(10, 5));

            Produto product = new Produto("XboxSeries S", 1889.0);
            Console.WriteLine(teste1.Contains(product));

            Ponto p = new Ponto(3, 9);
            Console.WriteLine(teste2.Contains(p));
        }
    }
}
