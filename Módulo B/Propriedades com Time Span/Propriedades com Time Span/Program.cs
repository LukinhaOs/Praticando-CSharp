using System;

namespace Propriedades_com_Time_Span
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan teste1 = new TimeSpan(2, 10, 10);
            TimeSpan teste2 = new TimeSpan(1, 30, 5);

            TimeSpan soma = teste1.Add(teste2);
            TimeSpan menos = teste1.Subtract(teste2);
            TimeSpan multi = teste1.Multiply(2.0);
            TimeSpan divi = teste1.Divide(2.0);

            Console.WriteLine($"A soma de TimeSpan é {soma}");
            Console.WriteLine($"A subtração de TimeSpan é {menos}");
            Console.WriteLine($"A multiplicação de TimeSpan por 2 é {multi}");
            Console.WriteLine($"A divisão do TimeSpan por 2 é {divi}");
        }
    }
}
