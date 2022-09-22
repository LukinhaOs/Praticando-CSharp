using System;
using System.Collections.Generic;

namespace Listas__Parte_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            nomes.Add("Ariel");
            nomes.Add("Marolina");
            nomes.Add("Lucas");
            nomes.Add("Mriana");
            nomes.Insert(2, "José");

            Console.WriteLine("Nomes");
            Console.WriteLine();
            foreach (string dados in nomes)
            {
                Console.WriteLine(dados);
            }
            Console.WriteLine();
            Console.WriteLine($"Quantidade de pessoas {nomes.Count}");

            // EXPRESSÃO LAMBDA  | string encontre = nomes.Find(x => x[0] == 'A') |

            string encontre = nomes.Find(Teste);
            Console.WriteLine($"Primeira pessoa que tem a letra A {encontre}");

            string encontrar = nomes.FindLast(x => x[0] == 'A');
            Console.WriteLine($"A última pessoa que tem a letra A {encontrar}");

            int posicao1 = nomes.FindIndex(x => x[0] == 'C');
            Console.WriteLine($"Posição começando com 'C' {posicao1} posição");

            int posicao2 = nomes.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Último elemento com a letra 'A'. Sua posição é: {posicao2}");

            List<string> nomes2 = nomes.FindAll(x => x.Length >= 5);
            Console.WriteLine("----------------------");
            foreach (string dados in nomes2)
            {
                Console.WriteLine(dados);
            }

            // RemoveAt(3) <---- Irá remover o item do elemento 3. 

            nomes2.Remove("Carolina");
            Console.WriteLine("----------------------");
            Console.WriteLine("A Carolina saiu!");
            foreach (string dados in nomes2)
            {
                Console.WriteLine(dados);
            }

            nomes.RemoveRange(2, 2);
            Console.WriteLine("----------------------");
            foreach (string obj in nomes2)
            {
                Console.WriteLine(obj);
            }

        }
            static bool Teste(string vd)
        {
            return vd[0] == 'A';
        }
    }
}