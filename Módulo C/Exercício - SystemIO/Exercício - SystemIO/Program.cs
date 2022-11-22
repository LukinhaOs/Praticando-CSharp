using System;
using System.IO;
using System.Globalization;


namespace Exercício___SystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("Formatação de Arquivos com a biblioteca System 'IO''");
            Console.WriteLine("====================================================");
            Console.WriteLine();

            Console.WriteLine("Digite um diretório do arquivo a partir da pasta 'Documents' com a extensão");
            Console.WriteLine("Exemplo - Documents - FotoMinha.png");
            string fonteArquivo = Console.ReadLine();

            try
            {
                string[] linhas = File.ReadAllLines(fonteArquivo);

                string pastaCaminho = Path.GetDirectoryName(fonteArquivo);
                string pastaDestino = pastaCaminho + @"\out - ";
                string arquivoPasta = pastaDestino + @"sumário.csv";

                Directory.CreateDirectory(pastaDestino);

                using (StreamWriter sw = File.AppendText(arquivoPasta))
                {
                    foreach (string line in linhas)
                    {
                        string[] campos = line.Split(',');
                        string nome = campos[0];
                        double preco = double.Parse(campos[1], CultureInfo.InvariantCulture);
                        int quantidade = int.Parse(campos[2]);

                        Produto dados = new Produto(nome, preco, quantidade);

                        sw.WriteLine("dados.Nome");
                    }
                }
            }
            catch (IOException error)
            {
                Console.WriteLine($"Ops! Oocrreu um erro :/ {error.Message}");
            }
        }
    }
}
