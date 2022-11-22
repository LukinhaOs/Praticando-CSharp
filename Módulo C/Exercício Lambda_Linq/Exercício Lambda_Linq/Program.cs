using System;
using Exercício_Lambda_Linq.Entidades;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercício_Lambda_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o diretório do relatório dos empregados. Ex - [C:\'Users\'Teste\'relatório_empregado.txt]: ");
            string trilha = Console.ReadLine();

            Console.Write("Tudo certo! Agora é necessário informar o salário R$");
            double salarioDado = double.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Empregado> dados = new List<Empregado>();

            using (StreamReader leitor = File.OpenText(trilha))
            {
                while (!leitor.EndOfStream)
                {
                    string[] campos = leitor.ReadLine().Split(',');
                    string nome = campos[0];
                    string email = campos[1];
                    double salario = double.Parse(campos[2], CultureInfo.InvariantCulture);
                    dados.Add(new Empregado(nome, email, salario));
                }
            }

            var relatorioEmail = dados.Where(p => p.Salario > salarioDado).OrderBy(p => p.Email).Select(p => p.Email);
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine($"Lista de email de empregados cujo salário é maior do que R${salarioDado}");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (string email in relatorioEmail)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine();
            var somaSalario = dados.Where(p => p.Nome[0] == 'M').Sum(p => p.Salario);
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine($"Soma dos salários dos empregados cujo a primeira letra do nome é 'M': R${somaSalario}");
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }
}
