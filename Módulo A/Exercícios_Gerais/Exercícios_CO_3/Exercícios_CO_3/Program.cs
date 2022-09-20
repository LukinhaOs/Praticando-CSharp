using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_CO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Media aluno;
            aluno = new Media();

            Console.Write("Informe o nome do Aluno(a): ");
            String nome = Console.ReadLine();
            Console.WriteLine($"Informe a sua nota A1 {nome}; ");
            aluno.A1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            Console.WriteLine("Agora a sua nota A2; ");
            aluno.A2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Por último sua nota A3; ");
            aluno.A3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.md1 = aluno.AF1();
            aluno.nr1 = aluno.NotarestanteAF1();
            aluno.md2 = aluno.AF2();
            aluno.nr2 = aluno.NotarestanteAF2();


            Console.WriteLine("================================================================");
            Console.WriteLine($"MÉDIA FINAL DO(A) {nome} | 1° Semestre");
            Console.WriteLine();
            Console.WriteLine($"NOTAS: A1 {aluno.A1} | A2 {aluno.A2} | A3 {aluno.A3} | Peso 3.0");
            Console.Write($"Nota Final do aluno(a) {nome} | Média: {(aluno.md1.ToString("F2", CultureInfo.InvariantCulture))}");
            Console.WriteLine();
            Console.WriteLine("================================================================");

            if (aluno.Aprovado1()) {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"Faltam {aluno.nr1} pontos para efetuar a sua Aprovação!");
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("================================================================");
            Console.WriteLine($"MÉDIA FINAL DO(A) {nome} | 2° Semestre");
            Console.WriteLine();
            Console.WriteLine($"NOTAS: A1 {aluno.A1} | A2 {aluno.A2} | A3 {aluno.A3} | Peso 3.5");
            Console.Write($"Nota Final do aluno(a) {nome} | Média: {aluno.md2.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine("================================================================");
    
            if (aluno.Aprovado2())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"Faltam {aluno.nr2} pontos para efetuar a sua aprovação!");
            }
            Console.WriteLine();
        }
    }
}
