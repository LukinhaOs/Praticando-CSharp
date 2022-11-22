using System;
using System.IO;

namespace File_e_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string fonteArquivo = @"C:\Users\LucasSilva-AfixCode\Documents\Programação_CSharp\Módulo C\File e FileInfo\File e FileInfo\Files\file.txt";
            string destinoArquivo = @"C:\Users\LucasSilva-AfixCode\Documents\Programação_CSharp\Módulo C\File e FileInfo\File e FileInfo\Files\file_copy.text";
            
            try
            {
                FileInfo arquivo = new FileInfo(fonteArquivo);
                arquivo.CopyTo(destinoArquivo);
                string[] linhas = File.ReadAllLines(fonteArquivo);
                Console.WriteLine("Mensagens que contem no arquivo.");
                Console.WriteLine("");
                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            catch (IOException error)
            {
                Console.WriteLine("Ocorreu um erro! ");
                Console.WriteLine(error.Message);
            }
        }
    }
}
