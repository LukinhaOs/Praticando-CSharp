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

        /* public override void Saque(double quantia)
        {
            Saldo -= quantia;
        } */

        public override void Saque(double quantia)
        {
            base.Saque(quantia); // Com o Base é possível de reaproveitar a SuperClasse (segue o procedimento e mais um novo)
            Saldo -= 2.0;        // "Seaaled" é um recurso para bloquear a subClasse para o uso em outras Classes
        }
    }
}
