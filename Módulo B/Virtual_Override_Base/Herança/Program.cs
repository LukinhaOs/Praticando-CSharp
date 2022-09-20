using System;
using Herança.Entidades;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta acc1 = new Conta(1254, "João", 250.00);
            Conta acc2 = new Poupanca(1002, "Juan", 1200.00, 0.01);

            acc1.Saque(10.0);
            acc2.Saque(10.0);

            Console.WriteLine(acc1.Saldo); // Utilize "Virtual" na subClasse para ser sobrescrita!
            Console.WriteLine(acc2.Saldo); // Utilize Override + "Virtual" da subclasse para modificar a operação Sem alterar outra SubClasse!
        }
    }
}
