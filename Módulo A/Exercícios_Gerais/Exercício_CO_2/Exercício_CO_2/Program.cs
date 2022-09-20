using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_CO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario funcionario;
            funcionario = new Salario();
            
            Console.Write("Informe o nome do funcionário(a): ");
            String nome = (Console.ReadLine());
            Console.Write($"Informe o salário do(a) {nome} R$");
            funcionario.salarioatual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Agora é necessário informar a porcentagem de aumento: ");
            funcionario.porcentagem = int.Parse(Console.ReadLine());

            double novosalario = funcionario.aumento();

            Console.WriteLine($"Salário bruto de {nome} R${funcionario.salarioatual.ToString(CultureInfo.InvariantCulture)} ");
            Console.Write($"Novo salário com aumento de {funcionario.porcentagem}% - R${novosalario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
        }
    }
}
