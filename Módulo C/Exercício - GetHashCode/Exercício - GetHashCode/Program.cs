using System;
using System.Collections.Generic;
using System.IO;
using Exercício___GetHashCode.Entidades;

namespace Exercício___GetHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<RelatorioLog> set = new HashSet<RelatorioLog>();

            Console.Write("Informe o local do arquivo, ex c:'\'pastamae'\'pastafilha'\'arquivo.txt: ");
            string trilha = Console.ReadLine();

            try
            {
                using (StreamReader leitor = new StreamReader(trilha))
                {
                    while (!leitor.EndOfStream)
                    {
                        string[] linha = leitor.ReadLine().Split(' ');
                        string username = linha[0];
                        DateTime instante = DateTime.Parse(linha[1]);
                        set.Add(new RelatorioLog(username, instante));
                    }
                    Console.WriteLine("Total de usuários: " + set.Count);
                }
            }
            catch (IOException error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
