using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversão_implicíta_e_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;

            double resultado = (double) a / b;
            Console.WriteLine(resultado);

            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);
            int n2 = (4 + 8) * 2;
            Console.WriteLine(n2);
            int n3 = 17 % 3;
            Console.WriteLine(n3);
            double n4 = 10.0 / 8;
            Console.WriteLine(n4);

            double num1 = 1.0, num2 = -3.0, num3 = -4.0;
            double delta = Math.Pow(num2, 2.0) - 4.0 * num1 * num3;

            double x1 = (-num2 + Math.Sqrt(delta)) / (2.0 * num1);
            double x2 = (-num2 - Math.Sqrt(delta)) / (2.0 * num1);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
