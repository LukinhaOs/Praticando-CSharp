using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número Inteiro ");
            int num = int.Parse(Console.ReadLine());
            if (num < 0) {
                Console.WriteLine($"O número {num} é um número negativo!");    
            }
            else{
                Console.WriteLine($"O número {num} é m número positivo!");
            }
        }
    }
}
