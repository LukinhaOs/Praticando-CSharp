using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_L_e_C
{
    class Program
    {
        static void Main(string[] args)
        {
            // OPERADORES DE COMPARAÇÃO

            Console.WriteLine(" ----- OPERADORES DE COMPARAÇÃO ----- ");
            Console.WriteLine();

            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);

            Console.WriteLine("---------------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);

            // OPERADORES LÓGICOS

            bool op1 = 2 > 3 && 4 != 5;
            bool op2 = 2 > 3 || 4 != 5;
            bool op3 = !(5 > 60) && 8 != 10;

            Console.WriteLine(op1);
            Console.WriteLine(op2);
            Console.WriteLine(op3);

            Console.WriteLine("-------------------");

            bool op4 = 10 < 5;
            bool op5 = op1 || op2 && op4;
            Console.WriteLine(op4);
            Console.WriteLine(op5);
        }
    }
}
