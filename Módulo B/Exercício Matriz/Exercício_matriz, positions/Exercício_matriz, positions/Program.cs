using System;

namespace Exercício_matriz__positions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a dimensão da sua matriz, linha: ");
            int numl = int.Parse(Console.ReadLine());
            Console.Write("Informe a dimensão da sua matriz, agora a coluna: ");
            int numc = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Números inseridos com sucesso, agora sua matriz {numl} x {numc}");

            Console.WriteLine();
            Console.WriteLine("Digite os valores ex: 4 5 9... >");
            int[,] matriz = new int[numl, numc];

            Console.WriteLine("Matriz criada com sucesso!");

            for (int linha = 0; linha < numl; linha++)
            {
                string[] modelo = Console.ReadLine().Split(" ");
                for (int coluna = 0; coluna < numc; coluna++)
                {
                    matriz[linha, coluna] = int.Parse(modelo[coluna]);
                }
            }

            Console.Write("Informe o valor na qual deseja conferir as posições da matriz: ");
            int numchave = int.Parse(Console.ReadLine());
            int contador = 0;

            for (int linha = 0; linha < numl; linha++)
            {
                for (int coluna = 0; coluna < numc; coluna++)
                {
                    if (matriz[linha, coluna] == numchave)
                    {
                        Console.WriteLine($"Posição do número {numchave} {linha} ',' {coluna} : ");
                        if (coluna > 0)
                        {
                            Console.WriteLine($"Esquerda: {matriz[linha, coluna - 1]}");
                        }
                        if (linha > 0)
                        {
                            Console.WriteLine($"Posição a cima: {matriz[linha - 1, coluna]}");
                        }
                        if (coluna < numc - 1)
                        {
                            Console.WriteLine($"Direita: {matriz[linha, coluna + 1]}");
                        }
                        if (linha < numl - 1)
                        {
                            Console.WriteLine($"Posição abaixo: {matriz[linha + 1, coluna]}");
                        }
                    }
                    if (matriz[linha, coluna] == numchave)
                    {
                        contador++;
                        Console.WriteLine($"Quantidade do número {numchave} inserido: {contador}");
                    }
                }
            }
        }
    }
}