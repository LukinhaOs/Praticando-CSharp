using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputCS
{
    class Program
    {
        static void Main(string[] args)
        {

            char genero = 'F';
            int idade = 22;
            double saldo = 15.258485;
            string nome = "Carla";

            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("-------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine("=========================");
            Console.WriteLine("Saldo Arredondado");
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("==========================================");
            Console.WriteLine("RESUMO: ");
            Console.WriteLine();
            Console.WriteLine("{0} tem {1} anos de idade e saldo R${2:F2}", nome, idade, saldo);
            Console.WriteLine();
            Console.WriteLine("==========================================");

            Console.WriteLine($"{nome} tem {idade} anos e saldo R${saldo:F2}");
        }
    }
}
