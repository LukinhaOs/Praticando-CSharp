using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercício_fixação_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários seram vinculados ao Banco de Dados? ");
            int nf = int.Parse(Console.ReadLine());

            List<Funcionario> empregado = new List<Funcionario>();

            for (int item = 0; item < nf; item++)
            {
                Console.Write("Informe o nome do funcionário: ");
                string nome = Console.ReadLine();
                Console.Write($"ID do {nome}: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Informe Salário R$");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empregado.Add(new Funcionario(nome, id, salario));
                Console.WriteLine();
            }

            Console.Write("Informe o ID do funcionário para o aumento percentual: ");
            int pesquisaID = int.Parse(Console.ReadLine());

            Funcionario dado = empregado.Find(x => x.IDEmpregrado == pesquisaID);

            if (dado != null)
            {
                Console.Write($"ID informado {pesquisaID}. Qual será o aumento percentual do salário? ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dado.AumentoSalarial(porcentagem);
            }
            else
            {
                Console.WriteLine("ID informado não existe no Banco de dados, confira o ID e tente novamnte!");
            }
            Console.WriteLine(" ----- Dados dos Funcionários ----- ");
            foreach (Funcionario info in empregado)
            {
                Console.WriteLine(info);
            }
        }
    }
}