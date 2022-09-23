using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_condicional_if___else___2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome, caro(a) visitante.");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o horário atual");
            Console.WriteLine("Exemplo: 12, 13, 14...");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12) {
                Console.WriteLine($"Tenha um bom dia! {nome}");
            }
            else if (hora >= 12 && hora < 18) {  //  ou else if (hora < 18) {}...
                Console.WriteLine($"Tenha uma boa tarde! {nome}");
            }  
            else
            {
                Console.WriteLine($"Tenha uma boa noite. {nome}");
            }
        }
    }
}
