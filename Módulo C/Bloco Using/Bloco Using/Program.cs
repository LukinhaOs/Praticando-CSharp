using System;
using System.IO;

namespace Bloco_Using
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\LucasSilva-AfixCode\Documents\Programação_CSharp\Módulo C\Bloco Using\Bloco Using\Arquivos Using\TextFile1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(caminho))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException error)
            {
                Console.WriteLine("Um erro ocorreu :/");
                Console.WriteLine(error.Message);
            }
        }
    }
}
