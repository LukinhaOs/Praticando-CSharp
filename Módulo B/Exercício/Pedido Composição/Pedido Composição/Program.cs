using System;
using System.Globalization;
using Pedido_Composição.Entidades.Enum;
using Pedido_Composição.Entidades;

namespace Pedido_Composição
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu nome e sobrenome: ");
            string clientenome = Console.ReadLine();
            Console.Write("Agora informe o seu e-mail: ");
            string clienteemail = Console.ReadLine();
            Console.Write($"{clientenome}, informe a sua data de Nascimento (dd/mm/yyyy): ");
            DateTime clientebirthay = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Status do pedido: ");
            StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());

            Cliente cliente = new Cliente(clientenome, clienteemail, clientebirthay);
            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            Console.Write("Informe a quantidade de produtos que deseja pedir: ");
            int pedidos = int.Parse(Console.ReadLine());

            for (int itens = 0; itens < pedidos; itens++)
            {
                Console.WriteLine($"Dados do {itens+1}° Produto.");
                Console.Write("Nome do produto: ");
                string produtoNome = Console.ReadLine();
                Console.Write($"Valor do(a) {produtoNome} R$");
                double produtoPreco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto pedidoProduto = new Produto(produtoNome, produtoPreco);

                Console.WriteLine("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                PedidoItem pedidoItem = new PedidoItem(quantidade, produtoPreco, pedidoProduto);

                pedido.AddItem(pedidoItem);
            }

            Console.WriteLine();
            Console.WriteLine(" ---- PEDIDO REALIZADO ---- ");
            Console.WriteLine(pedido);
        }
    }
}
