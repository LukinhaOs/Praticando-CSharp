using System;
using System.IO;

namespace FileStream_e_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\LucasSilva-AfixCode\Documents\Programação_CSharp\Módulo C\FileStream e StreamReader\FileStream e StreamReader\Arquivos\TextFile1.txt";

            StreamReader leitor = null;

            try
            {
                leitor = File.OpenText(caminho);
                while (!leitor.EndOfStream)
                {
                    string linha = leitor.ReadLine();
                    Console.WriteLine(linha);
                }
            }
            catch (IOException error)
            {
                Console.WriteLine("Ocorrue um erro.");
                Console.WriteLine(error.Message);
            }
            finally
            {
                if (leitor != null) leitor.Close();
            }
        }
    }
}
