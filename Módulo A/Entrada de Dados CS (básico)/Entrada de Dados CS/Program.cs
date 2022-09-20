using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_de_Dados_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------- PARTE 1 ------------------

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            
            Console.WriteLine("Você digitou: " + frase);
            Console.WriteLine("E depois... " + x);
            Console.WriteLine("Novamente... " + y);
            Console.WriteLine("Última frase digitada: " + z);

            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];
            string d = v[3];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
