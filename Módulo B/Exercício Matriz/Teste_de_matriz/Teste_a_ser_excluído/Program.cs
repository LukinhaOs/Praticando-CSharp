using System;

namespace Teste_a_ser_excluído
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número para efetuar a dimensão da sua matriz: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Número informado com sucesso! Sua matriz será {num} x {num}");

            int[,] matriz = new int[num, num];

            Console.WriteLine("Números? Ex: 2 8 7... > ");
            for (int linha = 0; linha < num; linha++)
            {
                string[] modelo = Console.ReadLine().Split(" ");
                for (int coluna = 0; coluna < num; coluna++)
                {
                    matriz[linha, coluna] = int.Parse(modelo[coluna]);
                }
            }

            int contador = 0;

            for(int linha = 0; linha < num; linha++)
            {
                for(int coluna = 0; coluna < num; coluna++)
                {
                    if(matriz[linha, coluna] < 0)
                    {
                        contador++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sua matriz foi criada!");
            Console.WriteLine();
            Console.WriteLine($"Total de números: {matriz.Length}");
            Console.WriteLine();
            Console.WriteLine($"Números negativos da matriz: {contador}");
            Console.WriteLine();

            Console.Write("Números da Diagonal: ");
            for (int diag = 0; diag < num; diag ++)
            {
                Console.Write(matriz[diag, diag] + " ");
            }
            Console.WriteLine();
        }
    }
}