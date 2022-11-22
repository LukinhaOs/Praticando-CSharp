using System;

namespace Generics_Set_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Digite ServicoPrint<int> print = new ServicoPrint<int>(); Para números inteiros, também pode ser double, float...
            // Digite ServicoPrint<string> print = new ServicoPrint,string>(); Para Caracteres

            ServicoPrint<int> print = new ServicoPrint<int>();
            Console.Write("Quantos valores? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                print.addValor(x);
            }
            
            /*
            Será preciso conver o "OBJECT" conforme procedimento abaixo (não recomendado)

            int a = (int)ServicoPrint.PrimeiroValor();
            int b = a + 2;
            Console.Write(b);

            */

            print.Print();
            Console.Write("Primeiro: " + print.PrimeiroValor());
        }
    }
}
