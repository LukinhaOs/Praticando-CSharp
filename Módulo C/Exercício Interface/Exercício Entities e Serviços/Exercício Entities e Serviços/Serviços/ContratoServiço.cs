using System;
using System.Collections.Generic;
using System.Text;
using Exercício_Entities_e_Serviços.Entidades;

namespace Exercício_Entities_e_Serviços.Serviços
{
    class ContratoServiço
    {
        private ServiçoOnlinePagamento serviçosOnline;

        public ContratoServiço(ServiçoOnlinePagamento _serviçosOnline)
        {
            serviçosOnline = _serviçosOnline;
        }

        public void processoContrato(Contrato contrato, int meses)
        {
            double quotaBasica = contrato.ValorTotal / meses;

            for (int i = 1; i <= meses; i ++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double atualizaQuota = quotaBasica + serviçosOnline.interesse(quotaBasica, i);
                double cheiaQuota = atualizaQuota + serviçosOnline.taxaPagamento(atualizaQuota);
                contrato.AddParcelas(new Parcelas(data, cheiaQuota));

            }
        }
    }
}
