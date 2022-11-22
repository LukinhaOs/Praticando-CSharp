using System;
using System.Collections.Generic;
using Restricao_Generic.App_Servico;
using Restricao_Generic.Entidade;
using System.Globalization;

namespace Restricao_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            Console.Write("Entre com um número: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string nome = vect[0];
                double preco = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Produto(nome, preco));
            }

            Calcular calcular = new Calcular();

            Produto max = calcular.Max(list);

            Console.WriteLine("Max: ");
            Console.WriteLine(max);
        }
    }
}
