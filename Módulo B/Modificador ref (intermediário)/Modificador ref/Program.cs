using System;

namespace Modificador_ref
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando o valor triplo...");

            int a = 10;
            Calculator.Triplo(ref a);
            Console.WriteLine($"O triplo de 10 e {a}");

            Console.WriteLine("Calculando o valor triplo...");

            int b = 15;
            int triplo; 
            Calculator.TriploTipo2(b, out triplo);
            Console.WriteLine($"O triplo de 15 e {triplo}");

        }
    }
}