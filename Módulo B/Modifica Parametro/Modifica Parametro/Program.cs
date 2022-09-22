using System;

namespace Modifica_Parametro
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Caculadora.Soma(2, 3);
            int s2 = Caculadora.Soma(2, 8, 3);

            Console.WriteLine($"A soma do s1 {s1}");
            Console.WriteLine($"A soma do s2 {s2}");
        }
    }
}
