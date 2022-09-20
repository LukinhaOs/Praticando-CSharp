using System;

namespace Exercício_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] info = new int[n, n];

            for (int l = 0; l < n; l ++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int c = 0; c < n; c ++ )
                {
                    info[l, c] = int.Parse(valores[c]);
                }
            }


            Console.WriteLine("Diagonal na Matriz");
            for (int dig = 0; dig < n; dig ++)
            {
                Console.Write(info[dig,dig] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(info[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.Write($"Exsitem {count} números negativos na matriz");
        }
    }
}
