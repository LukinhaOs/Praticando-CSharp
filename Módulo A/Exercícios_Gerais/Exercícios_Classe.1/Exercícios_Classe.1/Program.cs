using System;
using System.Globalization;

namespace Exercícios_Classe._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Medias p1, p2;
            double medsalario = 0;

            p1 = new Medias();
            p2 = new Medias();

            Console.WriteLine("Informe os dados dos funcionários logo abaixo;");
            Console.Write("Nome do 1° Funcionário: ");
            p1.Nome = (Console.ReadLine());
            Console.Write($"Salário atual do(a) {p1.Nome} R$");
            p1.Salario = double.Parse(Console.ReadLine());

            Console.Write("Nome do 2° Funcionário: ");
            p2.Nome = (Console.ReadLine());
            Console.Write($"Salário do(a) {p2.Nome} R$");
            p2.Salario = double.Parse(Console.ReadLine());

            medsalario = (p1.Salario + p2.Salario) / 2;

            Console.WriteLine("--- Dados individuais ---");
            Console.WriteLine("Funcionário. " + p1.Nome + "| Salário " + p1.Salario.ToString(CultureInfo.InvariantCulture));
            Console.Write("Funcionário. " + p2.Nome + "| Salário " + p2.Salario.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.Write("Média salarial dos funcionários analisados: R$" + medsalario.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
 