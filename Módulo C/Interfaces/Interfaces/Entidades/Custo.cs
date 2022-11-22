using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Interfaces.Entidades
{
    class Custo
    {
        public double PagamentoBase { get; set; }
        public double Taxa { get; set; }

        public Custo(double pagamentoBase, double taxa)
        {
            PagamentoBase = pagamentoBase;
            Taxa = taxa;
        }

        public double PagamentoTotal
        {
            get { return PagamentoBase + Taxa; }
        }

        public override string ToString()
        {
            return "Pagamento base R$ " + PagamentoBase.ToString("F2", CultureInfo.InvariantCulture)
                + " Taxa R$ " + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + " Pagamento total R$ " + PagamentoTotal.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
