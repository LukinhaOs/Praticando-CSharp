using System;
using System.IO;
using System.Collections.Generic;

namespace Exercício_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o diretório do arquivo para leitura dos votos. Ex[C:\'Users\'Teste\'Arquivos.txt]: ");
            string trilha = Console.ReadLine();

            try
            {
                Dictionary<string, int> canditatos = new Dictionary<string, int>();

                using (StreamReader ler = File.OpenText(trilha))
               
                {
                    while (!ler.EndOfStream)
                    {
                        string[] dados = ler.ReadLine().Split(',');
                        string candidato = dados[0];
                        int votos = int.Parse(dados[1]);
                        if (canditatos.ContainsKey(candidato))
                        {
                            canditatos[candidato] += votos;
                        }
                        else
                        {
                            canditatos[candidato] = votos;
                        }
                    }
                    foreach (var itens in canditatos)
                    {
                        Console.WriteLine(itens.Key + " - " + itens.Value);
                    }
                }
            }
            catch (IOException error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
