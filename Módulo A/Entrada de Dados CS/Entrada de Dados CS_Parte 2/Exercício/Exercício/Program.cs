using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício

            Console.WriteLine("Digite seu nome completo: ");
            string name = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de comodos da sua casa: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço do produto R$");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine($"Seja Bem-Vindo(a) {name} !");
            Console.WriteLine($"{name} {idade} anos, possui {quantidade} comodos em sua casa");
            Console.WriteLine($"Preço do produto R${preco:F2}");

            // Variável com vetores

            string[] dados = Console.ReadLine().Split(' ');
            string nome = dados[0];
            int id = int.Parse(dados[1]);
            double alt = double.Parse(dados[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Primeira info: " + nome);
            Console.WriteLine("Segunda info: " + id);
            Console.WriteLine("Terceira info: " + alt);
        }
    }
}
