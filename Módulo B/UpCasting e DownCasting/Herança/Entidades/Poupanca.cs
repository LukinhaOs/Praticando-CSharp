using System;
using System.Collections.Generic;
using System.Text;
using Herança.Entidades;

namespace Herança.Entidades 
{
    class Poupanca : Conta
    {
        public double Juros { get; set; }

        public Poupanca()
        {

        }

        public Poupanca(int numero, string titular, double saldo, double juros) 
         : base(numero, titular, saldo)
        {
            Juros = juros;
        }

        public void AtulizarSaldo()
        {
            Saldo += Saldo * Juros;
        }
    }
}
