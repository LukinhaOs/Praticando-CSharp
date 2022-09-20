using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_Gerais
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercícios  PARTE 1

            Console.WriteLine("Digite um número para somar: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ótimo! Agora digite mais um número: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine($"A soma dos valores informados {n1} + {n2} é {soma}");

            // EXE002

            Console.WriteLine("Área do circulo!");
            Console.WriteLine("Informe o raio do Circulo abaixo: ");
            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159;
            double area = pi * raio * raio;
            Console.WriteLine($"A área do circulo é {area:F4}");

            // EXE003

            Console.WriteLine("Diferença entre quatro valores inteiros: ");
            Console.WriteLine("Digite os valores a seguir abaixo; ");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int diferenca = A * B - C * D;
            Console.WriteLine($"A Diferença entre os números informados é {diferenca}");

            // EXE004

            Console.WriteLine("Valor por Hora");
            Console.WriteLine("Identificação do funcionário: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Informe o valor ganho por hora: ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Agora informe as horas trabalhadas por dia: ");
            int hora = int.Parse(Console.ReadLine());
            double salario = valor * hora;
            Console.WriteLine();
            Console.WriteLine($"ID do Funcionário {id}");
            Console.WriteLine("Seu valor ganho no dia é R$" + salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();

            // EXE005

            Console.WriteLine("Soma por unidade e valor");
            Console.WriteLine("Informe o código da peça1: ");
            int peca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o código da peça2: ");
            int peca2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Informe a quantidade da peça CÓD{peca1}");
            int qnt1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Informe a quantidade da peça CÓD{peca2}");
            int qnt2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Informe o valor da peça CÓD{peca1}");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe o valor da peça CÓD{peca2}");
            double valor2 = double.Parse(Console.ReadLine());
            double total;
            total = valor1 * qnt1 + valor2 * qnt2;
            Console.WriteLine("O valor total da compra das peças: " + peca1 + " e " + peca2 + " foi de R$ " + total.ToString("F2", CultureInfo.InvariantCulture)); 
        }
    }
}
