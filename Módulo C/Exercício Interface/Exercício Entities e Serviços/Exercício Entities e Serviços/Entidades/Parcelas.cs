using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercício_Entities_e_Serviços.Entidades
{
    class Parcelas
    {
        public DateTime DataVencimento { get; set; }
        public double Quantia { get; set; }

        public Parcelas (DateTime vencimento, double quantia)
        {
            DataVencimento = vencimento;

            Quantia = quantia;
        }

        public override string ToString()
        {
            return DataVencimento.ToString("dd/MM/yyyy")
                + " - "
                + Quantia.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
