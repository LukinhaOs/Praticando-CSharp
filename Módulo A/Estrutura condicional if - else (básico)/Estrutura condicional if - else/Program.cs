using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_condicional_if___else
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Par ou Ímpar?");
            Console.WriteLine("Informe um número inteiro e veja se é par ou ímpar: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) {
                Console.WriteLine($"O número {a} é um número par!");
            }
            else {
                Console.WriteLine($"O número {a} é um número ímpar!");
            }
                
        }
    }
}
