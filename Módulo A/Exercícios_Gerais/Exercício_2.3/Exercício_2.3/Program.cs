using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números Múltiplos!");
            Console.WriteLine("Informe um número inteiro");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe outro número inteiro");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0 && num2 % 2 == 0) {
                Console.WriteLine($"Os números informados {num1} e {num2} são números múltiplos entre si");
            } 
            else {
                Console.WriteLine($"Os números infromados {num1} e {num2} não são múltiplos entre si.");
            }
        }
    }
}
