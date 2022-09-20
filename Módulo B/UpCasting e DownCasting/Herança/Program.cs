using System;
using Herança.Entidades;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta cc = new Conta(1005, "João", 2001.00);
            ContaEmpresa ecc = new ContaEmpresa(1005, "Joana", 0.0, 500.00);

            // UPCASTING

            Conta acc1 = ecc;
            Conta acc2 = new ContaEmpresa(1002, "Julio", 0.00, 1500.00);
            Conta acc3 = new Poupanca(0256, "Lucas", 0.00, 0.01);

            //DOWNCASTING

            ContaEmpresa acc4 = (ContaEmpresa)acc2;
            acc4.Emprestimo(100.0);

            //ContaEmprea acc5 = (ContaEmpresa) acc3;
            if (acc3 is ContaEmpresa)
            {
                // ContaEmpresa acc5 = (ContaEmpresa)acc3;
                ContaEmpresa acc5 = acc3 as ContaEmpresa;
                acc5.Emprestimo(200.00);
                Console.WriteLine("Tudo certo!");
            }
            if (acc3 is Poupanca)
            {
                //Poupanca acc5 = (Poupanca)acc3;
                Poupanca acc5 = acc3 as Poupanca;
                acc5.AtulizarSaldo();
                Console.WriteLine("Saldo Atualizado!");
            }
        }
    }
}
