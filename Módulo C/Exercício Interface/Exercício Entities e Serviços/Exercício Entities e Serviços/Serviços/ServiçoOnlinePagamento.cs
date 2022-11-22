using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Entities_e_Serviços.Serviços
{
    interface ServiçoOnlinePagamento
    {
        double interesse(double quantia, int meses);
        double taxaPagamento(double quantia);
    }
}
