using System;
using System.IO;

namespace Directory_e_Directory_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\LucasSilva-AfixCode\Documents\Programação_CSharp\Módulo C\Directory e Directory Info\Directory e Directory Info";

            try
            {
                var pastas = Directory.EnumerateDirectories(caminho, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Pastas criadas");
                foreach (string itens in pastas)
                {
                    Console.WriteLine(itens);
                }

                Console.WriteLine("");
                Console.WriteLine("");

                var arquivos = Directory.EnumerateFiles(caminho, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Arquivos criados");
                foreach (string itens in arquivos)
                {
                    Console.WriteLine(itens);
                }

                Directory.CreateDirectory(caminho + @"\PastaNova");
            }
            catch (IOException error)
            {
                Console.WriteLine("Ops! Ocorreu um erro :/");
                Console.WriteLine(error.Message);
            }


        }
    }
}
