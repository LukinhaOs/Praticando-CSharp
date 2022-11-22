using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Serviços
{
    class CalculoServico
    {
        // com um método void, é possível de aplicar Multi delegates
        public static void ShowSoma(double n1, double n2)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine($"A soma entre os valores {n1} e {n2} é {n1+n2}");
            Console.WriteLine();
        }

        /* com um método static, não possível de aplicar Multi delegates
         
        public static double ShowSoma(double n1, double n2)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine($"A soma entre os valores {n1} e {n2} é "); return n1 + n2; 
        }
        */
        public static void ShowMax(double n1, double n2)
        {
            if (n1 > n2)
            {
                Console.WriteLine("===============================================");
                double maior = n1;
                Console.WriteLine($"Entre os números {n1} e {n2} o maior é {maior}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("===============================================");
                double maior = n2;
                Console.WriteLine($"Entre os números {n1} e {n2} o maior é {maior}");
                Console.WriteLine();
            }
        }

        public static void ShowSquare(double n1)
        {
            Console.WriteLine("=============================");
            double square =  n1 * n1;
            Console.WriteLine($"{n1} ao quadrado e {n1 * n1}");
        }
    }
}
