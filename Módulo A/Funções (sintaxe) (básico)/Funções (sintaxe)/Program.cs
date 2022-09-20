using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções__sintaxe_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe três número inteiros ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            // F9 (Executa o Debug para leitura do código passo a passo)
            // F5 (Permite a contínua leitura do código passo a passo no degub através do F9)
            // F10 (Executa um passo, entra na função)
            // F11 (Executa um passo na função)


            double resultado = maior(num1, num2, num3);
            Console.WriteLine($"O maior número é {resultado}");
         }


        static int maior(int a, int b, int c) {
            int m;
            if (a > b && a > c) {
                m = a;
            }
            else if (b > c) {
                m = b;
            }
            else {
                m = c;
            }
            return m;
        }
    }
}
