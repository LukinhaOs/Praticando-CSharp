using System;

namespace Exercício_3._3
{
    class Program
    {
        static void Main(string[] args)
        {

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;


            Console.WriteLine("---------------------------");
            Console.WriteLine("---------1. ALCOOL --------");
            Console.WriteLine("---------2. GASOLINA ------");
            Console.WriteLine("-------- 3. DIESEL --------");


            Console.WriteLine("Informe o código do produto");
            int option = int.Parse(Console.ReadLine());

            while (option != 4)
            {
                if (option == 1)
                {
                    alcool = alcool + 1;
                }
                else if (option == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (option == 3)
                {
                    diesel = diesel + 1;
                }
                option = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Muito obrigado !");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
