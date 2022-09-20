using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_de_Dados_CS_Parte_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------ PARTE 2 -----------------

            int n1 = int.Parse(Console.ReadLine());
            char caractere = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] caixa = Console.ReadLine().Split(' ');
            string nome = caixa[0];
            char sexo = char.Parse(caixa[1]);
            int idade = int.Parse(caixa[2]);
            double altura = double.Parse(caixa[3], CultureInfo.InvariantCulture);
            
            Console.WriteLine("Você digitou o número " + n1);
            Console.WriteLine("Você digitou: " + caractere);
            Console.WriteLine("Digitou: " + n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
