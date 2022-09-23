using System;
using System.Globalization;

namespace Orientação_a_Objeto._2
{
    class Program
    {
        static void Main(string[] args)
        {

            // ORIENTAÇÃO A OBJETO COM TO STRING (Object e To String)


            Produto p = new Produto();

            Console.WriteLine("Informe os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Informe o preço do produto R$");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Agora informe a quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {p}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            Console.Write($"Dados atualizados: {p}");
            Console.WriteLine();

            Console.Write("Deseja remover produtos do estoque? Digite um valor: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.Write($"Dados atualizados: {p}");
            Console.WriteLine();
        }
    }
}
