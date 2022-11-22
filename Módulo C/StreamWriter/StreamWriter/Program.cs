using System;
using System.IO;


namespace Frases_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fonte = @"C:\Users\LucasSilva-AfixCode\Documents\Programação_CSharp\Módulo C\StreamWriter\StreamWriter\Adicionando Frases.txt";
            string destino = @"C:\Users\LucasSilva-AfixCode\Documents\Programação_CSharp\Módulo C\StreamWriter\StreamWriter\Adicionando Frases_2.0.txt";


            try
            {
                string[] linhas = File.ReadAllLines(fonte);
                using (StreamWriter sw = File.AppendText(destino))
                {
                    foreach (String linha in linhas)
                    {
                        sw.WriteLine(linha.ToUpper());
                    }
                }
            }
            catch (IOException error)
            {
                Console.Write("Ocorreu um erro :/ ");
                Console.WriteLine(error.Message);
            }
        }
    }
}
