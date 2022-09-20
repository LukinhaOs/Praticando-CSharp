using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_OutputCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador_Windows10";
            string produto2 = "Mesa de escritório";
            string produto3 = "Kit Mouse + Teclado";

            byte idade = 48;
            int codigo = 2569;
            char genero = 'M';
            double preco1 = 2250.85;
            double preco2 = 450.25;
            double preco3 = 122.25;
            double media = 53.234567;

            Console.WriteLine("Informações Adicionas: ");
            Console.WriteLine();
            Console.WriteLine($"Preços: {produto1} R${preco1}, {produto2} R${preco2} e {produto3} R${preco3} | Média {media}");

            Console.WriteLine("Registo: ");
            Console.WriteLine();
            Console.WriteLine($"{idade} anos, código: {codigo} e genêro: {genero}");
            Console.WriteLine("Informações Complementares: ");
            Console.WriteLine();
            Console.WriteLine($"Média com 8 casas decimais: {media}");
            Console.WriteLine($"Arredondado com 3 casas: {media:F3}");
            Console.WriteLine($"Invariante Culture: ({media:F2}", CultureInfo.InvariantCulture);

        }
    }
}
