using System;
using Herança.Entidades;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaEmpresa conta = new ContaEmpresa(8010, "Jennifer", 100.0, 500.0);

            Console.WriteLine(conta.Saldo);
        }
    }
}
