using System;
using System.Globalization;
using Exercício_Composição_de_Objetos.Entities.Enums;
using Exercício_Composição_de_Objetos.Entities;

namespace Exercício_Composição_de_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome do Departamento: ");
            string deptname = Console.ReadLine();
            Console.Write("Informe o nome do Funcionário: ");
            string name = Console.ReadLine();
            Console.Write("Nível (Junior/MidLevel/Sênior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário padrão: R$");
            double stocksalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptname);
            Worker trabalhador = new Worker(name, level, stocksalary, dept);

            Console.WriteLine($"Quantos contratos para o funcionário {name}");
            int qnt = int.Parse(Console.ReadLine());

            for (int item = 0; item < qnt; item++)
            {
                Console.Write($"Informe o #{item+1} data de contrato: ");
                Console.Write($"Data (dia/mês/ano): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora R$");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Carga horário do trabalho: ");
                int horas = int.Parse(Console.ReadLine());
                HourContract contrato = new HourContract(data, valuePerHour, horas);
                trabalhador.AddContract(contrato);
            }

            Console.Write("Informe (Mês/Ano): ");
            string MesAno = Console.ReadLine();
            int mes = int.Parse(MesAno.Substring(0, 2));
            int ano = int.Parse(MesAno.Substring(3));

            Console.WriteLine();
            Console.WriteLine($"Nome: {trabalhador.Name}");
            Console.WriteLine($"Departamento: {trabalhador.Department.Name}");
            Console.WriteLine($"Valor ganho R${trabalhador.Income(ano, mes).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
