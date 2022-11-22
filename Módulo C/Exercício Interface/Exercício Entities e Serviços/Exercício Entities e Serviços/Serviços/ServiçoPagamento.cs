using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Entities_e_Serviços.Serviços
{
    class ServiçoPagamento : ServiçoOnlinePagamento
    {
        private const double taxaPorcentagem = 0.02;
        private const double taxaMes = 0.01;

        public double interesse(double quantia, int meses)
        {
            return quantia * taxaMes * meses;
        }

        public double taxaPagamento(double quantia)
        {
            return quantia * taxaPorcentagem;
        }
    }
}
