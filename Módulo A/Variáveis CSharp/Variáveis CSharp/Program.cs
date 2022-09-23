using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variáveis_CSharp
{
    class Variaveis
    {
        static void Main(string[] args)
        {
            bool finalizado = false;
            char genero = 'F';
            char caractere = '\u0041';
            sbyte num = 100;
            sbyte n1 = 127;
            n1++;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string frase = "Hoje é um dia ensolarado!";
            object obj1 = "Lucas Silva";
            object obj2 = 2022;


            Console.WriteLine(genero);
            Console.WriteLine(finalizado);
            Console.WriteLine(num);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(caractere);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(frase);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);


            int min = int.MinValue;
            Console.WriteLine(min);
            int max = int.MaxValue;
            Console.WriteLine(max);
            sbyte numero3 = sbyte.MinValue;
            Console.WriteLine(numero3);
            decimal numero4 = decimal.MaxValue;
            Console.WriteLine(numero4);
        }
    }
}
