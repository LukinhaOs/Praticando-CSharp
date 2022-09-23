using System;
using System.Globalization;

namespace Contrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ORIENTAÇÃO A OBJETO COM TO STRING (Object e To String)
            MAIS CONTRUTORES E SOBRECARGA  E SINTAXE ALTERNATIVA*/

            Console.WriteLine("Informe os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Informe o preço do produto R$");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p2 = new Produto(); // É possível de instanciar outro valor caso crie um construtor padrão sem nada!

            Produto P3 = new Produto { Nome = "TV", Preco = 750.00, Quantidade = 1 };

            Produto p = new Produto(nome, preco);

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
