using System;

namespace Exercício_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont_intervalo = 0;
            int cont_fora = 0;
            int numero = 0;

            Console.Write("Informe um valor para conferir o intervalo entre 10 e 20: ");
            numero = int.Parse(Console.ReadLine());


            for (int valor = 0; valor <= numero; valor++)
            {
                if (valor >= 10 && valor <= 20)
                {
                    cont_intervalo = cont_intervalo + 1;
                }
                else
                {
                    cont_fora = cont_fora + 1;
                }
            }
            Console.WriteLine("Contagem finalizada!");
            Console.WriteLine($"Valores dentro do intervalo {cont_intervalo} ");
            Console.Write($"Valores fora do intervalo {cont_fora} ");
        }
    }
}
