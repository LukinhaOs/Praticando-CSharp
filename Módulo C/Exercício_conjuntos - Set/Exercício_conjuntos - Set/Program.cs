using System;
using System.Collections.Generic;
using Exercício_conjuntos___Set.Entidades;

namespace Exercício_conjuntos___Set
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> turmaA = new HashSet<int>();
            HashSet<int> turmaB = new HashSet<int>();
            HashSet<int> turmaC = new HashSet<int>();


            Console.WriteLine("Informe a quantidade de alunos para o cadastro na turma A: ");
            int alunos = int.Parse(Console.ReadLine());
            for (int i = 0; i < alunos; i++)
            {
                Console.WriteLine($"Informe o código do {i+1}° Aluno: ");
                int cod = int.Parse(Console.ReadLine());
                turmaA.Add(cod);
            }

            Console.WriteLine("Informe a quantidade de alunos para o cadastro na turma B: ");
            alunos = int.Parse(Console.ReadLine());
            for (int i = 0; i < alunos; i++)
            {
                Console.WriteLine($"Informe o código do {i + 1}° Aluno: ");
                int cod = int.Parse(Console.ReadLine());
                turmaB.Add(cod);
            }

            Console.WriteLine("Informe a quantidade de alunos para o cadastro na turma C: ");
            alunos = int.Parse(Console.ReadLine());
            for (int i = 0; i < alunos; i++)
            {
                Console.WriteLine($"Informe o código do {i + 1}° Aluno: ");
                int cod = int.Parse(Console.ReadLine());
                turmaC.Add(cod);
            }

            HashSet<int> all = new HashSet<int>(turmaA);
            all.UnionWith(turmaB);
            all.UnionWith(turmaC);
            Console.WriteLine("Total de alunos cadastrados: " + all.Count);
        }
    }
}