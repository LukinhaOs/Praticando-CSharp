using System;
using System.Globalization;

namespace Exercício_Encapsulamento
{
    class ContaBancaria
    {
        public string Titular { get; set;  }
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set;  }


        public ContaBancaria(string nome, int numeroconta, double saldo)
        {
            Titular = nome;
            NumeroConta = numeroconta;
            Saldo = saldo;
        }

        public ContaBancaria(string nome, int numeroconta)
        {
            Titular = nome;
            NumeroConta = numeroconta;
            Saldo = 0;
        }

        public void Deposito(double saldoanterior)
        {
            Saldo += saldoanterior;
        }

        public void Saque(double saldoanterior)
        {
            Saldo -= saldoanterior + 5.00;
        }

        public override string ToString()
        {
            return "Número da conta: " + $"{NumeroConta} | "
                + " Titular " + $"{Titular} |"
                + " Saldo Atual R$" + $"{Saldo}";
        }
    }
}
