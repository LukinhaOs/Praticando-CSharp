using System;
using GetHashCode_e_Equals.Entidades;

namespace GetHashCode_e_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "Paulo";
            //string b = "Paulo";

            //Console.WriteLine(a.Equals(b)); // Exibe Verdadeiro ou Falso 'Equals'
            //Console.WriteLine(a.GetHashCode()); // Retorna valores númericos
            //Console.WriteLine(b.GetHashCode());

            Cliente a = new Cliente { Nome = "Lucas", Email = "lukiluka@gmail.com" };
            Cliente b = new Cliente { Nome = "Luciana", Email = "lucilu2gmail.com" };

            Console.WriteLine(a.Equals(b)); 
            Console.WriteLine(a == b); // O ponto de referência da memória irá exibir um resultado diferente
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
