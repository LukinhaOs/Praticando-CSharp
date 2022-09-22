using System;
using System.Globalization;

namespace Expressão__condicional_ternária
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            
                                               //VERDADEIRO//  //FALSO//
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            
           
            /* if (preco > 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            } */

            Console.WriteLine($"O Valor com desconto {desconto.ToString(CultureInfo.InvariantCulture)}");
        }
    }
}
