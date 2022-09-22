using System;
using Herança.Entidades;
using System.Collections.Generic;
using System.Globalization;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> list = new List<Conta>();

            list.Add(new Poupanca(1254, "Alex", 500.0, 0.01));
            list.Add(new ContaEmpresa(1256, "Ana", 500.0, 400.0));
            list.Add(new Poupanca(1544, "Juan", 550.0, 0.01));
            list.Add(new ContaEmpresa(1246, "Kiko", 500.0, 500.0));

            double soma = 0.0;

            foreach(Conta cc in list)
            {
                soma += cc.Saldo; 
            }

            foreach(Conta saq in list)
            {
                saq.Saque(10.0);
                
            }
            Console.WriteLine("Soma dos saldos R$" + soma);
            Console.WriteLine();
            foreach (Conta att in list)
            {
                Console.WriteLine("Dados atualizados; " +
                    att.Numero + ": R$" + att.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
