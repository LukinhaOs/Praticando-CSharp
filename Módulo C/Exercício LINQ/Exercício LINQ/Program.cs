using System;
using System.Collections.Generic;
using Exercício_LINQ.Entidades;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Exercício_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o diretório do arquivo: ");
            string trilha = Console.ReadLine();

            List<Produto> lista = new List<Produto>();

            using (StreamReader leitor = File.OpenText(trilha))
            {
                while (!leitor.EndOfStream)
                {
                    string[] campos = leitor.ReadLine().Split(',');
                    string nome = campos[0];
                    double preco = double.Parse(campos[1], CultureInfo.InvariantCulture);
                    lista.Add(new Produto(nome, preco));
                }
            }

            var avg = lista.Select(p => p.Preco).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Preço médio R$" + avg.ToString("F2", CultureInfo.InvariantCulture));

            var nomes = lista.Where(p => p.Preco < avg).OrderByDescending(p => p.Nome).Select(p => p.Nome);
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
